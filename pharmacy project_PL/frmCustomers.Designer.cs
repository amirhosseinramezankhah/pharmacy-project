namespace pharmacy_project_PL
{
    partial class frmCustomers
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
            this.GBAddCustomer = new System.Windows.Forms.GroupBox();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.TxtPhon = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.TxtSerche = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvCustomer = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCountCustomer = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new XanderUI.XUISuperButton();
            this.GBAddCustomer.SuspendLayout();
            this.GBSercheCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GBAddCustomer
            // 
            this.GBAddCustomer.Controls.Add(this.btnInsert);
            this.GBAddCustomer.Controls.Add(this.TxtPhon);
            this.GBAddCustomer.Controls.Add(this.label2);
            this.GBAddCustomer.Controls.Add(this.TxtName);
            this.GBAddCustomer.Controls.Add(this.label1);
            this.GBAddCustomer.Location = new System.Drawing.Point(12, 12);
            this.GBAddCustomer.Name = "GBAddCustomer";
            this.GBAddCustomer.Size = new System.Drawing.Size(926, 68);
            this.GBAddCustomer.TabIndex = 0;
            this.GBAddCustomer.TabStop = false;
            this.GBAddCustomer.Text = "افزودن بیمار جدید";
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
            this.btnInsert.Location = new System.Drawing.Point(6, 20);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnInsert.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnInsert.SelectedTextColor = System.Drawing.Color.White;
            this.btnInsert.Size = new System.Drawing.Size(144, 42);
            this.btnInsert.SuperSelected = false;
            this.btnInsert.TabIndex = 4;
            this.btnInsert.TextColor = System.Drawing.Color.White;
            this.btnInsert.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // TxtPhon
            // 
            // 
            // 
            // 
            this.TxtPhon.Border.Class = "TextBoxBorder";
            this.TxtPhon.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtPhon.Location = new System.Drawing.Point(155, 30);
            this.TxtPhon.Name = "TxtPhon";
            this.TxtPhon.PreventEnterBeep = true;
            this.TxtPhon.Size = new System.Drawing.Size(276, 27);
            this.TxtPhon.TabIndex = 3;
            this.TxtPhon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPhon_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(443, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "شماره تماس بیمار:";
            // 
            // TxtName
            // 
            // 
            // 
            // 
            this.TxtName.Border.Class = "TextBoxBorder";
            this.TxtName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtName.Location = new System.Drawing.Point(552, 30);
            this.TxtName.Name = "TxtName";
            this.TxtName.PreventEnterBeep = true;
            this.TxtName.Size = new System.Drawing.Size(288, 27);
            this.TxtName.TabIndex = 1;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(847, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام بیمار:";
            // 
            // GBSercheCustomer
            // 
            this.GBSercheCustomer.Controls.Add(this.TxtSerche);
            this.GBSercheCustomer.Controls.Add(this.label3);
            this.GBSercheCustomer.Location = new System.Drawing.Point(13, 86);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Size = new System.Drawing.Size(925, 74);
            this.GBSercheCustomer.TabIndex = 1;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "جستجو بیمار";
            // 
            // TxtSerche
            // 
            // 
            // 
            // 
            this.TxtSerche.Border.Class = "TextBoxBorder";
            this.TxtSerche.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtSerche.Location = new System.Drawing.Point(5, 33);
            this.TxtSerche.Name = "TxtSerche";
            this.TxtSerche.PreventEnterBeep = true;
            this.TxtSerche.Size = new System.Drawing.Size(830, 27);
            this.TxtSerche.TabIndex = 2;
            this.TxtSerche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSerche.TextChanged += new System.EventHandler(this.TxtSerche_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(841, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "جست و جو:";
            // 
            // DgvCustomer
            // 
            this.DgvCustomer.AllowUserToAddRows = false;
            this.DgvCustomer.AllowUserToDeleteRows = false;
            this.DgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvCustomer.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.DgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomer.Location = new System.Drawing.Point(13, 166);
            this.DgvCustomer.Name = "DgvCustomer";
            this.DgvCustomer.ReadOnly = true;
            this.DgvCustomer.Size = new System.Drawing.Size(925, 326);
            this.DgvCustomer.TabIndex = 2;
            this.DgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomer_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(792, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "تعداد بیماران تا این لحظه:";
            // 
            // lblCountCustomer
            // 
            this.lblCountCustomer.AutoSize = true;
            this.lblCountCustomer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCountCustomer.Location = new System.Drawing.Point(759, 513);
            this.lblCountCustomer.Name = "lblCountCustomer";
            this.lblCountCustomer.Size = new System.Drawing.Size(18, 19);
            this.lblCountCustomer.TabIndex = 10;
            this.lblCountCustomer.Text = "0\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(350, 513);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 20;
            this.label13.Text = "صفحه";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(554, 513);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 19;
            this.label12.Text = "صفحه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(429, 513);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 18;
            this.label11.Text = "0\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(507, 513);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "0\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(466, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "از";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ویرایشToolStripMenuItem,
            this.حذفToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contextMenuStrip1.Size = new System.Drawing.Size(111, 48);
            // 
            // ویرایشToolStripMenuItem
            // 
            this.ویرایشToolStripMenuItem.Image = global::pharmacy_project_PL.Properties.Resources.icons8_edit_24;
            this.ویرایشToolStripMenuItem.Name = "ویرایشToolStripMenuItem";
            this.ویرایشToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.ویرایشToolStripMenuItem.Text = "ویرایش";
            this.ویرایشToolStripMenuItem.Click += new System.EventHandler(this.ویرایشToolStripMenuItem_Click);
            // 
            // حذفToolStripMenuItem
            // 
            this.حذفToolStripMenuItem.Image = global::pharmacy_project_PL.Properties.Resources.icons8_delete_24;
            this.حذفToolStripMenuItem.Name = "حذفToolStripMenuItem";
            this.حذفToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.حذفToolStripMenuItem.Text = "حذف";
            this.حذفToolStripMenuItem.Click += new System.EventHandler(this.حذفToolStripMenuItem_Click);
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
            this.btnBack.Location = new System.Drawing.Point(13, 498);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.SelectedTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(125, 42);
            this.btnBack.SuperSelected = false;
            this.btnBack.TabIndex = 3;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCountCustomer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.DgvCustomer);
            this.Controls.Add(this.GBSercheCustomer);
            this.Controls.Add(this.GBAddCustomer);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCustomers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.GBAddCustomer.ResumeLayout(false);
            this.GBAddCustomer.PerformLayout();
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GBAddCustomer;
        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private System.Windows.Forms.DataGridView DgvCustomer;
        private XanderUI.XUISuperButton btnBack;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtName;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPhon;
        private XanderUI.XUISuperButton btnInsert;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCountCustomer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}