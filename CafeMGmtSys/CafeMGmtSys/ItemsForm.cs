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
namespace CafeMGmtSys
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
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
        private void Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || ItemPriceTb.Text == "")
            {
                MessageBox.Show("Fill All The Data");
            }
            else
            {
                con.Open();
                string query = "insert into ItemTb1 values('" + ItemNumTb.Text + "','" + ItemNameTb.Text + "','" + CatCb.SelectedItem.ToString() +"','"+ ItemPriceTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Created!");
                con.Close();
                Populate();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserOrder uOrder = new UserOrder();
            uOrder.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UsersForm userForm = new UsersForm();
            userForm.Show();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void ItemsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNumTb.Text = ItemsGV.SelectedRows[0].Cells[0].Value.ToString();
            ItemNameTb.Text = ItemsGV.SelectedRows[0].Cells[1].Value.ToString();
            CatCb.SelectedItem = ItemsGV.SelectedRows[0].Cells[2].Value.ToString();
            ItemPriceTb.Text = ItemsGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "")
            {
                MessageBox.Show("Select The Item to be Deleted");
            }
            else
            {
                con.Open();
                string query = "delete from ItemTb1 where ItemNum = '" + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Deleted");
                con.Close();
                Populate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ItemNumTb.Text == "" || ItemNameTb.Text == "" || ItemPriceTb.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                con.Open();
                string query = "update ItemTb1 set ItemPrice = '" + ItemPriceTb.Text + "', ItemCat = '" + CatCb.SelectedItem.ToString() + "', ItemName = '" + ItemNameTb.Text + "' where ItemNum = '"  + ItemNumTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Item Successfully Updated");
                con.Close();
                Populate();
            }
        }

        
    }
}
