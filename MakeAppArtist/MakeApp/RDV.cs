using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

namespace MakeApp
{
    public partial class RDV : UserControl
    {
        public RDV()
        {
            InitializeComponent();
        }

        static string smtpAddress = "smtp.gmail.com";
        static int portNumber = 587;
        static bool enableSSL = true;
        static string emailFromAddress = "makeapp.noreply@gmail.com"; //Sender Email Address  
        static string password = "makeapp1994"; //Sender Password   
        static string subject = "MakeApp Rendez-Vous";
        static string body = "MakeApp vous informe que l'un de nos artiste a bien accepter votre rendez-vous, notre artiste vous contactera d'ici peu.";


        public static void SendEmail(string emailToAddress)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                mail.To.Add(emailToAddress);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;
                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();

            if (C.cn.State == ConnectionState.Open)
            {
                C.cn.Close();
            }
            C.cn.Open();

            cmd = new SqlCommand("insert choisie values (@a,@b,0)", C.cn);

            cmd.Parameters.Add("@a", label1.Text);
            cmd.Parameters.Add("@b", C.user1.Mail);

            cmd.ExecuteNonQuery();
            C.frmAr.FrmArtiste_Load_1(sender,e);
            BtnPrendre.Enabled = false;
            C.cn.Close();
            string emailToAddress = C.user1.Mail; //Receiver Email Address
            SendEmail(emailToAddress);
        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
