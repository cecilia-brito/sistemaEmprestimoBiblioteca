
namespace sistemaEmprestimoBiblioteca
{
    partial class frmPerfilLeitor
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
            this.btnDevolver = new System.Windows.Forms.Button();
            this.lbQtdRenovacaoLivroEmprestado = new System.Windows.Forms.Label();
            this.lbISBNEmprestado = new System.Windows.Forms.Label();
            this.lbTituloLivroEmprestado = new System.Windows.Forms.Label();
            this.pictureCapaLivroEmprestado = new System.Windows.Forms.PictureBox();
            this.lbMeusLivros = new System.Windows.Forms.Label();
            this.btnRenovar = new System.Windows.Forms.Button();
            this.lbMultaLivroEmprestado = new System.Windows.Forms.Label();
            this.lbDataEmprestimo = new System.Windows.Forms.Label();
            this.lbDataDevolucao = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapaLivroEmprestado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolver.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.btnDevolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnDevolver.Location = new System.Drawing.Point(294, 144);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(99, 33);
            this.btnDevolver.TabIndex = 17;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            // 
            // lbQtdRenovacaoLivroEmprestado
            // 
            this.lbQtdRenovacaoLivroEmprestado.AutoSize = true;
            this.lbQtdRenovacaoLivroEmprestado.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbQtdRenovacaoLivroEmprestado.Location = new System.Drawing.Point(130, 137);
            this.lbQtdRenovacaoLivroEmprestado.Name = "lbQtdRenovacaoLivroEmprestado";
            this.lbQtdRenovacaoLivroEmprestado.Size = new System.Drawing.Size(131, 17);
            this.lbQtdRenovacaoLivroEmprestado.TabIndex = 16;
            this.lbQtdRenovacaoLivroEmprestado.Text = "QTD de renovações:";
            // 
            // lbISBNEmprestado
            // 
            this.lbISBNEmprestado.AutoSize = true;
            this.lbISBNEmprestado.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbISBNEmprestado.Location = new System.Drawing.Point(202, 69);
            this.lbISBNEmprestado.Name = "lbISBNEmprestado";
            this.lbISBNEmprestado.Size = new System.Drawing.Size(37, 17);
            this.lbISBNEmprestado.TabIndex = 14;
            this.lbISBNEmprestado.Text = "ISBN";
            // 
            // lbTituloLivroEmprestado
            // 
            this.lbTituloLivroEmprestado.AutoSize = true;
            this.lbTituloLivroEmprestado.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbTituloLivroEmprestado.Location = new System.Drawing.Point(130, 69);
            this.lbTituloLivroEmprestado.Name = "lbTituloLivroEmprestado";
            this.lbTituloLivroEmprestado.Size = new System.Drawing.Size(42, 17);
            this.lbTituloLivroEmprestado.TabIndex = 13;
            this.lbTituloLivroEmprestado.Text = "Título";
            // 
            // pictureCapaLivroEmprestado
            // 
            this.pictureCapaLivroEmprestado.Location = new System.Drawing.Point(30, 69);
            this.pictureCapaLivroEmprestado.Name = "pictureCapaLivroEmprestado";
            this.pictureCapaLivroEmprestado.Size = new System.Drawing.Size(68, 108);
            this.pictureCapaLivroEmprestado.TabIndex = 12;
            this.pictureCapaLivroEmprestado.TabStop = false;
            // 
            // lbMeusLivros
            // 
            this.lbMeusLivros.AutoSize = true;
            this.lbMeusLivros.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lbMeusLivros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.lbMeusLivros.Location = new System.Drawing.Point(26, 20);
            this.lbMeusLivros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMeusLivros.Name = "lbMeusLivros";
            this.lbMeusLivros.Size = new System.Drawing.Size(230, 21);
            this.lbMeusLivros.TabIndex = 11;
            this.lbMeusLivros.Text = "Meus livros emprestados";
            // 
            // btnRenovar
            // 
            this.btnRenovar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnRenovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenovar.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.btnRenovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnRenovar.Location = new System.Drawing.Point(412, 144);
            this.btnRenovar.Name = "btnRenovar";
            this.btnRenovar.Size = new System.Drawing.Size(99, 33);
            this.btnRenovar.TabIndex = 18;
            this.btnRenovar.Text = "Renovar";
            this.btnRenovar.UseVisualStyleBackColor = false;
            // 
            // lbMultaLivroEmprestado
            // 
            this.lbMultaLivroEmprestado.AutoSize = true;
            this.lbMultaLivroEmprestado.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbMultaLivroEmprestado.Location = new System.Drawing.Point(130, 160);
            this.lbMultaLivroEmprestado.Name = "lbMultaLivroEmprestado";
            this.lbMultaLivroEmprestado.Size = new System.Drawing.Size(47, 17);
            this.lbMultaLivroEmprestado.TabIndex = 19;
            this.lbMultaLivroEmprestado.Text = "Multa:";
            // 
            // lbDataEmprestimo
            // 
            this.lbDataEmprestimo.AutoSize = true;
            this.lbDataEmprestimo.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbDataEmprestimo.Location = new System.Drawing.Point(130, 92);
            this.lbDataEmprestimo.Name = "lbDataEmprestimo";
            this.lbDataEmprestimo.Size = new System.Drawing.Size(134, 17);
            this.lbDataEmprestimo.TabIndex = 20;
            this.lbDataEmprestimo.Text = "Data do empréstimo";
            // 
            // lbDataDevolucao
            // 
            this.lbDataDevolucao.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbDataDevolucao.Location = new System.Drawing.Point(130, 114);
            this.lbDataDevolucao.Name = "lbDataDevolucao";
            this.lbDataDevolucao.Size = new System.Drawing.Size(177, 17);
            this.lbDataDevolucao.TabIndex = 21;
            this.lbDataDevolucao.Text = "Data para a devolução";
            // 
            // frmPerfilLeitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(785, 385);
            this.Controls.Add(this.lbDataDevolucao);
            this.Controls.Add(this.lbDataEmprestimo);
            this.Controls.Add(this.lbMultaLivroEmprestado);
            this.Controls.Add(this.btnRenovar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.lbQtdRenovacaoLivroEmprestado);
            this.Controls.Add(this.lbISBNEmprestado);
            this.Controls.Add(this.lbTituloLivroEmprestado);
            this.Controls.Add(this.pictureCapaLivroEmprestado);
            this.Controls.Add(this.lbMeusLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPerfilLeitor";
            this.Text = "frmPerfilLeitor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapaLivroEmprestado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Label lbQtdRenovacaoLivroEmprestado;
        private System.Windows.Forms.Label lbISBNEmprestado;
        private System.Windows.Forms.Label lbTituloLivroEmprestado;
        private System.Windows.Forms.PictureBox pictureCapaLivroEmprestado;
        private System.Windows.Forms.Label lbMeusLivros;
        private System.Windows.Forms.Button btnRenovar;
        private System.Windows.Forms.Label lbMultaLivroEmprestado;
        private System.Windows.Forms.Label lbDataEmprestimo;
        private System.Windows.Forms.Label lbDataDevolucao;
    }
}