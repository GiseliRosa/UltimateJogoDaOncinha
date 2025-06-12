namespace JogoDaOncinha.Forms
{
    partial class CadastroUsuarioForm
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
            btnSalvar = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblSaldo = new Label();
            txtSaldo = new TextBox();
            txtEmail = new TextBox();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(142, 143);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(105, 32);
            btnSalvar.TabIndex = 0;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F);
            lblNome.Location = new Point(35, 42);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(56, 21);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F);
            lblEmail.Location = new Point(35, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(51, 21);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Font = new Font("Segoe UI", 12F);
            lblSaldo.Location = new Point(35, 104);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(52, 21);
            lblSaldo.TabIndex = 5;
            lblSaldo.Text = "Saldo:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(97, 102);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(200, 23);
            txtSaldo.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(97, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(97, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(200, 23);
            txtNome.TabIndex = 10;
            // 
            // CadastroUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FlorestaOncinha;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNome);
            Controls.Add(txtEmail);
            Controls.Add(txtSaldo);
            Controls.Add(lblSaldo);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnSalvar);
            Name = "CadastroUsuarioForm";
            Text = "Cadastro de Usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvar;
        private Label lblNome;
        private Label lblEmail;
        private Label lblSaldo;
        private TextBox txtSaldo;
        private TextBox txtEmail;
        private TextBox txtNome;
    }
}