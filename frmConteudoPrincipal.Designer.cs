
namespace sistemaEmprestimoBiblioteca
{
    partial class frmConteudoPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConteudoPrincipal));
            this.lbQuemSomos = new System.Windows.Forms.Label();
            this.lbTextoHome = new System.Windows.Forms.Label();
            this.pictureHome = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).BeginInit();
            this.SuspendLayout();
            // 
            // lbQuemSomos
            // 
            this.lbQuemSomos.AutoSize = true;
            this.lbQuemSomos.Font = new System.Drawing.Font("Gadugi", 14F, System.Drawing.FontStyle.Bold);
            this.lbQuemSomos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(85)))), ((int)(((byte)(57)))));
            this.lbQuemSomos.Location = new System.Drawing.Point(55, 45);
            this.lbQuemSomos.Name = "lbQuemSomos";
            this.lbQuemSomos.Size = new System.Drawing.Size(198, 34);
            this.lbQuemSomos.TabIndex = 6;
            this.lbQuemSomos.Text = "Quem somos?";
            // 
            // lbTextoHome
            // 
            this.lbTextoHome.Font = new System.Drawing.Font("Gadugi", 12F);
            this.lbTextoHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(65)))), ((int)(((byte)(43)))));
            this.lbTextoHome.Location = new System.Drawing.Point(406, 127);
            this.lbTextoHome.Name = "lbTextoHome";
            this.lbTextoHome.Size = new System.Drawing.Size(696, 350);
            this.lbTextoHome.TabIndex = 5;
            this.lbTextoHome.Text = resources.GetString("lbTextoHome.Text");
            // 
            // pictureHome
            // 
            this.pictureHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureHome.Image")));
            this.pictureHome.Location = new System.Drawing.Point(59, 127);
            this.pictureHome.Name = "pictureHome";
            this.pictureHome.Size = new System.Drawing.Size(268, 350);
            this.pictureHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureHome.TabIndex = 4;
            this.pictureHome.TabStop = false;
            // 
            // frmConteudoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(224)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1178, 577);
            this.Controls.Add(this.lbQuemSomos);
            this.Controls.Add(this.lbTextoHome);
            this.Controls.Add(this.pictureHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConteudoPrincipal";
            this.Text = "frmConteudoPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbQuemSomos;
        private System.Windows.Forms.Label lbTextoHome;
        private System.Windows.Forms.PictureBox pictureHome;
    }
}