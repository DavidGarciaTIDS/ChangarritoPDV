
namespace PurPur
{
    partial class TestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbMetricUnit = new System.Windows.Forms.ComboBox();
            this.CbSubCat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbProdId = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbBarCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.CbBrandid = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CbMetricUnit
            // 
            this.CbMetricUnit.BackColor = System.Drawing.Color.White;
            this.CbMetricUnit.FormattingEnabled = true;
            this.CbMetricUnit.Items.AddRange(new object[] {
            "Unit",
            "Kg",
            "Liter"});
            this.CbMetricUnit.Location = new System.Drawing.Point(442, 69);
            this.CbMetricUnit.Name = "CbMetricUnit";
            this.CbMetricUnit.Size = new System.Drawing.Size(121, 23);
            this.CbMetricUnit.TabIndex = 0;
            // 
            // CbSubCat
            // 
            this.CbSubCat.FormattingEnabled = true;
            this.CbSubCat.Items.AddRange(new object[] {
            "bebidas azucaradas",
            "lacteos",
            "bebidas naturales"});
            this.CbSubCat.Location = new System.Drawing.Point(442, 112);
            this.CbSubCat.Name = "CbSubCat";
            this.CbSubCat.Size = new System.Drawing.Size(121, 23);
            this.CbSubCat.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Product Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // txtbProdId
            // 
            this.txtbProdId.Location = new System.Drawing.Point(205, 69);
            this.txtbProdId.Name = "txtbProdId";
            this.txtbProdId.Size = new System.Drawing.Size(100, 23);
            this.txtbProdId.TabIndex = 5;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(205, 112);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 23);
            this.txtbName.TabIndex = 6;
            // 
            // txtbDesc
            // 
            this.txtbDesc.Location = new System.Drawing.Point(205, 305);
            this.txtbDesc.Name = "txtbDesc";
            this.txtbDesc.Size = new System.Drawing.Size(100, 23);
            this.txtbDesc.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Metric Unit";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(205, 158);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(100, 23);
            this.txtbPrice.TabIndex = 9;
            // 
            // txtbBarCode
            // 
            this.txtbBarCode.Location = new System.Drawing.Point(205, 214);
            this.txtbBarCode.Name = "txtbBarCode";
            this.txtbBarCode.Size = new System.Drawing.Size(100, 23);
            this.txtbBarCode.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "BarCode";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(336, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Subcategory";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(487, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CbBrandid
            // 
            this.CbBrandid.FormattingEnabled = true;
            this.CbBrandid.Items.AddRange(new object[] {
            "1",
            "2"});
            this.CbBrandid.Location = new System.Drawing.Point(442, 181);
            this.CbBrandid.Name = "CbBrandid";
            this.CbBrandid.Size = new System.Drawing.Size(121, 23);
            this.CbBrandid.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(336, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Brand";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbBrandid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbBarCode);
            this.Controls.Add(this.txtbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbDesc);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbProdId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CbSubCat);
            this.Controls.Add(this.CbMetricUnit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbMetricUnit;
        private System.Windows.Forms.ComboBox CbSubCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbProdId;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbBarCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox CbBrandid;
        private System.Windows.Forms.Label label8;
    }
}

