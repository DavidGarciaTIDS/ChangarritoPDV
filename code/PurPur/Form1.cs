using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurPur
{
    public partial class Form1 : Form
    {
<<<<<<< Updated upstream:code/PurPur/Form1.cs
        public Form1()
=======
        int module = 0;
        public BaseFrm(string user="Anonimo",string shift="Desconocido", string userType="Intruder")
>>>>>>> Stashed changes:code/PurPur/BaseFrm.cs
        {
            InitializeComponent();
            LbNameUser.Text = user;
            LbTurno.Text = shift;
            LbUserType.Text = userType;
            this.Width = 1360;
            this.Height = 768;
            this.BackColor = Color.FromArgb(150,150,187);
        }

<<<<<<< Updated upstream:code/PurPur/Form1.cs
=======
        private void BaseFrm_Load(object sender, EventArgs e)
        {
            
        }

        public void iPbUser_Click(object sender, EventArgs e)
        {
            pDisplay.Controls.Add(pUserMenu);
            pUserMenu.Visible = !pUserMenu.Visible;
            pUserMenu.BringToFront();
        }



        private void LbWarning_TextChanged(object sender, EventArgs e)
        {
            LbWarning.Visible = true;
            bTimer.Interval = 15000;
            bTimer.Start();
        }

        private void bTimer_Tick(object sender, EventArgs e)
        {
            bTimer.Stop();
            LbWarning.Visible = false;
        }


        private void ChangeIButtonColor(int x)
        {
            if (x == this.module)
            {
                LbWarning.Text = "Warning: Ya estas en el modulo seleccionado";
            }
            else
            {
                this.module = x;
                Form bForm;
                this.pDisplay.Controls.Clear();
                //1
                iBtnCashReg.BackColor = Color.FromArgb(125, 125, 142);
                //2
                iBtProducts.BackColor = Color.FromArgb(125, 125, 142);
                //3

                //4

                //5

                //6


                switch (x)
                {
                    case 1:
                        iBtnCashReg.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo Caja";
                        bForm = new CajaFrm();
                        bForm.TopLevel = false;
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;
                    case 2:
                        iBtProducts.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo Productos";
                        bForm = new ProductsFrm();
                        bForm.TopLevel = false;
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;
                    case 3:
                        iBtProducts.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo ...";
                        bForm = new ProductsFrm();
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;
                    case 4:
                        iBtProducts.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo ,,,";
                        bForm = new ProductsFrm();
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;
                    case 5:
                        iBtProducts.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo ---";
                        bForm = new ProductsFrm();
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;
                    case 6:
                        iBtProducts.BackColor = Color.FromArgb(150, 150, 187);
                        LbModulo.Text = "Modulo ´´´";
                        bForm = new ProductsFrm();
                        this.pDisplay.Controls.Add(bForm);
                        bForm.Show();
                        break;

                    default:

                        break;
                }
            }
        }

        #region Public Methods

        public void WarningLable(string msg)
        {
            this.LbWarning.Text = msg;
        }

        #endregion

        private void iBtnCashReg_Click(object sender, EventArgs e)
        {
            ChangeIButtonColor(1);
        }

        private void iBtProducts_Click(object sender, EventArgs e)
        {
            ChangeIButtonColor(2);
        }

        private void iBExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

>>>>>>> Stashed changes:code/PurPur/BaseFrm.cs
    }
}
