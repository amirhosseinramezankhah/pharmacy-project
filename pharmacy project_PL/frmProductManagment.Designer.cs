namespace pharmacy_project_PL
{
    partial class frmProductManagment
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
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCountCustomer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DgvProduct = new System.Windows.Forms.DataGridView();
            this.GBSercheCustomer = new System.Windows.Forms.GroupBox();
            this.TxtSerche = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.GBAddProduct = new System.Windows.Forms.GroupBox();
            this.txtStock = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInsert = new XanderUI.XUISuperButton();
            this.TxtPriceProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtNameProduct = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ویرایشToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new XanderUI.XUISuperButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).BeginInit();
            this.GBSercheCustomer.SuspendLayout();
            this.GBAddProduct.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label13.Location = new System.Drawing.Point(350, 512);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 31;
            this.label13.Text = "صفحه";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label12.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label12.Location = new System.Drawing.Point(554, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "صفحه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(429, 512);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "0\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label10.Location = new System.Drawing.Point(507, 512);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 19);
            this.label10.TabIndex = 28;
            this.label10.Text = "0\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(466, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "از";
            // 
            // lblCountCustomer
            // 
            this.lblCountCustomer.AutoSize = true;
            this.lblCountCustomer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblCountCustomer.Location = new System.Drawing.Point(759, 512);
            this.lblCountCustomer.Name = "lblCountCustomer";
            this.lblCountCustomer.Size = new System.Drawing.Size(18, 19);
            this.lblCountCustomer.TabIndex = 26;
            this.lblCountCustomer.Text = "0\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(792, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "تعداد کالاهای ثبت شده:";
            // 
            // DgvProduct
            // 
            this.DgvProduct.AllowUserToAddRows = false;
            this.DgvProduct.AllowUserToDeleteRows = false;
            this.DgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvProduct.BackgroundColor = System.Drawing.Color.Honeydew;
            this.DgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProduct.Location = new System.Drawing.Point(13, 165);
            this.DgvProduct.Name = "DgvProduct";
            this.DgvProduct.ReadOnly = true;
            this.DgvProduct.Size = new System.Drawing.Size(925, 326);
            this.DgvProduct.TabIndex = 23;
            this.DgvProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProduct_CellClick);
            // 
            // GBSercheCustomer
            // 
            this.GBSercheCustomer.Controls.Add(this.TxtSerche);
            this.GBSercheCustomer.Controls.Add(this.label3);
            this.GBSercheCustomer.Location = new System.Drawing.Point(13, 85);
            this.GBSercheCustomer.Name = "GBSercheCustomer";
            this.GBSercheCustomer.Size = new System.Drawing.Size(925, 74);
            this.GBSercheCustomer.TabIndex = 22;
            this.GBSercheCustomer.TabStop = false;
            this.GBSercheCustomer.Text = "جستجو پیشرفته";
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
            // GBAddProduct
            // 
            this.GBAddProduct.Controls.Add(this.txtStock);
            this.GBAddProduct.Controls.Add(this.label6);
            this.GBAddProduct.Controls.Add(this.btnInsert);
            this.GBAddProduct.Controls.Add(this.TxtPriceProduct);
            this.GBAddProduct.Controls.Add(this.label2);
            this.GBAddProduct.Controls.Add(this.TxtNameProduct);
            this.GBAddProduct.Controls.Add(this.label1);
            this.GBAddProduct.Location = new System.Drawing.Point(12, 11);
            this.GBAddProduct.Name = "GBAddProduct";
            this.GBAddProduct.Size = new System.Drawing.Size(926, 68);
            this.GBAddProduct.TabIndex = 21;
            this.GBAddProduct.TabStop = false;
            this.GBAddProduct.Text = "افزودن محصول جدید";
            // 
            // txtStock
            // 
            // 
            // 
            // 
            this.txtStock.Border.Class = "TextBoxBorder";
            this.txtStock.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStock.Location = new System.Drawing.Point(167, 28);
            this.txtStock.Name = "txtStock";
            this.txtStock.PreventEnterBeep = true;
            this.txtStock.Size = new System.Drawing.Size(172, 27);
            this.txtStock.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(345, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "تعداد:";
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
            // TxtPriceProduct
            // 
            // 
            // 
            // 
            this.TxtPriceProduct.Border.Class = "TextBoxBorder";
            this.TxtPriceProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtPriceProduct.Location = new System.Drawing.Point(406, 28);
            this.TxtPriceProduct.Name = "TxtPriceProduct";
            this.TxtPriceProduct.PreventEnterBeep = true;
            this.TxtPriceProduct.Size = new System.Drawing.Size(172, 27);
            this.TxtPriceProduct.TabIndex = 3;
            this.TxtPriceProduct.TextChanged += new System.EventHandler(this.TxtPriceProduct_TextChanged);
            this.TxtPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPriceProduct_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(584, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "قیمت محصول:";
            // 
            // TxtNameProduct
            // 
            // 
            // 
            // 
            this.TxtNameProduct.Border.Class = "TextBoxBorder";
            this.TxtNameProduct.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TxtNameProduct.Location = new System.Drawing.Point(673, 28);
            this.TxtNameProduct.Name = "TxtNameProduct";
            this.TxtNameProduct.PreventEnterBeep = true;
            this.TxtNameProduct.Size = new System.Drawing.Size(169, 27);
            this.TxtNameProduct.TabIndex = 1;
            this.TxtNameProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNameProduct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(848, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام محصول:";
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
            this.btnBack.Location = new System.Drawing.Point(13, 497);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnBack.SelectedBackColor = System.Drawing.Color.LimeGreen;
            this.btnBack.SelectedTextColor = System.Drawing.Color.White;
            this.btnBack.Size = new System.Drawing.Size(125, 42);
            this.btnBack.SuperSelected = false;
            this.btnBack.TabIndex = 24;
            this.btnBack.TextColor = System.Drawing.Color.White;
            this.btnBack.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmProductManagment
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
            this.Controls.Add(this.DgvProduct);
            this.Controls.Add(this.GBSercheCustomer);
            this.Controls.Add(this.GBAddProduct);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmProductManagment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProductManagment";
            this.Load += new System.EventHandler(this.frmProductManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProduct)).EndInit();
            this.GBSercheCustomer.ResumeLayout(false);
            this.GBSercheCustomer.PerformLayout();
            this.GBAddProduct.ResumeLayout(false);
            this.GBAddProduct.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCountCustomer;
        private System.Windows.Forms.Label label5;
        private XanderUI.XUISuperButton btnBack;
        private System.Windows.Forms.DataGridView DgvProduct;
        private System.Windows.Forms.GroupBox GBSercheCustomer;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtSerche;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GBAddProduct;
        private XanderUI.XUISuperButton btnInsert;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtPriceProduct;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX TxtNameProduct;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ویرایشToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفToolStripMenuItem;
    }
}