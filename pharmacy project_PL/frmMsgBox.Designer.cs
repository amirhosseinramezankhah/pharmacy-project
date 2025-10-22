namespace pharmacy_project_PL
{
    partial class frmMsgBox
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
            this.btnYes = new DevComponents.DotNetBar.ButtonX();
            this.btnClose = new DevComponents.DotNetBar.ButtonX();
            this.lblErrorEnglish = new System.Windows.Forms.Label();
            this.lblErrorPerstion = new System.Windows.Forms.Label();
            this.lblTitleMassageSample = new System.Windows.Forms.Label();
            this.PBMsg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBMsg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnYes.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.Font = new System.Drawing.Font("IRANSansWeb", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.Location = new System.Drawing.Point(88, 190);
            this.btnYes.Name = "btnYes";
            this.btnYes.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnYes.Size = new System.Drawing.Size(75, 23);
            this.btnYes.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnYes.TabIndex = 11;
            this.btnYes.Text = "بله";
            this.btnYes.TextColor = System.Drawing.Color.Black;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnClose
            // 
            this.btnClose.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClose.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("IRANSansWeb", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(7, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "خروج / تایید";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblErrorEnglish
            // 
            this.lblErrorEnglish.Font = new System.Drawing.Font("IRANSansWeb", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEnglish.ForeColor = System.Drawing.Color.Black;
            this.lblErrorEnglish.Location = new System.Drawing.Point(16, 121);
            this.lblErrorEnglish.Name = "lblErrorEnglish";
            this.lblErrorEnglish.Size = new System.Drawing.Size(351, 44);
            this.lblErrorEnglish.TabIndex = 9;
            this.lblErrorEnglish.Text = "Error Or Message Detalis...";
            // 
            // lblErrorPerstion
            // 
            this.lblErrorPerstion.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorPerstion.ForeColor = System.Drawing.Color.Black;
            this.lblErrorPerstion.Location = new System.Drawing.Point(17, 51);
            this.lblErrorPerstion.Name = "lblErrorPerstion";
            this.lblErrorPerstion.Size = new System.Drawing.Size(351, 58);
            this.lblErrorPerstion.TabIndex = 8;
            this.lblErrorPerstion.Text = "موضوع پیغام نمونه";
            this.lblErrorPerstion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTitleMassageSample
            // 
            this.lblTitleMassageSample.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleMassageSample.ForeColor = System.Drawing.Color.Black;
            this.lblTitleMassageSample.Location = new System.Drawing.Point(16, 9);
            this.lblTitleMassageSample.Name = "lblTitleMassageSample";
            this.lblTitleMassageSample.Size = new System.Drawing.Size(303, 24);
            this.lblTitleMassageSample.TabIndex = 6;
            this.lblTitleMassageSample.Text = "موضوع پیغام نمونه";
            this.lblTitleMassageSample.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // PBMsg
            // 
            this.PBMsg.Image = global::pharmacy_project_PL.Properties.Resources.icons8_info_50;
            this.PBMsg.Location = new System.Drawing.Point(325, 9);
            this.PBMsg.Name = "PBMsg";
            this.PBMsg.Size = new System.Drawing.Size(42, 35);
            this.PBMsg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBMsg.TabIndex = 12;
            this.PBMsg.TabStop = false;
            // 
            // frmMsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(183)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(375, 225);
            this.Controls.Add(this.PBMsg);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblErrorEnglish);
            this.Controls.Add(this.lblErrorPerstion);
            this.Controls.Add(this.lblTitleMassageSample);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMsgBox";
            this.Load += new System.EventHandler(this.frmMsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBMsg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public DevComponents.DotNetBar.ButtonX btnYes;
        public DevComponents.DotNetBar.ButtonX btnClose;
        public System.Windows.Forms.Label lblErrorEnglish;
        public System.Windows.Forms.Label lblErrorPerstion;
        public System.Windows.Forms.Label lblTitleMassageSample;
        public System.Windows.Forms.PictureBox PBMsg;
    }
}