using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JogoDaOncinha.Forms;

namespace JogoDaOncinha
{
    public partial class TelaPrincipal: Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            new CadastroUsuarioForm().ShowDialog();
        }

        private void btnCadastrarJogo_Click(object sender, EventArgs e)
        {
            new CadastroJogoForm().ShowDialog();
        }

        private void btnFazerAposta_Click(object sender, EventArgs e)
        {
            new ApostarForm().ShowDialog();
        }

        private void btnListarApostas_Click(object sender, EventArgs e)
        {
            new ListaApostasForm().ShowDialog();
        }
    }
}
