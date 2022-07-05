using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmInicio : Form
    {
        public bool successLogin = false;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
            frmLogin.FormClosed += ShowInicio;
            frmLogin.FormClosed += ShowMenu;


        }

        private void ShowMenu(object sender, EventArgs e)
        {
            //((frmLogin)sender).successLogin (otra forma menos intuitiva)
            if ((sender as frmLogin).successLogin == true)
            {
                frmMenu frmMenu = new frmMenu();
                frmMenu.Show();
                successLogin = true;
                this.Close();
                
            }
        }

        private void ShowInicio(object sender, EventArgs e)
        {
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister();
            frmRegister.Show();
            this.Hide();

            frmRegister.FormClosed += ShowInicio;
        }
    }
}
