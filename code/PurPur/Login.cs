using LibBD;
using LibPDV.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPDV
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void LbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LbClose_MouseHover(object sender, EventArgs e)
        {
            LbClose.BackColor = Color.Red;
        }

        private void LbClose_MouseLeave(object sender, EventArgs e)
        {
            LbClose.BackColor = Color.Transparent;
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            pBLogo.Location = new System.Drawing.Point(LogoPanel.Width/3,0);
            LbClose.Location = new System.Drawing.Point(this.Width-25, 10);
            tBEmail.Text = "DevTest@test.com";
            tBPwd.Text = "Dev123";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Users us = new Users();
            if (us.UserLogin(tBEmail.Text, tBPwd.Text))
            {
                Lbtest.Text = "LOGGED IN";   
            }
            else 
            {
                MessageBox.Show($"El usuario: {tBEmail.Text} no existe o de encuentra deshabilitado");
            
            }
            
            

        }
    }
}
