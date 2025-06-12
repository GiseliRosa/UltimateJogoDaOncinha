namespace JogoDaOncinha.Forms
{
    partial class ApostarForm
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
            lblUsuario = new Label();
            lblJogo = new Label();
            lblValor = new Label();
            txtValor = new TextBox();
            cbUsuarios = new ComboBox();
            cbJogos = new ComboBox();
            btnApostar = new Button();
            cbEscolha = new ComboBox();
            lblEscolha = new Label();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(43, 29);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(67, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuário:";
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.Font = new Font("Segoe UI", 12F);
            lblJogo.Location = new Point(43, 60);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(46, 21);
            lblJogo.TabIndex = 2;
            lblJogo.Text = "Jogo:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Font = new Font("Segoe UI", 12F);
            lblValor.Location = new Point(43, 122);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(49, 21);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(116, 120);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(121, 23);
            txtValor.TabIndex = 5;
            // 
            // cbUsuarios
            // 
            cbUsuarios.FormattingEnabled = true;
            cbUsuarios.Location = new Point(116, 29);
            cbUsuarios.Name = "cbUsuarios";
            cbUsuarios.Size = new Size(121, 23);
            cbUsuarios.TabIndex = 6;
            // 
            // cbJogos
            // 
            cbJogos.FormattingEnabled = true;
            cbJogos.Location = new Point(116, 62);
            cbJogos.Name = "cbJogos";
            cbJogos.Size = new Size(121, 23);
            cbJogos.TabIndex = 7;
            // 
            // btnApostar
            // 
            btnApostar.Location = new Point(116, 160);
            btnApostar.Name = "btnApostar";
            btnApostar.Size = new Size(121, 30);
            btnApostar.TabIndex = 8;
            btnApostar.Text = "Apostar";
            btnApostar.UseVisualStyleBackColor = true;
            btnApostar.Click += btnApostar_Click;
            // 
            // cbEscolha
            // 
            cbEscolha.FormattingEnabled = true;
            cbEscolha.Location = new Point(116, 91);
            cbEscolha.Name = "cbEscolha";
            cbEscolha.Size = new Size(121, 23);
            cbEscolha.TabIndex = 9;
            // 
            // lblEscolha
            // 
            lblEscolha.AutoSize = true;
            lblEscolha.Font = new Font("Segoe UI", 12F);
            lblEscolha.Location = new Point(43, 91);
            lblEscolha.Name = "lblEscolha";
            lblEscolha.Size = new Size(61, 21);
            lblEscolha.TabIndex = 10;
            lblEscolha.Text = "Aposta:";
            // 
            // ApostarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FlorestaOncinha;
            ClientSize = new Size(800, 450);
            Controls.Add(lblEscolha);
            Controls.Add(cbEscolha);
            Controls.Add(btnApostar);
            Controls.Add(cbJogos);
            Controls.Add(cbUsuarios);
            Controls.Add(txtValor);
            Controls.Add(lblValor);
            Controls.Add(lblJogo);
            Controls.Add(lblUsuario);
            Name = "ApostarForm";
            Text = "Fazer uma Fézinha";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblJogo;
        private Label lblValor;
        private TextBox txtValor;
        private ComboBox cbUsuarios;
        private ComboBox cbJogos;
        private Button btnApostar;
        private ComboBox cbEscolha;
        private Label lblEscolha;
    }
}