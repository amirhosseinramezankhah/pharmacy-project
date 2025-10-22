namespace pharmacy_project_PL
{
    partial class frmSetting
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.dgvActivityCategory = new System.Windows.Forms.DataGridView();
            this.txtCategoryNane = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnBack = new XanderUI.XUISuperButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnInsert);
            this.groupBox1.Controls.Add(this.dgvActivityCategory);
            this.groupBox1.Controls.Add(this.txtCategoryNane);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(401, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(487, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "مدیریت دسته بندی فعالیت ها";
            // 
            // btnInsert
            // 
            this.btnInsert.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInsert.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_tick_32;
            this.btnInsert.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnInsert.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnInsert.ButtonText = "ثبت اطلاعات";
            this.btnInsert.CornerRadius = 15;
            this.btnInsert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsert.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnInsert.HoverTextColor = System.Drawing.Color.White;
            this.btnInsert.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnInsert.Location = new System.Drawing.Point(18, 26);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsert.Size = new System.Drawing.Size(155, 31);
            this.btnInsert.SuperSelected = false;
            this.btnInsert.TabIndex = 79;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // dgvActivityCategory
            // 
            this.dgvActivityCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvActivityCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvActivityCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvActivityCategory.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvActivityCategory.Location = new System.Drawing.Point(18, 63);
            this.dgvActivityCategory.Name = "dgvActivityCategory";
            this.dgvActivityCategory.Size = new System.Drawing.Size(463, 117);
            this.dgvActivityCategory.TabIndex = 25;
            // 
            // txtCategoryNane
            // 
            this.txtCategoryNane.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCategoryNane.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCategoryNane.BackColor = System.Drawing.Color.Snow;
            // 
            // 
            // 
            this.txtCategoryNane.Border.BackColor = System.Drawing.Color.Snow;
            this.txtCategoryNane.Border.Class = "TextBoxBorder";
            this.txtCategoryNane.Border.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.txtCategoryNane.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryNane.Location = new System.Drawing.Point(179, 26);
            this.txtCategoryNane.Name = "txtCategoryNane";
            this.txtCategoryNane.PreventEnterBeep = true;
            this.txtCategoryNane.Size = new System.Drawing.Size(302, 35);
            this.txtCategoryNane.TabIndex = 22;
            this.txtCategoryNane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCategoryNane.WatermarkText = "دسته بندی فعالیت";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(199)))), ((int)(((byte)(11)))));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.ButtonImage = global::pharmacy_project_PL.Properties.Resources.icons8_return_481;
            this.btnBack.ButtonSmoothing = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.btnBack.ButtonStyle = XanderUI.XUISuperButton.Style.RoundedEdges;
            this.btnBack.ButtonText = "بازگشت";
            this.btnBack.CornerRadius = 15;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(217)))), ((int)(((byte)(174)))));
            this.btnBack.HoverTextColor = System.Drawing.Color.White;
            this.btnBack.ImagePosition = XanderUI.XUISuperButton.imgPosition.Left;
            this.btnBack.Location = new System.Drawing.Point(12, 355);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.SelectedTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(144, 33);
            this.btnBack.SuperSelected = false;
            this.btnBack.TabIndex = 44;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 400);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSetting";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSetting";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivityCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvActivityCategory;
        private DevComponents.DotNetBar.Controls.TextBoxX txtCategoryNane;
        private XanderUI.XUISuperButton btnInsert;
        private XanderUI.XUISuperButton btnBack;
    }
}