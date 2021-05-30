using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzTUlibrary
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
new Bilet().Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }
    }
}
