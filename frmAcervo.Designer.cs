
namespace sistemaEmprestimoBiblioteca
{
    partial class frmAcervo
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
            this.lbAcervo = new System.Windows.Forms.Label();
            this.pictureCapaAcervo = new System.Windows.Forms.PictureBox();
            this.lbTituloLivroAcervo = new System.Windows.Forms.Label();
            this.lbISBNAcervo = new System.Windows.Forms.Label();
            this.lbSinopse = new System.Windows.Forms.Label();
            this.lbQtdAcervo = new System.Windows.Forms.Label();
            this.btnEmprestar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapaAcervo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAcervo
            // 
            this.lbAcervo.AutoSize = true;
            this.lbAcervo.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lbAcervo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.lbAcervo.Location = new System.Drawing.Point(26, 22);
            this.lbAcervo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAcervo.Name = "lbAcervo";
            this.lbAcervo.Size = new System.Drawing.Size(72, 21);
            this.lbAcervo.TabIndex = 4;
            this.lbAcervo.Text = "Acervo";
            // 
            // pictureCapaAcervo
            // 
            this.pictureCapaAcervo.Location = new System.Drawing.Point(30, 71);
            this.pictureCapaAcervo.Name = "pictureCapaAcervo";
            this.pictureCapaAcervo.Size = new System.Drawing.Size(68, 91);
            this.pictureCapaAcervo.TabIndex = 5;
            this.pictureCapaAcervo.TabStop = false;
            // 
            // lbTituloLivroAcervo
            // 
            this.lbTituloLivroAcervo.AutoSize = true;
            this.lbTituloLivroAcervo.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbTituloLivroAcervo.Location = new System.Drawing.Point(130, 71);
            this.lbTituloLivroAcervo.Name = "lbTituloLivroAcervo";
            this.lbTituloLivroAcervo.Size = new System.Drawing.Size(42, 17);
            this.lbTituloLivroAcervo.TabIndex = 6;
            this.lbTituloLivroAcervo.Text = "Título";
            // 
            // lbISBNAcervo
            // 
            this.lbISBNAcervo.AutoSize = true;
            this.lbISBNAcervo.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbISBNAcervo.Location = new System.Drawing.Point(190, 71);
            this.lbISBNAcervo.Name = "lbISBNAcervo";
            this.lbISBNAcervo.Size = new System.Drawing.Size(37, 17);
            this.lbISBNAcervo.TabIndex = 7;
            this.lbISBNAcervo.Text = "ISBN";
            // 
            // lbSinopse
            // 
            this.lbSinopse.AutoSize = true;
            this.lbSinopse.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbSinopse.Location = new System.Drawing.Point(130, 109);
            this.lbSinopse.Name = "lbSinopse";
            this.lbSinopse.Size = new System.Drawing.Size(58, 17);
            this.lbSinopse.TabIndex = 8;
            this.lbSinopse.Text = "Sinopse:";
            // 
            // lbQtdAcervo
            // 
            this.lbQtdAcervo.AutoSize = true;
            this.lbQtdAcervo.Font = new System.Drawing.Font("Gadugi", 10F);
            this.lbQtdAcervo.Location = new System.Drawing.Point(130, 145);
            this.lbQtdAcervo.Name = "lbQtdAcervo";
            this.lbQtdAcervo.Size = new System.Drawing.Size(39, 17);
            this.lbQtdAcervo.TabIndex = 9;
            this.lbQtdAcervo.Text = "QTD:";
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnEmprestar.Location = new System.Drawing.Point(229, 129);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(99, 33);
            this.btnEmprestar.TabIndex = 10;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            // 
            // frmAcervo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(785, 385);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.lbQtdAcervo);
            this.Controls.Add(this.lbSinopse);
            this.Controls.Add(this.lbISBNAcervo);
            this.Controls.Add(this.lbTituloLivroAcervo);
            this.Controls.Add(this.pictureCapaAcervo);
            this.Controls.Add(this.lbAcervo);
            this.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAcervo";
            this.Text = "frmAcervo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCapaAcervo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAcervo;
        private System.Windows.Forms.PictureBox pictureCapaAcervo;
        private System.Windows.Forms.Label lbTituloLivroAcervo;
        private System.Windows.Forms.Label lbISBNAcervo;
        private System.Windows.Forms.Label lbSinopse;
        private System.Windows.Forms.Label lbQtdAcervo;
        private System.Windows.Forms.Button btnEmprestar;
    }
}