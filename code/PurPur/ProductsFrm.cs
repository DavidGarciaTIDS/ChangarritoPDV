using LibPDV.Products;
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
    public partial class ProductsFrm : Form
    {
        Products prod = new Products();
        Brands brand = new Brands();
        public ProductsFrm()
        {
            InitializeComponent();
        }

        private void ProductsFrm_Load(object sender, EventArgs e)
        {
            cbBrand.Items.AddRange(brand.Index("id",true));

            DataTable temp = prod.Index("id", false);
            dGVProducts.Columns.Clear();
            dGVProducts.DataSource = temp;


        }

        private void iPProduct_BackgroundImageChanged(object sender, EventArgs e)
        {
            if (iPProduct.BackgroundImage!=null)
            {
                iPProduct.IconChar = FontAwesome.Sharp.IconChar.None;
            }
            else 
            {
                iPProduct.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            
            }
        }

        private void iBAdd_Click(object sender, EventArgs e)
        {
            
            if (prod.Create(tBNameProd.Text, tbDescProd.Text, Double.Parse(tbPrice.Text), tbBarCode.Text, int.Parse(cbBrand.SelectedItem.ToString()), int.Parse(cbSubcat.SelectedItem.ToString()), cbMetricUnit.SelectedItem.ToString(), ""))
            {
                MessageBox.Show("Se registro");
            }
            else
            {
                MessageBox.Show("No se registro el prod " + prod.ERROR);
            }
        }

        private void iBRemove_Click(object sender, EventArgs e)
        {
           
        }
    }
}
