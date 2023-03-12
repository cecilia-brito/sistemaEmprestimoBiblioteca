using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaEmprestimoBiblioteca
{
    public partial class frmHome : Form
    {

        private Form frmAtivo;

        public frmHome()
        {
            InitializeComponent();
        }
        //método para mostrar um formulário ao clicar no botão correspondente
        private void ShowForm(Form frm)
        {
            //método para fechar o formulário atual/ativo
            FormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            panelForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void FormClose()
        {
            if(frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            FormClose();
            ShowForm(new frmConteudoPrincipal());
            btnLogin.BackColor = Color.FromArgb(127, 85, 57);
            btnAcervo.BackColor = Color.FromArgb(127, 85, 57);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowForm(new frmLogin(panelForm));
            btnAcervo.BackColor = Color.FromArgb(127, 85, 57);
            btnLogin.BackColor = Color.FromArgb(68,46,31);
        }

        private void btnAcervo_Click(object sender, EventArgs e)
        {
            ShowForm(new frmAcervo());
            btnLogin.BackColor = Color.FromArgb(127, 85, 57);
            btnAcervo.BackColor = Color.FromArgb(68, 46, 31);
        }
    }
}
