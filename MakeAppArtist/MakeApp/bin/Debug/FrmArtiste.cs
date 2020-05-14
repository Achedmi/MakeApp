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
    public partial class FrmArtiste : Form
    {
        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper2;
        public FrmArtiste()
        {
            InitializeComponent();            
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = true;
            pnlProfil.Visible = false;
            gunaVScrollBar1.Show();
            gunaVScrollBar2.Hide();
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = true;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = true;
            gunaVScrollBar1.Hide();
            gunaVScrollBar2.Show();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            //gunaCirclePictureBox3.Visible = true;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = false;
        }


       // bool firstime = true;
        public void FrmArtiste_Load_1(object sender, EventArgs e)
        {
           
                vScrollHelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlHome, gunaVScrollBar1, true);
                vScrollHelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel7, gunaVScrollBar2, true);
            

           /* for (int x = pnlHome.Controls.Count - 1; x >=2 ; x--)
            {
                pnlHome.Controls.RemoveAt(x);
            }
            for (int x = 1; x < panel13.Controls.Count; x++)
            {
                panel13.Controls.RemoveAt(x);
            }
            for (int x = 1; x < panel7.Controls.Count; x++)
            {
                panel7.Controls.RemoveAt(x);
            }*/

            //Accueil

            SqlCommand cmd = new SqlCommand("select TOP 3 ([Client].Nom + ' ' + Client.Prenom)as Name,  COUNT(*)as Total from Choisie inner join RDV on RDV.idRdv = Choisie.idRdv inner join Client on RDV.MailFrom = Client.Mail where Choisie.Finished = 1 and Choisie.choisie = 1 group by [Client].Nom + ' ' + Client.Prenom order by Total DESC", C.cn);
            if (C.cn.State == ConnectionState.Open)
            {
                C.cn.Close();
            }
            C.cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            int i = 1,j = 2;
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
                panel4.Controls[0].Text = "0"+dr[2].ToString();
            }



            cmd = new SqlCommand("select Nom + ' ' +Prenom , DateRdv ,Client.Tel,DescriptionRdv ,HeurRdv ,Choisie.mailArtist,RDV.idRdv from RDV inner join Client on Client.Mail = rdv.MailFrom left join choisie on Choisie.idrdv = RDV.idRdv  where RDV.idRdv not in (select idRdv from Choisie where Choisie = 1 or finished = 1)", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                RDV rdv = new RDV();
                rdv.lblName.Text = dr[0].ToString();
                rdv.lblDate.Text = dr[1].ToString().Split(' ')[0];
                rdv.lblTel.Text = "0" + dr[2].ToString();
                rdv.lblDesc.Text = dr[3].ToString();
                rdv.lblHeur.Text = dr[4].ToString().Substring(0,5);
                rdv.label1.Text = dr[6].ToString();
                rdv.Location = new Point(101, pnlHome.Controls[pnlHome.Controls.Count-1].Location.Y + pnlHome.Controls[pnlHome.Controls.Count-1].Size.Height+20);
                if (dr[5].ToString() == C.user1.Mail)
                    rdv.BtnPrendre.Text = "Annuler";
                else
                    rdv.BtnPrendre.Text = "Prendre";

                pnlHome.Controls.Add(rdv);
            }
            




            C.cn.Close();






            //profile
            lblPrenom.Text = C.user1.Prenom;
            lblMail.Text = C.user1.Mail;
            lblTel.Text = "0" + C.user1.NumTel.ToString();
            lblUserName.Text = "Hello " + C.user1.Prenom + " !";
            gunaLabel28.Text = "Hello " + C.user1.Prenom + " !";

            cmd = new SqlCommand("select COUNT(*) from Choisie where MailArtist= '"+C.user1.Mail+"' and Finished = 0 and choisie = 1", C.cn);
            cmd.Parameters.AddWithValue("@a",C.user1.Mail);
            if (C.cn.State == ConnectionState.Open)
            {
                C.cn.Close();
            }
            C.cn.Open();
            lblNbrRdv.Text = "Vous avez " + cmd.ExecuteScalar().ToString() + " rendez vous";
            gunaLabel27.Text = "Vous avez " + cmd.ExecuteScalar().ToString() + " rendez vous";


            cmd = new SqlCommand("select Client.Prenom+ ' '+ Client.Nom , DateRdv ,HeurRdv  from Choisie   inner join RDV on RDV.idRdv = Choisie.idrdv inner join Client on Client.Mail = rdv.MailFrom  where MailArtist= 'houda@houda.com' and Finished = 0 and choisie = 1 order by DateRdv asc", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NextRdv nxt = new NextRdv();
                nxt.lblName.Text = dr[0].ToString();
                nxt.lblDate.Text = dr[1].ToString().Split(' ')[0];
                nxt.lblTime.Text = dr[2].ToString().Substring(0,5);
                nxt.Location = new Point(0, panel13.Controls[panel13.Controls.Count - 1].Location.Y + panel13.Controls[panel13.Controls.Count - 1].Size.Height + 10);
                panel13.Controls.Add(nxt);
            }


            cmd = new SqlCommand("select  Nom + ' ' +Prenom , DateRdv ,Client.Tel,DescriptionRdv ,HeurRdv ,Choisie.mailArtist from RDV inner join Client on Client.Mail = rdv.MailFrom left join choisie on Choisie.idrdv = RDV.idRdv  where RDV.idRdv in (select idRdv from Choisie where Choisie = 1 and finished = 1)", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (dr[5].ToString() == C.user1.Mail)
                {
                    Historique rdv = new Historique();
                    rdv.lblName.Text = dr[0].ToString();
                    rdv.lblDate.Text = dr[1].ToString().Split(' ')[0];
                    rdv.lblHeur.Text = dr[4].ToString().Substring(0, 5);
                    rdv.Location = new Point(10, panel7.Controls[panel7.Controls.Count - 1].Location.Y + panel7.Controls[panel7.Controls.Count - 1].Size.Height);
                    panel7.Controls.Add(rdv);
                }
            }


            C.cn.Close();

            //firstime = false;

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
