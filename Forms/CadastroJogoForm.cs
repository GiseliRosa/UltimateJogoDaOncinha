using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaOncinha.Models;
using JogoDaOncinha.Data;
using JogoDaOncinha.Repositories;

namespace JogoDaOncinha.Forms
{
    public partial class CadastroJogoForm : Form
    {
        private GenericRepository<Jogo> _jogoRepo;

        public CadastroJogoForm()
        {
            InitializeComponent();
            var context = new AppDbContext(); // Cria o contexto, basicamente o acesso ao banco
            _jogoRepo = new GenericRepository<Jogo>(context); // Cria o repositório para jogos
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string timeCasa = txtTimeCasa.Text;
            string timeVisitante = txtTimeVisitante.Text;

            if (!decimal.TryParse(txtOddCasa.Text, out decimal oddCasa) ||
                !decimal.TryParse(txtOddVisitante.Text, out decimal oddVisitante))
            {
                MessageBox.Show("Odds inválidas!");
                return;
            } // Valida se as odds são decimais

            var jogo = new Jogo
            {
                TimeCasa = timeCasa,
                TimeVisitante = timeVisitante,
                OddCasa = oddCasa,
                OddVisitante = oddVisitante
            };

            _jogoRepo.Add(jogo);
            MessageBox.Show("Jogo cadastrado!");
            this.Close();
        }
    }
}

