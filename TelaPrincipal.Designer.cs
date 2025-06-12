namespace JogoDaOncinha
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            CadastroUsuario = new Button();
            VerApostas = new Button();
            CadastroJogo = new Button();
            Apostar = new Button();
            logo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // CadastroUsuario
            // 
            CadastroUsuario.FlatStyle = FlatStyle.Popup;
            CadastroUsuario.Location = new Point(347, 264);
            CadastroUsuario.Name = "CadastroUsuario";
            CadastroUsuario.Size = new Size(116, 23);
            CadastroUsuario.TabIndex = 1;
            CadastroUsuario.Text = "Cadastrar Usuario";
            CadastroUsuario.UseVisualStyleBackColor = true;
            CadastroUsuario.Click += btnCadastrarUsuario_Click;
            // 
            // VerApostas
            // 
            VerApostas.FlatStyle = FlatStyle.Popup;
            VerApostas.Location = new Point(347, 351);
            VerApostas.Name = "VerApostas";
            VerApostas.Size = new Size(116, 23);
            VerApostas.TabIndex = 3;
            VerApostas.Text = "Ver Apostas";
            VerApostas.UseVisualStyleBackColor = true;
            VerApostas.Click += btnListarApostas_Click;
            // 
            // CadastroJogo
            // 
            CadastroJogo.FlatStyle = FlatStyle.Popup;
            CadastroJogo.Location = new Point(347, 293);
            CadastroJogo.Name = "CadastroJogo";
            CadastroJogo.Size = new Size(116, 23);
            CadastroJogo.TabIndex = 5;
            CadastroJogo.Text = "Cadastrar Jogos";
            CadastroJogo.UseVisualStyleBackColor = true;
            CadastroJogo.Click += btnCadastrarJogo_Click;
            // 
            // Apostar
            // 
            Apostar.FlatStyle = FlatStyle.Popup;
            Apostar.Location = new Point(347, 322);
            Apostar.Name = "Apostar";
            Apostar.Size = new Size(116, 23);
            Apostar.TabIndex = 7;
            Apostar.Text = "Fazer Aposta";
            Apostar.UseVisualStyleBackColor = true;
            Apostar.Click += btnFazerAposta_Click;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = Properties.Resources.logoEMPREENDA;
            logo.Location = new Point(274, -1);
            logo.Name = "logo";
            logo.Size = new Size(260, 248);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 8;
            logo.TabStop = false;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(logo);
            Controls.Add(Apostar);
            Controls.Add(CadastroJogo);
            Controls.Add(VerApostas);
            Controls.Add(CadastroUsuario);
            Name = "TelaPrincipal";
            Text = "Oncinha Bet";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button CadastroUsuario;
        private Button VerApostas;
        private Button CadastroJogo;
        private Button Apostar;
        private PictureBox logo;
    }
}