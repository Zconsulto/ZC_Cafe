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

namespace CafeMGmtSys
{
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\OneDrive\Documents\CafeDB.mdf;Integrated Security=True;Connect Timeout=30");

        void Populate()
        {
            con.Open();
            string query = "select * from OrdersTb1";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(SDA);
            var ds = new DataSet();
            SDA.Fill(ds);
            OrdersGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void ViewOrders_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
