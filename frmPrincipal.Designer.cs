
namespace sistemaEmprestimoBiblioteca
{
    partial class frmHome
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.pictureIconSearch = new System.Windows.Forms.PictureBox();
            this.txtSearchAcervo = new System.Windows.Forms.TextBox();
            this.btnAcervo = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lbTextoHome = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            this.lbQuemSomos = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconSearch)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.panelMenu.Controls.Add(this.pictureIconSearch);
            this.panelMenu.Controls.Add(this.txtSearchAcervo);
            this.panelMenu.Controls.Add(this.btnAcervo);
            this.panelMenu.Controls.Add(this.btnLogin);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1178, 123);
            this.panelMenu.TabIndex = 0;
            // 
            // pictureIconSearch
            // 
            this.pictureIconSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureIconSearch.Image")));
            this.pictureIconSearch.Location = new System.Drawing.Point(699, 55);
            this.pictureIconSearch.Name = "pictureIconSearch";
            this.pictureIconSearch.Size = new System.Drawing.Size(32, 30);
            this.pictureIconSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureIconSearch.TabIndex = 4;
            this.pictureIconSearch.TabStop = false;
            // 
            // txtSearchAcervo
            // 
            this.txtSearchAcervo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.txtSearchAcervo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchAcervo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.txtSearchAcervo.Location = new System.Drawing.Point(747, 55);
            this.txtSearchAcervo.Name = "txtSearchAcervo";
            this.txtSearchAcervo.Size = new System.Drawing.Size(406, 26);
            this.txtSearchAcervo.TabIndex = 3;
            this.txtSearchAcervo.Text = "Digite o nome do livro, autor, isbn...";
            // 
            // btnAcervo
            // 
            this.btnAcervo.FlatAppearance.BorderSize = 0;
            this.btnAcervo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcervo.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcervo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnAcervo.Location = new System.Drawing.Point(465, 0);
            this.btnAcervo.Name = "btnAcervo";
            this.btnAcervo.Size = new System.Drawing.Size(228, 123);
            this.btnAcervo.TabIndex = 2;
            this.btnAcervo.Text = "Acervo";
            this.btnAcervo.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Gadugi", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.btnLogin.Location = new System.Drawing.Point(231, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(228, 123);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(225, 123);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 104);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panelForm
            // 
            this.panelForm.AutoScroll = true;
            this.panelForm.Controls.Add(this.lbQuemSomos);
            this.panelForm.Controls.Add(this.lbTextoHome);
            this.panelForm.Controls.Add(this.pictureHome);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(0, 123);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(1178, 586);
            this.panelForm.TabIndex = 1;
            // 
            // lbTextoHome
            // 
            this.lbTextoHome.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lbTextoHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(43)))));
            this.lbTextoHome.Location = new System.Drawing.Point(405, 128);
            this.lbTextoHome.Name = "lbTextoHome";
            this.lbTextoHome.Size = new System.Drawing.Size(696, 350);
            this.lbTextoHome.TabIndex = 2;
            this.lbTextoHome.Text = resources.GetString("lbTextoHome.Text");
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(59, 128);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(268, 350);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHome.TabIndex = 0;
            this.pictureHome.TabStop = false;
            // 
            // lbQuemSomos
            // 
            this.lbQuemSomos.AutoSize = true;
            this.lbQuemSomos.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lbQuemSomos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.lbQuemSomos.Location = new System.Drawing.Point(54, 46);
            this.lbQuemSomos.Name = "lbQuemSomos";
            this.lbQuemSomos.Size = new System.Drawing.Size(198, 34);
            this.lbQuemSomos.TabIndex = 3;
            this.lbQuemSomos.Text = "Quem somos?";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1178, 709);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelMenu);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Empréstimo Library Coffee";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureIconSearch)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureIconSearch;
        private System.Windows.Forms.TextBox txtSearchAcervo;
        private System.Windows.Forms.Button btnAcervo;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lbTextoHome;       
        private System.Windows.Forms.PictureBox pictureHome;
        private System.Windows.Forms.Label lbQuemSomos;
    }
}

