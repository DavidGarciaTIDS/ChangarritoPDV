
namespace WinFormPDV
{
    partial class BaseFrm
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
            this.components = new System.ComponentModel.Container();
            this.pHeader = new System.Windows.Forms.Panel();
            this.LbWarning = new System.Windows.Forms.Label();
            this.LbModulo = new System.Windows.Forms.Label();
            this.iPbLogo = new FontAwesome.Sharp.IconPictureBox();
            this.pHUser = new System.Windows.Forms.Panel();
            this.pUserMenu = new System.Windows.Forms.Panel();
            this.iBExit = new FontAwesome.Sharp.IconButton();
            this.iPbUser = new FontAwesome.Sharp.IconPictureBox();
            this.LbTurno = new System.Windows.Forms.Label();
            this.LbNameUser = new System.Windows.Forms.Label();
            this.LbUserType = new System.Windows.Forms.Label();
            this.pLeftMenu = new System.Windows.Forms.Panel();
            this.iBtProducts = new FontAwesome.Sharp.IconButton();
            this.iBtnCashReg = new FontAwesome.Sharp.IconButton();
            this.bTimer = new System.Windows.Forms.Timer(this.components);
            this.pDisplay = new System.Windows.Forms.Panel();
            this.pHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPbLogo)).BeginInit();
            this.pHUser.SuspendLayout();
            this.pUserMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPbUser)).BeginInit();
            this.pLeftMenu.SuspendLayout();
            this.pDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // pHeader
            // 
            this.pHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.pHeader.Controls.Add(this.LbWarning);
            this.pHeader.Controls.Add(this.LbModulo);
            this.pHeader.Controls.Add(this.iPbLogo);
            this.pHeader.Controls.Add(this.pHUser);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pHeader.Location = new System.Drawing.Point(0, 0);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1360, 100);
            this.pHeader.TabIndex = 0;
            // 
            // LbWarning
            // 
            this.LbWarning.AutoSize = true;
            this.LbWarning.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LbWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LbWarning.Location = new System.Drawing.Point(102, 0);
            this.LbWarning.Name = "LbWarning";
            this.LbWarning.Size = new System.Drawing.Size(99, 32);
            this.LbWarning.TabIndex = 3;
            this.LbWarning.Text = "Warning: ";
            this.LbWarning.Visible = false;
            this.LbWarning.TextChanged += new System.EventHandler(this.LbWarning_TextChanged);
            // 
            // LbModulo
            // 
            this.LbModulo.AutoSize = true;
            this.LbModulo.Location = new System.Drawing.Point(102, 51);
            this.LbModulo.Name = "LbModulo";
            this.LbModulo.Size = new System.Drawing.Size(127, 32);
            this.LbModulo.TabIndex = 2;
            this.LbModulo.Text = "Modulo Base";
            // 
            // iPbLogo
            // 
            this.iPbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.iPbLogo.BackgroundImage = global::WinFormPDV.Properties.Resources._96_logo;
            this.iPbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iPbLogo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPbLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iPbLogo.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPbLogo.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.iPbLogo.IconSize = 83;
            this.iPbLogo.ImageLocation = "";
            this.iPbLogo.Location = new System.Drawing.Point(2, 11);
            this.iPbLogo.Name = "iPbLogo";
            this.iPbLogo.Size = new System.Drawing.Size(94, 83);
            this.iPbLogo.TabIndex = 1;
            this.iPbLogo.TabStop = false;
            // 
            // pHUser
            // 
            this.pHUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.pHUser.Controls.Add(this.iPbUser);
            this.pHUser.Controls.Add(this.LbTurno);
            this.pHUser.Controls.Add(this.LbNameUser);
            this.pHUser.Controls.Add(this.LbUserType);
            this.pHUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.pHUser.Location = new System.Drawing.Point(1023, 0);
            this.pHUser.Name = "pHUser";
            this.pHUser.Size = new System.Drawing.Size(337, 100);
            this.pHUser.TabIndex = 0;
            // 
            // pUserMenu
            // 
            this.pUserMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.pUserMenu.Controls.Add(this.iBExit);
            this.pUserMenu.Location = new System.Drawing.Point(1097, 0);
            this.pUserMenu.Name = "pUserMenu";
            this.pUserMenu.Size = new System.Drawing.Size(163, 55);
            this.pUserMenu.TabIndex = 0;
            this.pUserMenu.Visible = false;
            // 
            // iBExit
            // 
            this.iBExit.BackColor = System.Drawing.Color.Transparent;
            this.iBExit.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iBExit.IconColor = System.Drawing.Color.Black;
            this.iBExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBExit.IconSize = 32;
            this.iBExit.Location = new System.Drawing.Point(0, 16);
            this.iBExit.Name = "iBExit";
            this.iBExit.Size = new System.Drawing.Size(163, 35);
            this.iBExit.TabIndex = 0;
            this.iBExit.Text = "Salir";
            this.iBExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBExit.UseVisualStyleBackColor = false;
            this.iBExit.Click += new System.EventHandler(this.iBExit_Click);
            // 
            // iPbUser
            // 
            this.iPbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.iPbUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iPbUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.iPbUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iPbUser.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iPbUser.IconColor = System.Drawing.SystemColors.ControlText;
            this.iPbUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iPbUser.IconSize = 94;
            this.iPbUser.ImageLocation = "";
            this.iPbUser.Location = new System.Drawing.Point(243, 0);
            this.iPbUser.Margin = new System.Windows.Forms.Padding(2);
            this.iPbUser.Name = "iPbUser";
            this.iPbUser.Size = new System.Drawing.Size(94, 100);
            this.iPbUser.TabIndex = 2;
            this.iPbUser.TabStop = false;
            this.iPbUser.Click += new System.EventHandler(this.iPbUser_Click);
            // 
            // LbTurno
            // 
            this.LbTurno.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LbTurno.Location = new System.Drawing.Point(0, 64);
            this.LbTurno.Name = "LbTurno";
            this.LbTurno.Size = new System.Drawing.Size(249, 32);
            this.LbTurno.TabIndex = 0;
            this.LbTurno.Text = "Vespertino";
            this.LbTurno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbNameUser
            // 
            this.LbNameUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbNameUser.Location = new System.Drawing.Point(0, 32);
            this.LbNameUser.Name = "LbNameUser";
            this.LbNameUser.Size = new System.Drawing.Size(249, 32);
            this.LbNameUser.TabIndex = 0;
            this.LbNameUser.Text = "Nombre Apellido";
            this.LbNameUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LbUserType
            // 
            this.LbUserType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbUserType.Location = new System.Drawing.Point(0, 0);
            this.LbUserType.Name = "LbUserType";
            this.LbUserType.Size = new System.Drawing.Size(249, 32);
            this.LbUserType.TabIndex = 0;
            this.LbUserType.Text = "TIPO USUARIO";
            this.LbUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pLeftMenu
            // 
            this.pLeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(142)))));
            this.pLeftMenu.Controls.Add(this.iBtProducts);
            this.pLeftMenu.Controls.Add(this.iBtnCashReg);
            this.pLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pLeftMenu.Location = new System.Drawing.Point(0, 100);
            this.pLeftMenu.Name = "pLeftMenu";
            this.pLeftMenu.Size = new System.Drawing.Size(100, 668);
            this.pLeftMenu.TabIndex = 1;
            // 
            // iBtProducts
            // 
            this.iBtProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtProducts.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBtProducts.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.iBtProducts.IconColor = System.Drawing.Color.Black;
            this.iBtProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtProducts.Location = new System.Drawing.Point(2, 88);
            this.iBtProducts.Margin = new System.Windows.Forms.Padding(2);
            this.iBtProducts.Name = "iBtProducts";
            this.iBtProducts.Size = new System.Drawing.Size(96, 82);
            this.iBtProducts.TabIndex = 1;
            this.iBtProducts.Text = "Productos";
            this.iBtProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtProducts.UseVisualStyleBackColor = true;
            this.iBtProducts.Click += new System.EventHandler(this.iBtProducts_Click);
            // 
            // iBtnCashReg
            // 
            this.iBtnCashReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(142)))));
            this.iBtnCashReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnCashReg.Font = new System.Drawing.Font("Dubai Medium", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.iBtnCashReg.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.iBtnCashReg.IconColor = System.Drawing.Color.Black;
            this.iBtnCashReg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnCashReg.Location = new System.Drawing.Point(2, 2);
            this.iBtnCashReg.Margin = new System.Windows.Forms.Padding(2);
            this.iBtnCashReg.Name = "iBtnCashReg";
            this.iBtnCashReg.Size = new System.Drawing.Size(96, 82);
            this.iBtnCashReg.TabIndex = 0;
            this.iBtnCashReg.Text = "Caja Registradora";
            this.iBtnCashReg.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.iBtnCashReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iBtnCashReg.UseVisualStyleBackColor = false;
            this.iBtnCashReg.Click += new System.EventHandler(this.iBtnCashReg_Click);
            // 
            // bTimer
            // 
            this.bTimer.Tick += new System.EventHandler(this.bTimer_Tick);
            // 
            // pDisplay
            // 
            this.pDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.pDisplay.Controls.Add(this.pUserMenu);
            this.pDisplay.Location = new System.Drawing.Point(100, 100);
            this.pDisplay.Name = "pDisplay";
            this.pDisplay.Size = new System.Drawing.Size(1260, 668);
            this.pDisplay.TabIndex = 2;
            // 
            // BaseFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1360, 768);
            this.Controls.Add(this.pLeftMenu);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pDisplay);
            this.Font = new System.Drawing.Font("Dubai Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaseFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseFrm";
            this.Load += new System.EventHandler(this.BaseFrm_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPbLogo)).EndInit();
            this.pHUser.ResumeLayout(false);
            this.pUserMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iPbUser)).EndInit();
            this.pLeftMenu.ResumeLayout(false);
            this.pDisplay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Panel pHUser;
        private System.Windows.Forms.Panel pLeftMenu;
        private System.Windows.Forms.Label LbTurno;
        private System.Windows.Forms.Label LbNameUser;
        private System.Windows.Forms.Label LbUserType;
        private FontAwesome.Sharp.IconPictureBox iPbLogo;
        protected FontAwesome.Sharp.IconButton iBtnCashReg;
        protected FontAwesome.Sharp.IconButton iBtProducts;
        protected System.Windows.Forms.Label LbModulo;
        private System.Windows.Forms.Timer bTimer;
        public System.Windows.Forms.Label LbWarning;
        private System.Windows.Forms.Panel pDisplay;
        private FontAwesome.Sharp.IconButton iBExit;
        public FontAwesome.Sharp.IconPictureBox iPbUser;
        public System.Windows.Forms.Panel pUserMenu;
    }
}