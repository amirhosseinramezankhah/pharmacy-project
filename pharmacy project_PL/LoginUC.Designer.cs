namespace pharmacy_project_PL
{
    partial class LoginUC
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.PRegister = new System.Windows.Forms.Panel();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.txtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtUserName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.PRegister.SuspendLayout();
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
            this.symbolBox1.TabIndex = 64;
            this.symbolBox1.Text = "symbolBox1";
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
            this.lblWelcome.Size = new System.Drawing.Size(348, 27);
            this.lblWelcome.TabIndex = 61;
            this.lblWelcome.Text = "برای ورود به حساب کاربری  اطلاعات خود را وارد نمایید\r\n";
            // 
            // PRegister
            // 
            this.PRegister.Controls.Add(this.btnInsert);
            this.PRegister.Controls.Add(this.txtPassword);
            this.PRegister.Controls.Add(this.txtUserName);
            this.PRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PRegister.Location = new System.Drawing.Point(3, 198);
            this.PRegister.Name = "PRegister";
            this.PRegister.Size = new System.Drawing.Size(445, 157);
            this.PRegister.TabIndex = 63;
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_tick_64;
            this.btnInsert.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsert.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsert.ButtonText = "ورود به حساب کاربری ";
            this.btnInsert.CornerRadius = 15;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnInsert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsert.HoverTextColor = System.Drawing.Color.White;
            this.btnInsert.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsert.Location = new System.Drawing.Point(41, 113);
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
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtPassword.Border.BackColor = System.Drawing.Color.Snow;
            this.txtPassword.Border.Class = "TextBoxBorder";
            this.txtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtPassword.Location = new System.Drawing.Point(41, 73);
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
            this.txtUserName.Location = new System.Drawing.Point(41, 23);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PreventEnterBeep = true;
            this.txtUserName.Size = new System.Drawing.Size(357, 34);
            this.txtUserName.TabIndex = 51;
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUserName.WatermarkText = "نام کاربری";
            // 
            // LoginUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.symbolBox1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.PRegister);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginUC";
            this.Size = new System.Drawing.Size(454, 517);
            this.PRegister.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.SymbolBox symbolBox1;
        private System.Windows.Forms.Label lblWelcome;
        public System.Windows.Forms.Panel PRegister;
        private XanderUI.XUISuperButton btnInsert;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPassword;
        private DevComponents.DotNetBar.Controls.TextBoxX txtUserName;
    }
}
