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

namespace MakeApp
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private void FrmClient_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select TOP 3 ([Client].Nom + ' ' + Client.Prenom)as Name,  COUNT(*)as Total from Choisie inner join RDV on RDV.idRdv = Choisie.idRdv inner join Client on RDV.MailFrom = Client.Mail where Choisie.Finished = 1 and Choisie.choisie = 1 group by [Client].Nom + ' ' + Client.Prenom order by Total DESC", C.cn);
            if (C.cn.State == ConnectionState.Open)
            {
                C.cn.Close();
            }
            C.cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 1, j = 2;
            while (dr.Read())
            {
                panel1.Controls[i].Text = dr[0].ToString() + ":";
                panel1.Controls[j].Text = dr[1].ToString();
                i += 2;
                j += 2;
            }

            cmd = new SqlCommand("select Top 1 Client.Nom + ' ' +Client.Prenom,DateRdv,Client.Tel from RDV inner join Client on Client.Mail = RDV.MailFrom order by DAteRdv desc  ", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                panel4.Controls[4].Text = dr[0].ToString();
                panel4.Controls[2].Text = dr[1].ToString().Split(' ')[0];
                panel4.Controls[0].Text = "0" + dr[2].ToString();
            }
            //profile

            lblPrenom.Text = C.user1.Prenom;
            lblMail.Text = C.user1.Mail;
            lblTel.Text = "0" + C.user1.NumTel.ToString();
            lblUserName.Text = "Hello " + C.user1.Prenom + " !";
            gunaLabel28.Text = "Hello " + C.user1.Prenom + " !";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = true;
            pnlHome.Visible = false;
            pnlProfil.Visible = false;
            pnlHome.Visible = true;
            gunaVScrollBar1.Show();
            gunaVScrollBar2.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = true;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = true;
            pnlHome.Visible = false;
            gunaVScrollBar1.Hide();
            gunaVScrollBar2.Show();
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            this.pnlFull.Visible = false;
            Func.Animate(panel13, 7, 124);
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            Func.Animate(panel13, 7, 229);
            this.pnlFull.Visible = true;
        }
    }
}
