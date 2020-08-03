using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              SqlConnection con=new SqlConnection("Data Source=DESKTOP-RCS6K8J\\SOMESHSQL;Initial Catalog=somesh;Integrated Security=True");
              con.Open();
              String username = textBox1.Text;
              String password = textBox2.Text;
              SqlCommand cmd=new SqlCommand("select Username,passwd from Login where Username='"+ textBox1.Text +"' and passwd= '"+ textBox2.Text +"'  ",con);
              SqlDataAdapter da=new SqlDataAdapter(cmd);
              DataTable dt=new DataTable();
              da.Fill(dt);
              if (dt.Rows.Count > 0)
              {
                Form2 obj1 = new Form2();
                obj1.Show();
                this.Hide();

                MessageBox.Show("Login sucess");
              }
              else
              {
                  MessageBox.Show("Invalid Login please check username and password");
              }
              con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
