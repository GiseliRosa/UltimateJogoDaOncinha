using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using JogoDaOncinha.Models;
using JogoDaOncinha.Repositories;
using JogoDaOncinha.Data;

namespace JogoDaOncinha.Forms
{
    public partial class ListaApostasForm : Form
    {
        private AppDbContext _context;

        public ListaApostasForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void CarregarApostas()
        {
            var apostas = _context.Apostas
                .Include(a => a.Usuario)
                .Include(a => a.Jogo)
                .Select(a => new
                {
                    Usuario = a.Usuario.Nome,
                    Jogo = $"{a.Jogo.TimeCasa} x {a.Jogo.TimeVisitante}",
                    Escolha = a.Escolha,
                    Valor = a.Valor,
                    Finalizada = a.Finalizada,
                    Resultado = a.Resultado ?? "-",
                    Saldo = a.Usuario.Saldo.ToString("C")
                })
                .ToList();

            dgvApostas.DataSource = apostas;
        } // Puxa as apostas do banco e coloca no DataGridView (a tabelinha)

        private void ListaApostasForm_Load(object sender, EventArgs e)
        {
            CarregarApostas();
        } // Mostra (carrega) as apostas quando o form abre

        private void btnRolarJogo_Click(object sender, EventArgs e)
        {
            if (dgvApostas.CurrentRow == null)
            {
                MessageBox.Show("Selecione uma aposta!");
                return;
            }

            string usuarioNome = dgvApostas.CurrentRow.Cells["Usuario"].Value.ToString();
            string jogoDescricao = dgvApostas.CurrentRow.Cells["Jogo"].Value.ToString();
            string escolha = dgvApostas.CurrentRow.Cells["Escolha"].Value.ToString();
            decimal valor = Convert.ToDecimal(dgvApostas.CurrentRow.Cells["Valor"].Value);

            // Buscar aposta original no banco
            // Buscar todas as apostas e filtrar na memória
            var apostas = _context.Apostas
                .Include(a => a.Usuario)
                .Include(a => a.Jogo)
                .Where(a => !a.Finalizada) // Filtro para pegar apenas apostas não finalizadas
                .ToList(); // O ToList() é necessário para carregar os dados do banco antes de filtrar na memória.
                           // Sem ele não é possível realizar uma aposta pois o banco não ia reconhecer a concatenação das strings a.Jogo.TimeCasa + " x " + a.Jogo.TimeVisitante.
                           // Porquê? Não sei, mas o Entity Framework não consegue fazer isso. Então, a gente puxa tudo do banco e filtra na memória mesmo.

            // Agora da pra filtrar usando string + string
            var aposta = apostas.FirstOrDefault(a =>
                a.Usuario.Nome == usuarioNome &&
                (a.Jogo.TimeCasa + " x " + a.Jogo.TimeVisitante) == jogoDescricao &&
                a.Valor == valor);

            if (aposta == null)
            {
                MessageBox.Show("Aposta já finalizada ou não encontrada.");
                return;
            }

            // Gerar resultado aleatório
            string[] opcoes = { "Casa", "Visitante", "Empate" };
            Random rand = new Random();
            string resultado = opcoes[rand.Next(opcoes.Length)];

            aposta.Resultado = resultado;
            aposta.Finalizada = true;

            decimal ganho = 0;

            if (aposta.Escolha == resultado) //É green papai
            {
                if (resultado == "Casa")
                    ganho = aposta.Valor * aposta.Jogo.OddCasa;
                else if (resultado == "Visitante")
                    ganho = aposta.Valor * aposta.Jogo.OddVisitante;
                else
                    ganho = aposta.Valor;

                aposta.Usuario.Saldo += ganho;
            }
            else if (resultado == "Empate") // Cashout, muda nada
            {
                ganho = aposta.Valor;
                aposta.Usuario.Saldo += ganho;
            }
            else // Aaaaaa parei família, é máfia
            {
                aposta.Usuario.Saldo -= aposta.Valor;
            }

            _context.SaveChanges();

            string mensagem = $"Resultado do jogo: {resultado}\n";

            if (ganho == aposta.Valor && resultado == "Empate")
                mensagem += $"Empatou! Você recuperou seu valor: R${ganho:F2}.";
            else if (ganho > 0)
                mensagem += $"Você ganhou R${ganho:F2}!";
            else
                mensagem += "Você perdeu a aposta.";

            MessageBox.Show(mensagem);
            CarregarApostas(); // Atualiza a lista de apostas pós resultado
        }

        // Para não ficar enchendo o banco de apostas finalizadas, um botão que deleta todas as apostas finalizadas
        private void btnDeletarFinalizadas_Click(object sender, EventArgs e)
        {
            var finalizadas = _context.Apostas.Where(a => a.Finalizada).ToList();

            if (finalizadas.Count == 0)
            {
                MessageBox.Show("Não há apostas finalizadas para deletar.");
                return;
            }

            _context.Apostas.RemoveRange(finalizadas);
            _context.SaveChanges();

            MessageBox.Show("Apostas finalizadas deletadas com sucesso!");
            CarregarApostas();
        }
    }
}