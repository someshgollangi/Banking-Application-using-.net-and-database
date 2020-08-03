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
    public partial class Form5 : Form
    {
        int bal;
        
        public  Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-RCS6K8J\\SOMESHSQL;Initial Catalog=somesh;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT Balance FROM    Bank WHERE  Balance= (SELECT MIN(Balance)  FROM Bank); ", con);
            bal=(int)cmd.ExecuteScalar();
            MessageBox.Show("Avl Bal" + bal);

        }
    }
}
