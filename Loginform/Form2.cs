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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bankingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {

                if (ActiveMdiChild.GetType().Name != "Form3")
                {
                    ActiveMdiChild.Close();
                    Form3 obj2 = new Form3();
                    obj2.MdiParent = this;
                    obj2.Show();
                }
                else
                {
                    MessageBox.Show("Form is already open");
                }

            }
            else
            {
                Form3 obj2 = new Form3();
                obj2.MdiParent = this;
                obj2.Show();
            }

        }

        private void transactionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 obj3 = new Form4();
            obj3.MdiParent = this;
            obj3.Show();
        }

        private void balanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 obj4=new Form5();
            obj4.MdiParent = this;
            obj4.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
