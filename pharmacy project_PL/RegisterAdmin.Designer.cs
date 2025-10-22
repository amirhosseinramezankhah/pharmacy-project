namespace pharmacy_project_PL
{
    partial class RegisterAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.symbolBox1 = new DevComponents.DotNetBar.Controls.SymbolBox();
            this.lblSuccesfully = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.PRegister = new System.Windows.Forms.Panel();
            this.PPic = new System.Windows.Forms.Panel();
            this.PBPic = new System.Windows.Forms.PictureBox();
            this.lblPic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.txtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtChekedPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PLicense = new System.Windows.Forms.Panel();
            this.PBtnLicenceKey = new System.Windows.Forms.Panel();
            this.xuiSuperButton2 = new XanderUI.XUISuperButton();
            this.txtLicenceCopy = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtRegisterId = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.PRegister.SuspendLayout();
            this.PPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPic)).BeginInit();
            this.panel1.SuspendLayout();
            this.PLicense.SuspendLayout();
            this.PBtnLicenceKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // symbolBox1
            // 
            // 
            // 
            // 
            this.symbolBox1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.symbolBox1.Location = new System.Drawing.Point(153, 16);
            this.symbolBox1.Name = "symbolBox1";
            this.symbolBox1.Size = new System.Drawing.Size(140, 143);
            this.symbolBox1.Symbol = "";
            this.symbolBox1.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.symbolBox1.TabIndex = 59;
            this.symbolBox1.Text = "symbolBox1";
            // 
            // lblSuccesfully
            // 
            this.lblSuccesfully.AutoSize = true;
            this.lblSuccesfully.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSuccesfully.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccesfully.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSuccesfully.Location = new System.Drawing.Point(89, 196);
            this.lblSuccesfully.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSuccesfully.Name = "lblSuccesfully";
            this.lblSuccesfully.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSuccesfully.Size = new System.Drawing.Size(266, 32);
            this.lblSuccesfully.TabIndex = 57;
            this.lblSuccesfully.Text = "نرم افزار با موفقیت فعال سازی شد";
            this.lblSuccesfully.Visible = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcome.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWelcome.Location = new System.Drawing.Point(58, 162);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcome.Size = new System.Drawing.Size(337, 27);
            this.lblWelcome.TabIndex = 56;
            this.lblWelcome.Text = "برای اولین ورود به نرم افزار اطلاعات خود را کامل کنید";
            // 
            // PRegister
            // 
            this.PRegister.Controls.Add(this.PPic);
            this.PRegister.Controls.Add(this.panel1);
            this.PRegister.Controls.Add(this.txtName);
            this.PRegister.Controls.Add(this.txtChekedPassword);
            this.PRegister.Controls.Add(this.label2);
            this.PRegister.Controls.Add(this.txtPassword);
            this.PRegister.Controls.Add(this.txtUserName);
            this.PRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PRegister.Location = new System.Drawing.Point(6, 241);
            this.PRegister.Name = "PRegister";
            this.PRegister.Size = new System.Drawing.Size(445, 256);
            this.PRegister.TabIndex = 58;
            this.PRegister.Visible = false;
            // 
            // PPic
            // 
            this.PPic.Controls.Add(this.PBPic);
            this.PPic.Controls.Add(this.lblPic);
            this.PPic.Location = new System.Drawing.Point(210, 194);
            this.PPic.Name = "PPic";
            this.PPic.Size = new System.Drawing.Size(194, 35);
            this.PPic.TabIndex = 54;
            // 
            // PBPic
            // 
            this.PBPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBPic.Image = global::pharmacy_project_PL.Properties.Resources.icons8_plus_641;
            this.PBPic.Location = new System.Drawing.Point(5, 3);
            this.PBPic.Margin = new System.Windows.Forms.Padding(4);
            this.PBPic.Name = "PBPic";
            this.PBPic.Size = new System.Drawing.Size(35, 27);
            this.PBPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBPic.TabIndex = 44;
            this.PBPic.TabStop = false;
            this.PBPic.Click += new System.EventHandler(this.brnPic_Click);
            // 
            // lblPic
            // 
            this.lblPic.AutoSize = true;
            this.lblPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPic.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPic.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblPic.Location = new System.Drawing.Point(48, 7);
            this.lblPic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPic.Name = "lblPic";
            this.lblPic.Size = new System.Drawing.Size(132, 20);
            this.lblPic.TabIndex = 45;
            this.lblPic.Text = "انتخاب تصویر پروفایل کاربر";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(46, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 35);
            this.panel1.TabIndex = 44;
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_tick_64;
            this.btnInsert.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsert.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsert.ButtonText = "ایجاد حساب کاربری";
            this.btnInsert.CornerRadius = 15;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInsert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsert.HoverTextColor = System.Drawing.Color.White;
            this.btnInsert.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsert.Location = new System.Drawing.Point(3, 3);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsert.Size = new System.Drawing.Size(155, 27);
            this.btnInsert.SuperSelected = false;
            this.btnInsert.TabIndex = 5;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtName.Border.BackColor = System.Drawing.Color.Snow;
            this.txtName.Border.Class = "TextBoxBorder";
            this.txtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtName.Location = new System.Drawing.Point(47, 50);
            this.txtName.Name = "txtName";
            this.txtName.PreventEnterBeep = true;
            this.txtName.Size = new System.Drawing.Size(357, 34);
            this.txtName.TabIndex = 50;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.WatermarkText = "نام و نام خانوادگی";
            // 
            // txtChekedPassword
            // 
            this.txtChekedPassword.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtChekedPassword.Border.BackColor = System.Drawing.Color.Snow;
            this.txtChekedPassword.Border.Class = "TextBoxBorder";
            this.txtChekedPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtChekedPassword.Location = new System.Drawing.Point(46, 158);
            this.txtChekedPassword.Name = "txtChekedPassword";
            this.txtChekedPassword.PreventEnterBeep = true;
            this.txtChekedPassword.Size = new System.Drawing.Size(358, 34);
            this.txtChekedPassword.TabIndex = 53;
            this.txtChekedPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChekedPassword.WatermarkText = "تکرار کلمه عبور";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(124, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(170, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "حساب کاربری خود را ایجاد کنید";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtPassword.Border.BackColor = System.Drawing.Color.Snow;
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPassword.Location = new System.Drawing.Point(47, 122);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PreventEnterBeep = true;
            this.txtPassword.Size = new System.Drawing.Size(357, 34);
            this.txtPassword.TabIndex = 52;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.WatermarkText = "کلمه عبور";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtUserName.Border.BackColor = System.Drawing.Color.Snow;
            this.txtUserName.Border.Class = "TextBoxBorder";
            this.txtUserName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtUserName.Location = new System.Drawing.Point(47, 86);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(357, 34);
            this.txtUserName.TabIndex = 51;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.WatermarkText = "نام کاربری";
            // 
            // PLicense
            // 
            this.PLicense.Controls.Add(this.PBtnLicenceKey);
            this.PLicense.Controls.Add(this.txtLicenceCopy);
            this.PLicense.Controls.Add(this.txtRegisterId);
            this.PLicense.Controls.Add(this.label4);
            this.PLicense.Location = new System.Drawing.Point(3, 264);
            this.PLicense.Name = "PLicense";
            this.PLicense.Size = new System.Drawing.Size(446, 150);
            this.PLicense.TabIndex = 60;
            // 
            // PBtnLicenceKey
            // 
            this.PBtnLicenceKey.Controls.Add(this.xuiSuperButton2);
            this.PBtnLicenceKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PBtnLicenceKey.Location = new System.Drawing.Point(49, 108);
            this.PBtnLicenceKey.Name = "PBtnLicenceKey";
            this.PBtnLicenceKey.Size = new System.Drawing.Size(138, 35);
            this.PBtnLicenceKey.TabIndex = 59;
            // 
            // xuiSuperButton2
            // 
            this.xuiSuperButton2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.xuiSuperButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xuiSuperButton2.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_tick_24;
            this.xuiSuperButton2.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.xuiSuperButton2.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.xuiSuperButton2.ButtonText = "بررسی لایسنس";
            this.xuiSuperButton2.CornerRadius = 15;
            this.xuiSuperButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xuiSuperButton2.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.xuiSuperButton2.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.xuiSuperButton2.HoverTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.xuiSuperButton2.Location = new System.Drawing.Point(6, 5);
            this.xuiSuperButton2.Name = "xuiSuperButton2";
            this.xuiSuperButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.xuiSuperButton2.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.xuiSuperButton2.SelectedTextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Size = new System.Drawing.Size(129, 27);
            this.xuiSuperButton2.SuperSelected = false;
            this.xuiSuperButton2.TabIndex = 6;
            this.xuiSuperButton2.TextColor = System.Drawing.Color.White;
            this.xuiSuperButton2.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.xuiSuperButton2.Click += new System.EventHandler(this.xuiSuperButton2_Click);
            // 
            // txtLicenceCopy
            // 
            this.txtLicenceCopy.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtLicenceCopy.Border.BackColor = System.Drawing.Color.Snow;
            this.txtLicenceCopy.Border.Class = "TextBoxBorder";
            this.txtLicenceCopy.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtLicenceCopy.Location = new System.Drawing.Point(46, 74);
            this.txtLicenceCopy.Name = "txtLicenceCopy";
            this.txtLicenceCopy.PreventEnterBeep = true;
            this.txtLicenceCopy.Size = new System.Drawing.Size(358, 34);
            this.txtLicenceCopy.TabIndex = 58;
            this.txtLicenceCopy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLicenceCopy.WatermarkText = "کلید لایسنس دریافتی را اینجا وارد کنید";
            // 
            // txtRegisterId
            // 
            this.txtRegisterId.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtRegisterId.Border.BackColor = System.Drawing.Color.Snow;
            this.txtRegisterId.Border.Class = "TextBoxBorder";
            this.txtRegisterId.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtRegisterId.Location = new System.Drawing.Point(45, 39);
            this.txtRegisterId.Name = "txtRegisterId";
            this.txtRegisterId.PreventEnterBeep = true;
            this.txtRegisterId.Size = new System.Drawing.Size(358, 34);
            this.txtRegisterId.TabIndex = 57;
            this.txtRegisterId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(24, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(369, 22);
            this.label4.TabIndex = 56;
            this.label4.Text = "کد سیستم خود را به شرکت تحویل دهید تا کلید لایسنس را دریافت کنید";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RegisterAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.symbolBox1);
            this.Controls.Add(this.lblSuccesfully);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.PLicense);
            this.Controls.Add(this.PRegister);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegisterAdmin";
            this.Size = new System.Drawing.Size(454, 517);
            this.PRegister.ResumeLayout(false);
            this.PRegister.PerformLayout();
            this.PPic.ResumeLayout(false);
            this.PPic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBPic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.PLicense.ResumeLayout(false);
            this.PLicense.PerformLayout();
            this.PBtnLicenceKey.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.Label lblSuccesfully;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel PPic;
        private System.Windows.Forms.Panel panel1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChekedPassword;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
        private System.Windows.Forms.Panel PBtnLicenceKey;
        private DevComponents.DotNetBar.Controls.TextBoxX txtLicenceCopy;
        private DevComponents.DotNetBar.Controls.TextBoxX txtRegisterId;
        private System.Windows.Forms.Label label4;
        private XanderUI.XUISuperButton btnInsert;
        private XanderUI.XUISuperButton xuiSuperButton2;
        public System.Windows.Forms.Panel PLicense;
        public System.Windows.Forms.Panel PRegister;
        private System.Windows.Forms.Label lblPic;
        private System.Windows.Forms.PictureBox PBPic;
    }
}
