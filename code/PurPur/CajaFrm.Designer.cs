
namespace WinFormPDV
{
    partial class CajaFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CbProd = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdUnidad = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ProdPreUn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGSellProd = new System.Windows.Forms.Panel();
            this.pGridTill = new System.Windows.Forms.Panel();
            this.pPayment = new System.Windows.Forms.Panel();
            this.tBPago = new System.Windows.Forms.TextBox();
            this.LbCambioAmount = new System.Windows.Forms.Label();
            this.LbCambio = new System.Windows.Forms.Label();
            this.LbPago = new System.Windows.Forms.Label();
            this.LbTotalAmount = new System.Windows.Forms.Label();
            this.LbTotal = new System.Windows.Forms.Label();
            this.LbSubAmount = new System.Windows.Forms.Label();
            this.LbSubt = new System.Windows.Forms.Label();
            this.iBCash = new FontAwesome.Sharp.IconButton();
            this.iBCCard = new FontAwesome.Sharp.IconButton();
            this.pSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.LbBarCode = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.iBtnSearch = new FontAwesome.Sharp.IconButton();
            this.tBBarCode = new System.Windows.Forms.TextBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pGSellProd.SuspendLayout();
            this.pGridTill.SuspendLayout();
            this.pPayment.SuspendLayout();
            this.pSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(187)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CbProd,
            this.ProdName,
            this.ProdDesc,
            this.ProdUnidad,
            this.ProdPreUn,
            this.ProdPrecio});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1260, 451);
            this.dataGridView1.TabIndex = 2;
            // 
            // CbProd
            // 
            this.CbProd.HeaderText = "-";
            this.CbProd.Name = "CbProd";
            this.CbProd.ReadOnly = true;
            this.CbProd.Width = 40;
            // 
            // ProdName
            // 
            this.ProdName.HeaderText = "Producto";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 275;
            // 
            // ProdDesc
            // 
            this.ProdDesc.HeaderText = "Descripcion";
            this.ProdDesc.Name = "ProdDesc";
            this.ProdDesc.ReadOnly = true;
            this.ProdDesc.Width = 370;
            // 
            // ProdUnidad
            // 
            this.ProdUnidad.HeaderText = "Unidades";
            this.ProdUnidad.Name = "ProdUnidad";
            this.ProdUnidad.Width = 150;
            // 
            // ProdPreUn
            // 
            this.ProdPreUn.HeaderText = "Precio Unitario";
            this.ProdPreUn.Name = "ProdPreUn";
            this.ProdPreUn.ReadOnly = true;
            this.ProdPreUn.Width = 150;
            // 
            // ProdPrecio
            // 
            this.ProdPrecio.HeaderText = "Precio";
            this.ProdPrecio.Name = "ProdPrecio";
            this.ProdPrecio.ReadOnly = true;
            this.ProdPrecio.Width = 140;
            // 
            // pGSellProd
            // 
            this.pGSellProd.Controls.Add(this.pGridTill);
            this.pGSellProd.Controls.Add(this.pPayment);
            this.pGSellProd.Controls.Add(this.pSearch);
            this.pGSellProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGSellProd.Location = new System.Drawing.Point(0, 0);
            this.pGSellProd.Margin = new System.Windows.Forms.Padding(2);
            this.pGSellProd.Name = "pGSellProd";
            this.pGSellProd.Size = new System.Drawing.Size(1260, 668);
            this.pGSellProd.TabIndex = 3;
            // 
            // pGridTill
            // 
            this.pGridTill.Controls.Add(this.dataGridView1);
            this.pGridTill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGridTill.Location = new System.Drawing.Point(0, 54);
            this.pGridTill.Margin = new System.Windows.Forms.Padding(2);
            this.pGridTill.Name = "pGridTill";
            this.pGridTill.Size = new System.Drawing.Size(1260, 451);
            this.pGridTill.TabIndex = 5;
            // 
            // pPayment
            // 
            this.pPayment.BackColor = System.Drawing.Color.Transparent;
            this.pPayment.Controls.Add(this.tBPago);
            this.pPayment.Controls.Add(this.LbCambioAmount);
            this.pPayment.Controls.Add(this.LbCambio);
            this.pPayment.Controls.Add(this.LbPago);
            this.pPayment.Controls.Add(this.LbTotalAmount);
            this.pPayment.Controls.Add(this.LbTotal);
            this.pPayment.Controls.Add(this.LbSubAmount);
            this.pPayment.Controls.Add(this.LbSubt);
            this.pPayment.Controls.Add(this.iBCash);
            this.pPayment.Controls.Add(this.iBCCard);
            this.pPayment.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pPayment.Location = new System.Drawing.Point(0, 505);
            this.pPayment.Margin = new System.Windows.Forms.Padding(2);
            this.pPayment.Name = "pPayment";
            this.pPayment.Size = new System.Drawing.Size(1260, 163);
            this.pPayment.TabIndex = 4;
            // 
            // tBPago
            // 
            this.tBPago.Location = new System.Drawing.Point(976, 27);
            this.tBPago.Margin = new System.Windows.Forms.Padding(2);
            this.tBPago.Name = "tBPago";
            this.tBPago.Size = new System.Drawing.Size(82, 35);
            this.tBPago.TabIndex = 10;
            this.tBPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LbCambioAmount
            // 
            this.LbCambioAmount.AutoSize = true;
            this.LbCambioAmount.BackColor = System.Drawing.Color.Transparent;
            this.LbCambioAmount.Location = new System.Drawing.Point(980, 64);
            this.LbCambioAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbCambioAmount.Name = "LbCambioAmount";
            this.LbCambioAmount.Size = new System.Drawing.Size(78, 27);
            this.LbCambioAmount.TabIndex = 9;
            this.LbCambioAmount.Text = "10000.20";
            // 
            // LbCambio
            // 
            this.LbCambio.AutoSize = true;
            this.LbCambio.BackColor = System.Drawing.Color.Transparent;
            this.LbCambio.Location = new System.Drawing.Point(886, 64);
            this.LbCambio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbCambio.Name = "LbCambio";
            this.LbCambio.Size = new System.Drawing.Size(89, 27);
            this.LbCambio.TabIndex = 8;
            this.LbCambio.Text = "Cambio     $";
            // 
            // LbPago
            // 
            this.LbPago.AutoSize = true;
            this.LbPago.BackColor = System.Drawing.Color.Transparent;
            this.LbPago.Location = new System.Drawing.Point(898, 34);
            this.LbPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbPago.Name = "LbPago";
            this.LbPago.Size = new System.Drawing.Size(77, 27);
            this.LbPago.TabIndex = 6;
            this.LbPago.Text = "Pago      $";
            // 
            // LbTotalAmount
            // 
            this.LbTotalAmount.AutoSize = true;
            this.LbTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.LbTotalAmount.Location = new System.Drawing.Point(1157, 54);
            this.LbTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTotalAmount.Name = "LbTotalAmount";
            this.LbTotalAmount.Size = new System.Drawing.Size(78, 27);
            this.LbTotalAmount.TabIndex = 5;
            this.LbTotalAmount.Text = "10000.20";
            // 
            // LbTotal
            // 
            this.LbTotal.AutoSize = true;
            this.LbTotal.BackColor = System.Drawing.Color.Transparent;
            this.LbTotal.Location = new System.Drawing.Point(1065, 54);
            this.LbTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbTotal.Name = "LbTotal";
            this.LbTotal.Size = new System.Drawing.Size(95, 27);
            this.LbTotal.TabIndex = 4;
            this.LbTotal.Text = "Total          $";
            // 
            // LbSubAmount
            // 
            this.LbSubAmount.AutoSize = true;
            this.LbSubAmount.BackColor = System.Drawing.Color.Transparent;
            this.LbSubAmount.Location = new System.Drawing.Point(1157, 27);
            this.LbSubAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSubAmount.Name = "LbSubAmount";
            this.LbSubAmount.Size = new System.Drawing.Size(78, 27);
            this.LbSubAmount.TabIndex = 3;
            this.LbSubAmount.Text = "10000.20";
            // 
            // LbSubt
            // 
            this.LbSubt.AutoSize = true;
            this.LbSubt.BackColor = System.Drawing.Color.Transparent;
            this.LbSubt.Location = new System.Drawing.Point(1065, 27);
            this.LbSubt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbSubt.Name = "LbSubt";
            this.LbSubt.Size = new System.Drawing.Size(96, 27);
            this.LbSubt.TabIndex = 2;
            this.LbSubt.Text = "SubTotal    $";
            // 
            // iBCash
            // 
            this.iBCash.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.iBCash.IconColor = System.Drawing.Color.Black;
            this.iBCash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBCash.IconSize = 80;
            this.iBCash.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBCash.Location = new System.Drawing.Point(581, 8);
            this.iBCash.Margin = new System.Windows.Forms.Padding(2);
            this.iBCash.Name = "iBCash";
            this.iBCash.Size = new System.Drawing.Size(110, 103);
            this.iBCash.TabIndex = 1;
            this.iBCash.Text = "Efectivo";
            this.iBCash.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBCash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBCash.UseVisualStyleBackColor = true;
            // 
            // iBCCard
            // 
            this.iBCCard.BackColor = System.Drawing.Color.Transparent;
            this.iBCCard.IconChar = FontAwesome.Sharp.IconChar.CreditCard;
            this.iBCCard.IconColor = System.Drawing.Color.Black;
            this.iBCCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBCCard.IconSize = 80;
            this.iBCCard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBCCard.Location = new System.Drawing.Point(723, 8);
            this.iBCCard.Margin = new System.Windows.Forms.Padding(2);
            this.iBCCard.Name = "iBCCard";
            this.iBCCard.Size = new System.Drawing.Size(107, 103);
            this.iBCCard.TabIndex = 0;
            this.iBCCard.Text = "Tarjeta";
            this.iBCCard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBCCard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBCCard.UseVisualStyleBackColor = false;
            // 
            // pSearch
            // 
            this.pSearch.BackColor = System.Drawing.Color.Transparent;
            this.pSearch.Controls.Add(this.label1);
            this.pSearch.Controls.Add(this.LbBarCode);
            this.pSearch.Controls.Add(this.domainUpDown1);
            this.pSearch.Controls.Add(this.iBtnSearch);
            this.pSearch.Controls.Add(this.tBBarCode);
            this.pSearch.Controls.Add(this.btnGO);
            this.pSearch.Controls.Add(this.comboBox1);
            this.pSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSearch.Location = new System.Drawing.Point(0, 0);
            this.pSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pSearch.Name = "pSearch";
            this.pSearch.Size = new System.Drawing.Size(1260, 54);
            this.pSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(694, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad";
            // 
            // LbBarCode
            // 
            this.LbBarCode.AutoSize = true;
            this.LbBarCode.Font = new System.Drawing.Font("Dubai Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LbBarCode.Location = new System.Drawing.Point(314, 11);
            this.LbBarCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LbBarCode.Name = "LbBarCode";
            this.LbBarCode.Size = new System.Drawing.Size(142, 27);
            this.LbBarCode.TabIndex = 5;
            this.LbBarCode.Text = "Codigo de Barras";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Items.Add("1");
            this.domainUpDown1.Items.Add("2");
            this.domainUpDown1.Items.Add("3");
            this.domainUpDown1.Items.Add("4");
            this.domainUpDown1.Items.Add("5");
            this.domainUpDown1.Items.Add("6");
            this.domainUpDown1.Items.Add("7");
            this.domainUpDown1.Items.Add("8");
            this.domainUpDown1.Items.Add("9");
            this.domainUpDown1.Location = new System.Drawing.Point(781, 7);
            this.domainUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(49, 35);
            this.domainUpDown1.TabIndex = 4;
            this.domainUpDown1.Text = "1";
            // 
            // iBtnSearch
            // 
            this.iBtnSearch.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iBtnSearch.IconChar = FontAwesome.Sharp.IconChar.SearchDollar;
            this.iBtnSearch.IconColor = System.Drawing.Color.Black;
            this.iBtnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnSearch.IconSize = 35;
            this.iBtnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.iBtnSearch.Location = new System.Drawing.Point(274, 8);
            this.iBtnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.iBtnSearch.Name = "iBtnSearch";
            this.iBtnSearch.Size = new System.Drawing.Size(36, 35);
            this.iBtnSearch.TabIndex = 3;
            this.iBtnSearch.UseVisualStyleBackColor = true;
            // 
            // tBBarCode
            // 
            this.tBBarCode.Location = new System.Drawing.Point(462, 8);
            this.tBBarCode.Margin = new System.Windows.Forms.Padding(2);
            this.tBBarCode.Name = "tBBarCode";
            this.tBBarCode.Size = new System.Drawing.Size(229, 35);
            this.tBBarCode.TabIndex = 2;
            // 
            // btnGO
            // 
            this.btnGO.Location = new System.Drawing.Point(151, 7);
            this.btnGO.Margin = new System.Windows.Forms.Padding(2);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(49, 34);
            this.btnGO.TabIndex = 1;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 7);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 35);
            this.comboBox1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "SubTotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "$10000.20";
            // 
            // CajaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(145)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1260, 668);
            this.Controls.Add(this.pGSellProd);
            this.Font = new System.Drawing.Font("Dubai", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.MaximumSize = new System.Drawing.Size(1260, 668);
            this.MinimumSize = new System.Drawing.Size(1260, 668);
            this.Name = "CajaFrm";
            this.Load += new System.EventHandler(this.CajaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pGSellProd.ResumeLayout(false);
            this.pGridTill.ResumeLayout(false);
            this.pPayment.ResumeLayout(false);
            this.pPayment.PerformLayout();
            this.pSearch.ResumeLayout(false);
            this.pSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel pGSellProd;
        private System.Windows.Forms.Panel pGridTill;
        private System.Windows.Forms.Panel pPayment;
        private System.Windows.Forms.Label LbCambioAmount;
        private System.Windows.Forms.Label LbCambio;
        private System.Windows.Forms.Label LbPago;
        private System.Windows.Forms.Label LbTotalAmount;
        private System.Windows.Forms.Label LbTotal;
        private System.Windows.Forms.Label LbSubAmount;
        private System.Windows.Forms.Label LbSubt;
        private FontAwesome.Sharp.IconButton iBCash;
        private FontAwesome.Sharp.IconButton iBCCard;
        private System.Windows.Forms.Panel pSearch;
        private FontAwesome.Sharp.IconButton iBtnSearch;
        private System.Windows.Forms.TextBox tBBarCode;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CbProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdDesc;
        private System.Windows.Forms.DataGridViewComboBoxColumn ProdUnidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPreUn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdPrecio;
        private System.Windows.Forms.TextBox tBPago;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbBarCode;
    }
}