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

namespace AzTUlibrary
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        
        SqlConnection constring = new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS;Initial Catalog=kitabxana_aztu;Integrated Security=TRUE");
        SqlConnection connect = new SqlConnection();
        bool isthere;
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new REGİSTER().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void bıttn3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void bıttn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string bilet = textBox1.Text;
            string ad = textBox3.Text;
            string soyad = textBox2.Text;
            constring.Open();
            SqlCommand command = new SqlCommand("Select *from dbo.melumatlar", constring);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                
                    if (bilet == reader["Bilet_no"].ToString().TrimEnd() && ad == reader["Ad"].ToString().TrimEnd() && soyad == reader["Soyad"].ToString().TrimEnd())
                    {
                        isthere = true;
                        break;
                    }
                    else
                    {
                        isthere = false;

                    }
                
            }
            if (isthere==true)
            {
                MessageBox.Show("Login Succesful!");
                new kitabxana().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Re-Enter");

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
new kitabxana().Show();
            this.Hide();
        }
    }
}
