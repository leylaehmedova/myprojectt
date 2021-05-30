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
    public partial class REGİSTER : Form
    {
        public REGİSTER()
        {
            InitializeComponent();
        }
        static string constring = "Data Source=LAPTOP-K5NS6649\\SQLEXPRESS;Initial Catalog = kitabxana_aztu; Integrated Security=TRUE";
        SqlConnection connect = new SqlConnection(constring);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buton3_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butn1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string register = "Insert into dbo.melumatlar (Ad,Soyad,Vəzifəsi,Fakültə,ID) values('" + textBx1.Text + "', '" + textBx5.Text + "','" + textBx6.Text + "','" + textBx4.Text + "','" + textBox1.Text + "')";
                SqlCommand command = new SqlCommand(register, connect);
                command.Parameters.AddWithValue("@Ad", textBx1.Text);
                command.Parameters.AddWithValue("@Soyad", textBx5.Text);
                command.Parameters.AddWithValue("@Vəzifəsi", textBx6.Text);
                command.Parameters.AddWithValue("@Fakültə", textBx4.Text);
                command.Parameters.AddWithValue("@ID", textBox1.Text);
                command.ExecuteNonQuery();
                connect.Close();
                MessageBox.Show("SUCCESSFULLY REGISTERED");
                new Bilet().Show();
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("An error occured" + error.Message);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
