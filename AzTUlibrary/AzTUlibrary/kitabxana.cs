using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
namespace AzTUlibrary
{
    public partial class kitabxana : Form
    {
       public static string to;
        public kitabxana()
        {
            InitializeComponent();
        } 
        private void buton3_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
          try
            {
                string a = "", b = "", c = "", d = "", S = "", f = "", g = "", h = "", i = "", j = "", k = "", l = "", m = "", n = "", o = "", p = "", q = "", r = "", s = "", t = "", u = "", v = "", w = "", x = "", y = "", z = "", A = "", B = "", C = "", D = "";
                    to = (txtEmail.Text).ToString();
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                    client.EnableSsl = true;
                    client.Timeout = 10000000;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("mrsnobody27@gmail.com", "hmgtohldjydoeetu");
                    MailMessage msg = new MailMessage();
                    msg.To.Add(to);
                    msg.From = new MailAddress("mrsnobody27@gmail.com");
                    msg.Subject = "AzTU əsas kitabxana";
                if (checkBox1.Checked == true)
                {
                    a = "\nAvesta(M.Aktaş) kitabı kitabxanamızda mövcuddur.";

                }
                if (checkBox2.Checked == true)
                {
                 b = "\nB plani(A.Lamott) kitabı kitabxanamızda mövcud deyil.";
                }
                if (checkBox3.Checked == true)
                {
                    c = "\nC/C++(F.Erdinç) kitabı kitabxanamızda mövcuddur.";
                }
                if (checkBox4.Checked == true)
                {
                    d = "\nÇevrilmə(F.Kafka) kitabı kitabxanamızda mövcud deyil.";
                   
                }
                if (checkBox5.Checked == true)
                {
                    S= "\nDağ quşları(S.Güven) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox6.Checked == true)
                {
                   f = "\nEdison(E.Angel) kitabı kitabxanamızda mövcud deyil.";
                   
                }
                if (checkBox7.Checked == true)
                {
                    g = "\nƏdəbiyyat parkı(M.Tenker) kitabı kitabxanamızda mövcuddur.";
                    
                }
                if (checkBox8.Checked == true)
                {
                   h = "\nFable(A.Young) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox9.Checked == true)
                {
                   i = "\nGanga(G.Dayıoğlu) kitabı kitabxanamızda mövcud deyil.";
                  
                }
                if (checkBox10.Checked == true)
                {
                   j = "\nHəcc günlüyü(A.Kurucan) kitabı kitabxanamızda mövcuddur.";
                    
                }
                if (checkBox11.Checked == true)
                {
                  k = "\nİnsan ovu(Ç.Abdullayev) kitabı kitabxanamızda mövcud deyil.";
                    
                }
                if (checkBox12.Checked == true)
                {
                    l = "\nJade(N.H.Yıldız) kitabı kitabxanamızda mövcud deyil.";
                   
                }
                if (checkBox13.Checked == true)
                {
                   m = "\nKəbə yolları(Y.Tavaslı) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox14.Checked == true)
                {
                 n = "\nQara ada(M.Bakırhan) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox15.Checked == true)
                {
                 o = "\nLaçın folkloru(İ.Qəhrəman) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox16.Checked == true)
                {
                   p = "\nMaddə 22(J.Heller) kitabı kitabxanamızda mövcud deyil.";
                  
                }
                if (checkBox17.Checked == true)
                {
                   q = "\nNal səsləri(A.Akçam) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox18.Checked == true)
                {
                  r = "\nO gün(N.Baysal) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox19.Checked == true)
                {
                  s = "\nÖtəki tərəf(İ.Mavera) kitabı kitabxanamızda mövcud deyil.";
                
                }
                if (checkBox20.Checked == true)
                {
                   t = "\nPaprika(H.Durgut) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox21.Checked == true)
                {
                  u = "\nRahibə Kety(M.Dev) kitabı kitabxanamızda mövcud deyil.";
                   
                }
                if (checkBox22.Checked == true)
                {
                   v = "\nSəadət günəşi(E.Həsənov) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox23.Checked == true)
                {
                  w = "\nŞəfəqdən əvvəl(B.Moore) kitabı kitabxanamızda mövcud deyil.";
                  
                }
                if (checkBox24.Checked == true)
                {
                  x = "\nTəqvim(E.G.Naskali) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox25.Checked == true)
                {
                  y = "\nTəbiət haqlıdır(M.Messegue) kitabı kitabxanamızda mövcuddur.";
                    
                }
                if (checkBox26.Checked == true)
                {
                   z = "\nUğultu(H.Şentürk) kitabı kitabxanamızda mövcud deyil.";
                  
                }
                if (checkBox27.Checked == true)
                {
                  A = "\nÜç dost(O.Aytekin) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox28.Checked == true)
                {
                  B = "\nVaxt arsı(O.Koca) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox29.Checked == true)
                {
                   C = "\nYalvarış(T.Caldwell) kitabı kitabxanamızda mövcuddur.";
                   
                }
                if (checkBox30.Checked == true)
                {
                   D = "\nZabit Londra'da(S.Bulgur) kitabı kitabxanamızda mövcuddur.";
                   
                }
                msg.Body = "Sizin seçdiyiniz:" + a + b + c + d + S + f + g + h + i + j + k + l + m + n + o + p + q + r + s + t + u + v + w + x + y + z + A + B + C + D+"\nKitabxanamız həftə içi saat 9:00-dan 19:00-a qədər açıqdır. Buyurub rahatlıqla kitablarınızı götürə bilərsiniz.\nÜnvan:Azərbaycan Texniki Universiteti,3-cü korpus,3-cü mərtəbə,otaq № 303";
                client.Send(msg);
                MessageBox.Show("succesfully sent message");}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
           }
        }

        private void buton4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
    }
        

