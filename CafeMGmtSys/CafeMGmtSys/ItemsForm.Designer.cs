namespace CafeMGmtSys
{
    partial class ItemsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemsGV = new System.Windows.Forms.DataGridView();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ItemPriceTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ItemNameTb = new System.Windows.Forms.TextBox();
            this.ItemNumTb = new System.Windows.Forms.TextBox();
            this.CatCb = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Guest = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.Turquoise;
            this.button5.Location = new System.Drawing.Point(26, 178);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button5.Size = new System.Drawing.Size(142, 35);
            this.button5.TabIndex = 31;
            this.button5.Text = "Users";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.Turquoise;
            this.button6.Location = new System.Drawing.Point(26, 121);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button6.Size = new System.Drawing.Size(142, 35);
            this.button6.TabIndex = 30;
            this.button6.Text = "Order";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1290, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ItemsGV);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.ItemPriceTb);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ItemNameTb);
            this.panel1.Controls.Add(this.ItemNumTb);
            this.panel1.Controls.Add(this.CatCb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(189, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1105, 725);
            this.panel1.TabIndex = 27;
            // 
            // ItemsGV
            // 
            this.ItemsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ItemsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ItemsGV.BackgroundColor = System.Drawing.Color.White;
            this.ItemsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemsGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.ItemsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsGV.GridColor = System.Drawing.Color.Gainsboro;
            this.ItemsGV.Location = new System.Drawing.Point(344, 122);
            this.ItemsGV.Margin = new System.Windows.Forms.Padding(5);
            this.ItemsGV.Name = "ItemsGV";
            this.ItemsGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ItemsGV.RowTemplate.Height = 25;
            this.ItemsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGV.Size = new System.Drawing.Size(678, 477);
            this.ItemsGV.TabIndex = 31;
            this.ItemsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsGV_CellContentClick);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button9.BackColor = System.Drawing.SystemColors.Highlight;
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button9.ForeColor = System.Drawing.Color.Turquoise;
            this.button9.Location = new System.Drawing.Point(178, 355);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button9.Size = new System.Drawing.Size(76, 32);
            this.button9.TabIndex = 30;
            this.button9.Text = "Update";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button8.BackColor = System.Drawing.SystemColors.Highlight;
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button8.ForeColor = System.Drawing.Color.Turquoise;
            this.button8.Location = new System.Drawing.Point(96, 355);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button8.Size = new System.Drawing.Size(76, 32);
            this.button8.TabIndex = 29;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Turquoise;
            this.label7.Location = new System.Drawing.Point(641, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 37);
            this.label7.TabIndex = 28;
            this.label7.Text = "Item List";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Turquoise;
            this.label6.Location = new System.Drawing.Point(15, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "ItemPrice";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(18, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "ItemName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Turquoise;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 25;
            this.label3.Text = "ItemNum";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.Highlight;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Turquoise;
            this.button3.Location = new System.Drawing.Point(1141, 1002);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button3.Size = new System.Drawing.Size(142, 32);
            this.button3.TabIndex = 23;
            this.button3.Text = "Place The Order";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // ItemPriceTb
            // 
            this.ItemPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemPriceTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemPriceTb.Location = new System.Drawing.Point(127, 218);
            this.ItemPriceTb.Name = "ItemPriceTb";
            this.ItemPriceTb.PlaceholderText = "Price";
            this.ItemPriceTb.Size = new System.Drawing.Size(142, 22);
            this.ItemPriceTb.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.Highlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Turquoise;
            this.button4.Location = new System.Drawing.Point(15, 355);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button4.Size = new System.Drawing.Size(76, 32);
            this.button4.TabIndex = 22;
            this.button4.Text = "Add";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Turquoise;
            this.button2.Location = new System.Drawing.Point(1593, 1314);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button2.Size = new System.Drawing.Size(142, 32);
            this.button2.TabIndex = 21;
            this.button2.Text = "Place The Order";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Highlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Turquoise;
            this.button1.Location = new System.Drawing.Point(1003, 898);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button1.Size = new System.Drawing.Size(142, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ItemNameTb
            // 
            this.ItemNameTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemNameTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNameTb.Location = new System.Drawing.Point(127, 122);
            this.ItemNameTb.Name = "ItemNameTb";
            this.ItemNameTb.PlaceholderText = "Name";
            this.ItemNameTb.Size = new System.Drawing.Size(142, 22);
            this.ItemNameTb.TabIndex = 16;
            // 
            // ItemNumTb
            // 
            this.ItemNumTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemNumTb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ItemNumTb.Location = new System.Drawing.Point(127, 82);
            this.ItemNumTb.Name = "ItemNumTb";
            this.ItemNumTb.PlaceholderText = "Number";
            this.ItemNumTb.Size = new System.Drawing.Size(142, 22);
            this.ItemNumTb.TabIndex = 15;
            // 
            // CatCb
            // 
            this.CatCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CatCb.FormattingEnabled = true;
            this.CatCb.Items.AddRange(new object[] {
            "Food",
            "Beverage"});
            this.CatCb.Location = new System.Drawing.Point(67, 162);
            this.CatCb.Name = "CatCb";
            this.CatCb.Size = new System.Drawing.Size(142, 26);
            this.CatCb.TabIndex = 13;
            this.CatCb.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Turquoise;
            this.label5.Location = new System.Drawing.Point(444, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "Manage Items";
            // 
            // Guest
            // 
            this.Guest.AutoSize = true;
            this.Guest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Guest.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.Guest.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Guest.Location = new System.Drawing.Point(51, 740);
            this.Guest.Name = "Guest";
            this.Guest.Size = new System.Drawing.Size(71, 25);
            this.Guest.TabIndex = 28;
            this.Guest.Text = "Logout";
            this.Guest.Click += new System.EventHandler(this.Guest_Click);
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1312, 772);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Guest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsForm";
            this.Load += new System.EventHandler(this.ItemsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button5;
        private Button button6;
        private Label label1;
        private Panel panel1;
        private Button button3;
        private TextBox ItemPriceTb;
        private Button button4;
        private Button button2;
        private Button button1;
        private TextBox ItemNameTb;
        private TextBox ItemNumTb;
        private ComboBox CatCb;
        private Label label5;
        private Label Guest;
        private Label label4;
        private Label label3;
        private Button button9;
        private Button button8;
        private Label label7;
        private Label label6;
        private DataGridView ItemsGV;
    }
}