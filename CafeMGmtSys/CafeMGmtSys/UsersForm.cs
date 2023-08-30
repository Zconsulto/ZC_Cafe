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
using System.Data.SqlTypes;

namespace CafeMGmtSys
{
    public partial class UsersForm : Form
    {

        public UsersForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aly Elshorbagy\Documents\Cafedb.mdf"";Integrated Security=True;Connect Timeout=30");
        void Populate()
        {
            con.Open();
            string query = "select * from UsersTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            UsersGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UserOrder uOrder = new UserOrder();
            uOrder.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ItemsForm item = new ItemsForm();
            item.Show();
            this.Hide();
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into UsersTb1 values('" + UnameTb.Text + "','" + UphoneTb.Text + "','" + UpassTb.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Created!");
            con.Close();
            Populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            UnameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (UpassTb.Text == "")
            {
                MessageBox.Show("Select The User to be Deleted");
            }
            else
            {
                con.Open();
                string query = "delete from UsersTb1 where Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                con.Close();
                Populate();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (UpassTb.Text == "" || UphoneTb.Text == "" || UnameTb.Text == "")
            {
                MessageBox.Show("Fill All The Fields");
            }
            else
            {
                con.Open();
                string query = "update UsersTb1 set Uname = '" + UnameTb.Text + "', Upassword = '" + UpassTb.Text + "' where  Uphone = '" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                con.Close();
                Populate();
            }
        }
    }
}
