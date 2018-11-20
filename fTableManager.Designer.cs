namespace QuanLyCuaHangCaffee
{
    partial class fTableManager
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
            this.nrCountFood = new System.Windows.Forms.NumericUpDown();
            this.btAddFood = new System.Windows.Forms.Button();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.lsvBill = new System.Windows.Forms.ListView();
            this.nrDiscount = new System.Windows.Forms.NumericUpDown();
            this.btChange = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbChange = new System.Windows.Forms.ComboBox();
            this.btDiscount = new System.Windows.Forms.Button();
            this.btCheckOut = new System.Windows.Forms.Button();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nrCountFood)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nrDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nrCountFood
            // 
            this.nrCountFood.Location = new System.Drawing.Point(232, 11);
            this.nrCountFood.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nrCountFood.Name = "nrCountFood";
            this.nrCountFood.Size = new System.Drawing.Size(57, 20);
            this.nrCountFood.TabIndex = 2;
            this.nrCountFood.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btAddFood
            // 
            this.btAddFood.Location = new System.Drawing.Point(136, 10);
            this.btAddFood.Name = "btAddFood";
            this.btAddFood.Size = new System.Drawing.Size(79, 33);
            this.btAddFood.TabIndex = 1;
            this.btAddFood.Text = "Thêm món";
            this.btAddFood.UseVisualStyleBackColor = true;
            this.btAddFood.Click += new System.EventHandler(this.btAddFood_Click);
            // 
            // cbCatagory
            // 
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(6, 3);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(107, 21);
            this.cbCatagory.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nrCountFood);
            this.panel4.Controls.Add(this.btAddFood);
            this.panel4.Controls.Add(this.cbFood);
            this.panel4.Controls.Add(this.cbCatagory);
            this.panel4.Location = new System.Drawing.Point(364, 47);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 44);
            this.panel4.TabIndex = 10;
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(6, 22);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(107, 21);
            this.cbFood.TabIndex = 0;
            // 
            // lsvBill
            // 
            this.lsvBill.GridLines = true;
            this.lsvBill.Location = new System.Drawing.Point(4, 0);
            this.lsvBill.Name = "lsvBill";
            this.lsvBill.Size = new System.Drawing.Size(281, 242);
            this.lsvBill.TabIndex = 6;
            this.lsvBill.UseCompatibleStateImageBehavior = false;
            // 
            // nrDiscount
            // 
            this.nrDiscount.Location = new System.Drawing.Point(139, 48);
            this.nrDiscount.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nrDiscount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nrDiscount.Name = "nrDiscount";
            this.nrDiscount.Size = new System.Drawing.Size(57, 20);
            this.nrDiscount.TabIndex = 2;
            this.nrDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(7, 3);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(107, 28);
            this.btChange.TabIndex = 0;
            this.btChange.Text = "Chuyển bàn";
            this.btChange.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvBill);
            this.panel2.Location = new System.Drawing.Point(364, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 245);
            this.panel2.TabIndex = 8;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // cbChange
            // 
            this.cbChange.FormattingEnabled = true;
            this.cbChange.Location = new System.Drawing.Point(7, 47);
            this.cbChange.Name = "cbChange";
            this.cbChange.Size = new System.Drawing.Size(107, 21);
            this.cbChange.TabIndex = 0;
            // 
            // btDiscount
            // 
            this.btDiscount.Location = new System.Drawing.Point(130, 3);
            this.btDiscount.Name = "btDiscount";
            this.btDiscount.Size = new System.Drawing.Size(66, 28);
            this.btDiscount.TabIndex = 0;
            this.btDiscount.Text = "Gỉam giá";
            this.btDiscount.UseVisualStyleBackColor = true;
            // 
            // btCheckOut
            // 
            this.btCheckOut.Location = new System.Drawing.Point(202, 3);
            this.btCheckOut.Name = "btCheckOut";
            this.btCheckOut.Size = new System.Drawing.Size(81, 64);
            this.btCheckOut.TabIndex = 0;
            this.btCheckOut.Text = "Thanh toán";
            this.btCheckOut.UseVisualStyleBackColor = true;
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nrDiscount);
            this.panel3.Controls.Add(this.btChange);
            this.panel3.Controls.Add(this.cbChange);
            this.panel3.Controls.Add(this.btDiscount);
            this.panel3.Controls.Add(this.btCheckOut);
            this.panel3.Location = new System.Drawing.Point(366, 345);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(287, 87);
            this.panel3.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flpTable
            // 
            this.flpTable.Location = new System.Drawing.Point(12, 47);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(346, 385);
            this.flpTable.TabIndex = 11;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 444);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Manager";
            this.Load += new System.EventHandler(this.fTableManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nrCountFood)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nrDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nrCountFood;
        private System.Windows.Forms.Button btAddFood;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.ListView lsvBill;
        private System.Windows.Forms.NumericUpDown nrDiscount;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbChange;
        private System.Windows.Forms.Button btDiscount;
        private System.Windows.Forms.Button btCheckOut;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpTable;

    }
}