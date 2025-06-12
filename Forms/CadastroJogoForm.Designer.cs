namespace JogoDaOncinha.Forms
{
    partial class CadastroJogoForm
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
            lblCasa = new Label();
            lblOddCasa = new Label();
            txtTimeCasa = new TextBox();
            btnSalvar = new Button();
            lblVisitante = new Label();
            txtTimeVisitante = new TextBox();
            lblOddVisitante = new Label();
            txtOddVisitante = new TextBox();
            txtOddCasa = new TextBox();
            SuspendLayout();
            // 
            // lblCasa
            // 
            lblCasa.AutoSize = true;
            lblCasa.Font = new Font("Segoe UI", 12F);
            lblCasa.Location = new Point(37, 47);
            lblCasa.Name = "lblCasa";
            lblCasa.Size = new Size(105, 21);
            lblCasa.TabIndex = 0;
            lblCasa.Text = "Time da Casa:";
            // 
            // lblOddCasa
            // 
            lblOddCasa.AutoSize = true;
            lblOddCasa.Font = new Font("Segoe UI", 12F);
            lblOddCasa.Location = new Point(37, 111);
            lblOddCasa.Name = "lblOddCasa";
            lblOddCasa.Size = new Size(115, 21);
            lblOddCasa.TabIndex = 2;
            lblOddCasa.Text = "Odd para Casa:";
            // 
            // txtTimeCasa
            // 
            txtTimeCasa.Location = new Point(148, 47);
            txtTimeCasa.Name = "txtTimeCasa";
            txtTimeCasa.Size = new Size(255, 23);
            txtTimeCasa.TabIndex = 3;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(37, 178);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(80, 33);
            btnSalvar.TabIndex = 4;
            btnSalvar.Text = "Cadastrar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // lblVisitante
            // 
            lblVisitante.AutoSize = true;
            lblVisitante.Font = new Font("Segoe UI", 12F);
            lblVisitante.Location = new Point(37, 76);
            lblVisitante.Name = "lblVisitante";
            lblVisitante.Size = new Size(111, 21);
            lblVisitante.TabIndex = 6;
            lblVisitante.Text = "Time Visitante:";
            // 
            // txtTimeVisitante
            // 
            txtTimeVisitante.Location = new Point(148, 76);
            txtTimeVisitante.Name = "txtTimeVisitante";
            txtTimeVisitante.Size = new Size(255, 23);
            txtTimeVisitante.TabIndex = 7;
            // 
            // lblOddVisitante
            // 
            lblOddVisitante.AutoSize = true;
            lblOddVisitante.Font = new Font("Segoe UI", 12F);
            lblOddVisitante.Location = new Point(37, 140);
            lblOddVisitante.Name = "lblOddVisitante";
            lblOddVisitante.Size = new Size(142, 21);
            lblOddVisitante.TabIndex = 8;
            lblOddVisitante.Text = "Odd para Visitante:";
            // 
            // txtOddVisitante
            // 
            txtOddVisitante.Location = new Point(185, 140);
            txtOddVisitante.Name = "txtOddVisitante";
            txtOddVisitante.Size = new Size(218, 23);
            txtOddVisitante.TabIndex = 10;
            // 
            // txtOddCasa
            // 
            txtOddCasa.Location = new Point(185, 111);
            txtOddCasa.Name = "txtOddCasa";
            txtOddCasa.Size = new Size(218, 23);
            txtOddCasa.TabIndex = 9;
            // 
            // CadastroJogoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FlorestaOncinha;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOddVisitante);
            Controls.Add(txtOddCasa);
            Controls.Add(lblOddVisitante);
            Controls.Add(txtTimeVisitante);
            Controls.Add(lblVisitante);
            Controls.Add(btnSalvar);
            Controls.Add(txtTimeCasa);
            Controls.Add(lblOddCasa);
            Controls.Add(lblCasa);
            Name = "CadastroJogoForm";
            Text = "Cadastrar Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCasa;
        private Label lblOddCasa;
        private TextBox txtTimeCasa;
        private Button btnSalvar;
        private Label lblVisitante;
        private TextBox txtTimeVisitante;
        private Label lblOddVisitante;
        private TextBox txtOddVisitante;
        private TextBox txtOddCasa;
    }
}