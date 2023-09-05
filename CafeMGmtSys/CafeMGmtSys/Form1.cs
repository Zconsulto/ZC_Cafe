
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace CafeMGmtSys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Documents\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Do nothing
        }

        private void Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestOrder guest = new GuestOrder();
            guest.Show();
        }
        public static string user;
        private void button1_Click(object sender, EventArgs e)
        {
            /*   UserOrder uOrder = new UserOrder();
               uOrder.Show();
               this.Hide();*/
            user = UnameTb.Text;
            if (UnameTb.Text == "" || PasswordTb.Text == "")
            {
                MessageBox.Show("Enter A Username and Password");

            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) from UsersTb1 where Uname ='"+UnameTb.Text+"' and Upassword ='"+PasswordTb.Text+ "'",con);
                DataTable dt =new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    UserOrder uOrder = new UserOrder();
                    uOrder.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong Username or password");
                }
                con.Close();
            }

        }
    }
}