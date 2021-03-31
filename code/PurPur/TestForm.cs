using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibPDV.Products;

namespace PurPur
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Products prod= new Products();
            if (prod.Create( txtbName.Text, txtbDesc.Text,Double.Parse( txtbPrice.Text), txtbBarCode.Text, int.Parse(CbBrandid.SelectedItem.ToString()), int.Parse(CbSubCat.SelectedItem.ToString()), CbMetricUnit.SelectedItem.ToString(), ""))
            {
                MessageBox.Show("Se registro");
            }
            else 
            {
                MessageBox.Show("No se registro el prod "+ prod.ERROR);            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
