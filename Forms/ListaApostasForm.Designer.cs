namespace JogoDaOncinha.Forms
{
    partial class ListaApostasForm
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
            dgvApostas = new DataGridView();
            sqliteCommand1 = new Microsoft.Data.Sqlite.SqliteCommand();
            btnRolarJogo = new Button();
            btnDeletarFinalizadas = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvApostas).BeginInit();
            SuspendLayout();
            // 
            // dgvApostas
            // 
            dgvApostas.BackgroundColor = Color.FromArgb(0, 64, 0);
            dgvApostas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvApostas.GridColor = Color.FromArgb(192, 255, 192);
            dgvApostas.Location = new Point(12, 29);
            dgvApostas.Name = "dgvApostas";
            dgvApostas.Size = new Size(776, 254);
            dgvApostas.TabIndex = 0;
            // 
            // sqliteCommand1
            // 
            sqliteCommand1.CommandTimeout = 30;
            sqliteCommand1.Connection = null;
            sqliteCommand1.Transaction = null;
            sqliteCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // btnRolarJogo
            // 
            btnRolarJogo.Location = new Point(325, 318);
            btnRolarJogo.Name = "btnRolarJogo";
            btnRolarJogo.Size = new Size(75, 56);
            btnRolarJogo.TabIndex = 1;
            btnRolarJogo.Text = "Rolar Jogo";
            btnRolarJogo.UseVisualStyleBackColor = true;
            btnRolarJogo.Click += btnRolarJogo_Click;
            // 
            // btnDeletarFinalizadas
            // 
            btnDeletarFinalizadas.Location = new Point(406, 318);
            btnDeletarFinalizadas.Name = "btnDeletarFinalizadas";
            btnDeletarFinalizadas.Size = new Size(75, 56);
            btnDeletarFinalizadas.TabIndex = 3;
            btnDeletarFinalizadas.Text = "Deletar Finalizadas";
            btnDeletarFinalizadas.UseVisualStyleBackColor = true;
            btnDeletarFinalizadas.Click += btnDeletarFinalizadas_Click;
            // 
            // ListaApostasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.FlorestaOncinha;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeletarFinalizadas);
            Controls.Add(btnRolarJogo);
            Controls.Add(dgvApostas);
            Name = "ListaApostasForm";
            Text = "Lista de Apostas";
            Load += ListaApostasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvApostas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvApostas;
        private Microsoft.Data.Sqlite.SqliteCommand sqliteCommand1;
        private Button btnRolarJogo;
        private Button btnDeletarFinalizadas;
    }
}