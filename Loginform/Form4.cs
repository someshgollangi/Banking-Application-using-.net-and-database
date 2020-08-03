using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginform
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'someshDataSet2.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter1.Fill(this.someshDataSet2.Bank);
            // TODO: This line of code loads data into the 'someshDataSet1.Bank' table. You can move, or remove it, as needed.
            this.bankTableAdapter.Fill(this.someshDataSet1.Bank);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
