using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CafeMGmtSys
{
    public partial class GuestOrder : Form
    {
        public GuestOrder()
        {
         
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Documents\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");

        void Populate()
        {
            con.Open();
            string query = "select * from ItemTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }
        DataTable OrdersTable = new DataTable();
        int num = 0;
        int price, qty, total;
        string item, cat;
        int flag = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                OrdersTable.Rows.Add(num, item, cat, price, total);
                OrdersGV.DataSource = OrdersTable;
                flag = 0;

            }
            sum = sum + total;
            LabelAmount.Text =  ""+sum;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {

        }

        private void Refresh(object sender, EventArgs e)
        {
            Populate();
        }
        void filterByCategory()
        {
            con.Open();
            string query = "select * from ItemTb1 where Itemcat = '" + categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void categorycb_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the quantity of item?");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The product to be ordered");
            }
            else
            {
                num = num + 1;
                total = price * Convert.ToInt32(QtyTb.Text);
                OrdersTable.Rows.Add(num, item, cat, price, total);
                OrdersGV.DataSource = OrdersTable;
                flag = 0;

            }
            sum = sum + total;
            LabelAmount.Text ="" + sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into OrdersTb1 values('" + OrderNumTb.Text + "','" + DateLbl.Text + "','" + SellerName.Text  + "','" + LabelAmount.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created!");
            con.Close();
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int sum = 0;
        private void GuestOrder_Load(object sender, EventArgs e)
        {
            Populate();
            OrdersTable.Columns.Add("Num", typeof(int));
            OrdersTable.Columns.Add("Item", typeof(string));
            OrdersTable.Columns.Add("Category", typeof(string));
            OrdersTable.Columns.Add("UnitPrice", typeof(int));
            OrdersTable.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource = OrdersTable;
            DateLbl.Text = DateTime.Today.Date.ToShortDateString();

        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(ItemsGV.SelectedRows[0].Cells[0].Value.ToString());

            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }
    }
}
