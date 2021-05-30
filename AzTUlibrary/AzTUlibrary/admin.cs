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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }
        SqlConnection constring = new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS;Initial Catalog=kitabxana_aztu;Integrated Security=TRUE");
        SqlConnection connect = new SqlConnection();
        bool isthere;
        private void button1_Click(object sender, EventArgs e)
        {

            string parol = textBox2.Text;
            string domen = textBox1.Text;
            constring.Open();
            SqlCommand command = new SqlCommand("Select *from dbo.admin", constring);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                if (parol == reader["parol"].ToString().TrimEnd() && domen == reader["admin_domen"].ToString().TrimEnd())
                {
                    isthere = true;
                    break;
                }
                else
                {
                    isthere = false;

                }

            }
            if (isthere == true)
            {
                MessageBox.Show("Login Succesful!");
                new Baza().Show();
                this.Hide();


            }
            else
            {
                MessageBox.Show("Invalid Credentials, Please Re-Enter");

            }
        
    }

        private void butn3_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void but4_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
