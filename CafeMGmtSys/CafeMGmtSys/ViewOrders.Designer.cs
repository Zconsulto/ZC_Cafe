namespace CafeMGmtSys
{
    partial class ViewOrders
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
            this.OrdersPannel = new System.Windows.Forms.Panel();
            this.OrdersGV = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.OrdersPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdersPannel
            // 
            this.OrdersPannel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OrdersPannel.Controls.Add(this.OrdersGV);
            this.OrdersPannel.Location = new System.Drawing.Point(41, 133);
            this.OrdersPannel.Name = "OrdersPannel";
            this.OrdersPannel.Size = new System.Drawing.Size(570, 430);
            this.OrdersPannel.TabIndex = 0;
            // 
            // OrdersGV
            // 
            this.OrdersGV.BackgroundColor = System.Drawing.Color.White;
            this.OrdersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGV.GridColor = System.Drawing.Color.White;
            this.OrdersGV.Location = new System.Drawing.Point(3, 0);
            this.OrdersGV.Name = "OrdersGV";
            this.OrdersGV.RowHeadersWidth = 51;
            this.OrdersGV.RowTemplate.Height = 25;
            this.OrdersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrdersGV.Size = new System.Drawing.Size(564, 427);
            this.OrdersGV.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(211, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 37);
            this.label5.TabIndex = 11;
            this.label5.Text = "LIST OF ORDERS";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(251, 591);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.button3.Size = new System.Drawing.Size(142, 32);
            this.button3.TabIndex = 24;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(656, 702);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrdersPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.OrdersPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel OrdersPannel;
        private Label label5;
        private Button button3;
        private DataGridView OrdersGV;
    }
}