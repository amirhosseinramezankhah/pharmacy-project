namespace pharmacy_project_PL
{
    partial class frmlogin
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
            this.progressBarX1 = new DevComponents.DotNetBar.Controls.ProgressBarX();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLoad = new System.Windows.Forms.Label();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.SuspendLayout();
            // 
            // progressBarX1
            // 
            // 
            // 
            // 
            this.progressBarX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.progressBarX1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.progressBarX1.Location = new System.Drawing.Point(3, 544);
            this.progressBarX1.Name = "progressBarX1";
            this.progressBarX1.Size = new System.Drawing.Size(976, 28);
            this.progressBarX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2000;
            this.progressBarX1.TabIndex = 46;
            this.progressBarX1.Text = "progressBarX1";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWelcome.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblWelcome.Location = new System.Drawing.Point(365, 235);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblWelcome.Size = new System.Drawing.Size(300, 22);
            this.lblWelcome.TabIndex = 49;
            this.lblWelcome.Text = "به نرم افزار مدیریت مشتریان داروخانه آنلاین خوش آمدید";
            this.lblWelcome.Visible = false;
            // 
            // lblLoad
            // 
            this.lblLoad.AutoSize = true;
            this.lblLoad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoad.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoad.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLoad.Location = new System.Drawing.Point(403, 516);
            this.lblLoad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoad.Name = "lblLoad";
            this.lblLoad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLoad.Size = new System.Drawing.Size(174, 22);
            this.lblLoad.TabIndex = 48;
            this.lblLoad.Text = "درحال بارگذاری اطلاعات برنامه...";
            this.lblLoad.Visible = false;
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_close_window_24;
            this.btnInsert.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsert.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsert.ButtonText = "انصراف و خروج از برنامه";
            this.btnInsert.CornerRadius = 15;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsert.HoverTextColor = System.Drawing.Color.White;
            this.btnInsert.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsert.Location = new System.Drawing.Point(3, 530);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsert.Size = new System.Drawing.Size(171, 42);
            this.btnInsert.SuperSelected = false;
            this.btnInsert.TabIndex = 50;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.Visible = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(981, 575);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.progressBarX1);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblLoad);
            this.Font = new System.Drawing.Font("IRANSansWeb(FaNum)", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.ProgressBarX progressBarX1;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLoad;
        private XanderUI.XUISuperButton btnInsert;
    }
}