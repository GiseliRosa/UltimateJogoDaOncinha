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
using JogoDaOncinha.Services;
using JogoDaOncinha.Repositories;
using JogoDaOncinha.Data;

namespace JogoDaOncinha.Forms
{
    public partial class CadastroUsuarioForm : Form
    {
        private UsuarioService _usuarioService;

        public CadastroUsuarioForm()
        {
            InitializeComponent();
            var context = new AppDbContext(); // Cria o contexto, basicamente o acesso ao banco
            var usuarioRepo = new GenericRepository<Usuario>(context); // Cria o repositório para usuarios
            _usuarioService = new UsuarioService(usuarioRepo); // Injeta o repositório no serviço (sol>I<d)
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            if (!decimal.TryParse(txtSaldo.Text, out decimal saldo))
            {
                MessageBox.Show("Saldo inválido.");
                return;
            } // Valida se o saldo é um decimal

            var usuario = new Usuario
            {
                Nome = nome,
                Email = email,
                Saldo = saldo
            };

            _usuarioService.AdicionarUsuario(usuario);
            MessageBox.Show("Usuário cadastrado!");
            Close();
        }
    }
}
