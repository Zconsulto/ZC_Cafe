using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CafeMGmtSys
{
    public partial class UserOrder : Form
    {
        public UserOrder()
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
        void filterByCategory()
        {
            con.Open();
            string query = "select * from ItemTb1 where Itemcat = '"+ categorycb.SelectedItem.ToString() + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            ItemsGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsForm Item = new ItemsForm();
            Item.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm user = new UsersForm();
            user.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
             
        int num = 0;
        int price, qty, total;
        string item,cat;
        int flag = 0;
        int sum = 0;

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (QtyTb.Text == "")
            {
                MessageBox.Show("What is the quantity of item?");
            }else if (flag==0)
            {
                MessageBox.Show("Select The product to be ordered");
            }
            else
            {
                num=num+1;
                total=price*Convert.ToInt32(QtyTb.Text);
                OrdersTable.Rows.Add(num, item, cat, price, total);
                OrdersGV.DataSource= OrdersTable;
                flag = 0;

            }
            sum = sum + total;
            LabelAmount.Text = "" + sum;
        }

        private void OrdersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            filterByCategory();
        }

        private void Refresh(object sender, EventArgs e)
        {

            Populate();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LabelAmount_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into OrdersTb1 values('" + OrderNumTb.Text + "','" + DateLbl.Text + "','" + SellerNameTb.Text + "','" + LabelAmount.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Successfully Created!");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewOrders view=new ViewOrders();
            view.Show();

        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            item = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            cat = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            price = Convert.ToInt32(ItemsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;
        }

        DataTable OrdersTable = new DataTable();

        private void UserOrder_Load(object sender, EventArgs e)
        {
            Populate();
            OrdersTable.Columns.Add("Num", typeof(int));
            OrdersTable.Columns.Add("Item", typeof(string));
            OrdersTable.Columns.Add("Category", typeof(string));
            OrdersTable.Columns.Add("UnitPrice", typeof(int));
            OrdersTable.Columns.Add("Total", typeof(int));
            OrdersGV.DataSource= OrdersTable;
            DateLbl.Text = DateTime.Today.Date.ToShortDateString();
            SellerNameTb.Text = Form1.user;
        }

        
    }
}
