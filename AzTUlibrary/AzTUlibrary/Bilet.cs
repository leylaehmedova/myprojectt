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
    public partial class Bilet : Form
    {
        public Bilet()
        {
            InitializeComponent();
        }
        
        private void bton3_Click(object sender, EventArgs e)
        {
            new login().ShowDialog();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-K5NS6649\SQLEXPRESS;Initial Catalog=kitabxana_aztu;Integrated Security=True");
            String sql =" select * from melumatlar where ID='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cn.Open();
           
            using (SqlDataReader dr = cmd.ExecuteReader())
            if (dr.Read())
            {
                    label10.Text = dr["Ad"].ToString();
                    label11.Text = dr["Soyad"].ToString();
                    label12.Text = dr["Vəzifəsi"].ToString();
                    label5.Text = dr["Bilet_no"].ToString();
            }
        }


        private void Bilet_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }

}      