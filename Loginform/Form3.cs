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
namespace Loginform
{
    public partial class Form3 : Form
    {
        int fbal;
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RCS6K8J\\SOMESHSQL;Initial Catalog=somesh;Integrated Security=True");
            con.Open();
            SqlCommand cmd1= new SqlCommand("SELECT Balance FROM    Bank WHERE  Balance= (SELECT MIN(Balance)  FROM Bank); ", con);
            fbal = (int)cmd1.ExecuteScalar();
            fbal = fbal - int.Parse(textBox3.Text);
            string sql= "insert into Bank(Account_No,Name,Date,Amount,Balance) values('" +textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text+ "','" + textBox3.Text + "','" + fbal + "')";            SqlCommand cmd = new SqlCommand(sql, con);
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Transferred Successfully....Avl bal: "+fbal);
            }
            else
            {
                MessageBox.Show("Error");
            }
            cmd.Dispose();
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
