namespace CafeMGmtSys
{
    partial class GuestOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.LabelAmount = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SellerName = new System.Windows.Forms.TextBox();
            this.OrderNumTb = new System.Windows.Forms.TextBox();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.categorycb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DateLbl);
            this.panel1.Controls.Add(this.LabelAmount);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.QtyTb);
            this.panel1.Controls.Add(this.OrdersGV);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SellerName);
            this.panel1.Controls.Add(this.OrderNumTb);
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.categorycb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(205, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 725);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(870, 665);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 37);
            this.label2.TabIndex = 40;
            this.label2.Text = "$";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.BackColor = System.Drawing.Color.White;
            this.DateLbl.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DateLbl.ForeColor = System.Drawing.Color.Turquoise;
            this.DateLbl.Location = new System.Drawing.Point(867, 7);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(78, 37);
            this.DateLbl.TabIndex = 39;
            this.DateLbl.Text = "Date";
            // 
            // LabelAmount
            // 
            this.LabelAmount.AutoSize = true;
            this.LabelAmount.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelAmount.ForeColor = System.Drawing.Color.Turquoise;
            this.LabelAmount.Location = new System.Drawing.Point(916, 665);
            this.LabelAmount.Name = "LabelAmount";
            this.LabelAmount.Size = new System.Drawing.Size(82, 37);
            this.LabelAmount.TabIndex = 38;
            this.LabelAmount.Text = "Total";
            this.LabelAmount.Click += new System.EventHandler(this.LabelAmount_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button7.BackColor = System.Drawing.SystemColors.Highlight;
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.Turquoise;
            this.button7.Location = new System.Drawing.Point(185, 91);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button7.Size = new System.Drawing.Size(102, 32);
            this.button7.TabIndex = 37;
            this.button7.Text = "Refresh";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Refresh);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(621, 668);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button2.Size = new System.Drawing.Size(187, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Place The Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QtyTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QtyTb.Location = new System.Drawing.Point(37, 232);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.PlaceholderText = "Quantity";
            this.QtyTb.Size = new System.Drawing.Size(142, 22);
            this.QtyTb.TabIndex = 36;
            // 
            // OrdersGV
            // 
            this.OrdersGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.GridColor = System.Drawing.Color.White;
            this.OrdersGV.Location = new System.Drawing.Point(374, 385);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersWidth = 72;
            this.OrdersGV.RowTemplate.Height = 25;
            this.OrdersGV.Size = new System.Drawing.Size(680, 255);
            this.OrdersGV.TabIndex = 20;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Turquoise;
            this.button4.Location = new System.Drawing.Point(34, 260);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button4.Size = new System.Drawing.Size(142, 32);
            this.button4.TabIndex = 35;
            this.button4.Text = "Add To Cart";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(633, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 37);
            this.label3.TabIndex = 19;
            this.label3.Text = "Your Order";
            // 
            // SellerName
            // 
            this.SellerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SellerName.Enabled = false;
            this.SellerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SellerName.Location = new System.Drawing.Point(37, 175);
            this.SellerName.Name = "SellerName";
            this.SellerName.PlaceholderText = "GUEST";
            this.SellerName.Size = new System.Drawing.Size(142, 22);
            this.SellerName.TabIndex = 34;
            // 
            // OrderNumTb
            // 
            this.OrderNumTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderNumTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OrderNumTb.Location = new System.Drawing.Point(37, 137);
            this.OrderNumTb.Name = "OrderNumTb";
            this.OrderNumTb.PlaceholderText = "OrderNum";
            this.OrderNumTb.Size = new System.Drawing.Size(142, 22);
            this.OrderNumTb.TabIndex = 33;
            // 
            // ItemsGV
            // 
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGV.GridColor = System.Drawing.Color.White;
            this.ItemsGV.Location = new System.Drawing.Point(358, 73);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersWidth = 72;
            this.ItemsGV.RowTemplate.Height = 25;
            this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGV.Size = new System.Drawing.Size(680, 208);
            this.ItemsGV.TabIndex = 14;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // categorycb
            // 
            this.categorycb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.categorycb.FormattingEnabled = true;
            this.categorycb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.categorycb.Location = new System.Drawing.Point(37, 93);
            this.categorycb.Name = "categorycb";
            this.categorycb.Size = new System.Drawing.Size(142, 26);
            this.categorycb.TabIndex = 32;
            this.categorycb.Text = "Category";
            this.categorycb.SelectedIndexChanged += new System.EventHandler(this.categorycb_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(444, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Place Order";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Guest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Guest.Location = new System.Drawing.Point(67, 728);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(71, 25);
            this.Guest.TabIndex = 10;
            this.Guest.Text = "Logout";
            this.Guest.Click += new System.EventHandler(this.Guest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1287, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // GuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1312, 772);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Guest);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemForm";
            this.Load += new System.EventHandler(this.GuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label Guest;
        private Label label1;
        private Label label5;
        private DataGridView ItemsGV;
        private Button button2;
        private DataGridView OrdersGV;
        private Label label3;
        private Button button7;
        private TextBox QtyTb;
        private Button button4;
        private TextBox SellerName;
        private TextBox OrderNumTb;
        private ComboBox categorycb;
        private Label LabelAmount;
        private Label DateLbl;
        private Label label2;
    }
}