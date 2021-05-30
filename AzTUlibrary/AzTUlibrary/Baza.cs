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
    public partial class Baza : Form
    {
        public Baza()
        {
            InitializeComponent();
        }
        SqlConnection connect;
        SqlCommand com;
        SqlDataAdapter da;
        void qeyd() 
        {
            connect= new SqlConnection("Data Source=LAPTOP-K5NS6649\\SQLEXPRESS;Initial Catalog=kitabxana_aztu;Integrated Security=SSPI");
            connect.Open();
            da = new SqlDataAdapter("SELECT *from melumatlar", connect);
            DataTable cedvel = new DataTable();
            da.Fill(cedvel);
            dataGridView1.DataSource = cedvel;
            connect.Close();
        }
        private void Baza_Load(object sender, EventArgs e)
        {
            qeyd();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sual = "INSERT INTO melumatlar(Ad,Soyad,Vəzifəsi,Fakültə,ID) VALUES(@Ad,@Soyad,@Vəzifəsi,@Fakültə,@ID)";
            com = new SqlCommand(sual, connect);
            com.Parameters.AddWithValue("@Ad", textBox1.Text);
            com.Parameters.AddWithValue("@Soyad", textBox5.Text);
            com.Parameters.AddWithValue("@Vəzifəsi", textBox4.Text);
            com.Parameters.AddWithValue("@Fakültə", textBox3.Text);
            com.Parameters.AddWithValue("@ID", textBox2.Text);
            connect.Open();
            com.ExecuteNonQuery();
            connect.Close();
            qeyd();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sual = "DELETE FROM melumatlar WHERE Bilet_no=@Bilet_no";
            com = new SqlCommand(sual, connect);
            com.Parameters.AddWithValue("@Bilet_no",Convert.ToInt32(textBox6.Text));
            connect.Open();
            com.ExecuteNonQuery();
            connect.Close();
            qeyd();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sual = "UPDATE  melumatlar SET Ad=@Ad,Soyad=@Soyad,Vəzifəsi=@Vəzifəsi,Fakültə=@Fakültə,ID=@ID WHERE Bilet_no=@Bilet_no";
            com = new SqlCommand(sual, connect);
            com.Parameters.AddWithValue("@Bilet_no", Convert.ToInt32(textBox6.Text));
            com.Parameters.AddWithValue("@Ad", textBox1.Text);
            com.Parameters.AddWithValue("@Soyad", textBox5.Text);
            com.Parameters.AddWithValue("@Vəzifəsi", textBox4.Text);
            com.Parameters.AddWithValue("@Fakültə", textBox3.Text);
            com.Parameters.AddWithValue("@ID", textBox2.Text);
            connect.Open();
            com.ExecuteNonQuery();
            connect.Close();
            qeyd();
        }

        private void butn4_Click(object sender, EventArgs e)
        {
            new admin().Show();
            this.Hide();
        }

        private void but5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
