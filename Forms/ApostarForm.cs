using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaOncinha.Data;
using JogoDaOncinha.Models;
using JogoDaOncinha.Repositories;

namespace JogoDaOncinha.Forms
{
    public partial class ApostarForm : Form
    {
        private AppDbContext _context;  // Conexão com o banco de dados com Entity Framework, context é, basicamente, o banco em si.

        // Cria o repositório para acessar dados de cada entidade
        private GenericRepository<Usuario> _usuarioRepo;
        private GenericRepository<Jogo> _jogoRepo; 
        private GenericRepository<Aposta> _apostaRepo; 

        public ApostarForm()
        {
            InitializeComponent();
            _context = new AppDbContext();

            // Cria instâncias dos repositórios para cada entidade, injetando o contexto do banco de dados
            _usuarioRepo = new GenericRepository<Usuario>(_context);
            _jogoRepo = new GenericRepository<Jogo>(_context);
            _apostaRepo = new GenericRepository<Aposta>(_context);

            CarregarDados();
        }

        // Aqui é basicamente onde carrega os dados para os comboboxes, que são as listas suspensas
        private void CarregarDados()
        {
            cbUsuarios.DataSource = _usuarioRepo.GetAll().ToList();
            cbUsuarios.DisplayMember = "Nome";
            cbUsuarios.ValueMember = "Id";

            cbJogos.DataSource = _jogoRepo.GetAll().ToList();
            cbJogos.DisplayMember = "TimeCasa";
            cbJogos.ValueMember = "Id";

            cbEscolha.Items.Add("Casa");
            cbEscolha.Items.Add("Visitante");
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)cbUsuarios.SelectedItem;
            var jogo = (Jogo)cbJogos.SelectedItem;
            var escolha = cbEscolha.SelectedItem?.ToString();

            if (!decimal.TryParse(txtValor.Text, out decimal valor))
            {
                MessageBox.Show("Valor inválido!");
                return;
            } // Valida se o valor é um decimal

            if (usuario.Saldo < valor)
            {
                MessageBox.Show("Saldo insuficiente!");
                return;
            } // Valida se o saldo é suficiente para a aposta

            var aposta = new Aposta
            {
                UsuarioId = usuario.Id,
                JogoId = jogo.Id,
                Escolha = escolha,
                Valor = valor
            };

            usuario.Saldo -= valor;
            _usuarioRepo.Update(usuario);
            _apostaRepo.Add(aposta);

            MessageBox.Show("Aposta realizada!");
            this.Close();
        }
    }
}