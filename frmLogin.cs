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
    public partial class frmLogin : Form
    {

        private Form frmAtivo;
        private Panel panelForm;

        public frmLogin(Panel panel)
        {
            InitializeComponent();
            panelForm = panel;
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
            if (frmAtivo != null)
            {
                frmAtivo.Close();
            }
        }

        private void lbCadastreAquiLogin_Click(object sender, EventArgs e)
        {
            FormClose();
            ShowForm(new frmCadastro(panelForm));
        }

        private void txtEmailLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
