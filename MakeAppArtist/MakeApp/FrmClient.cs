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
using System.IO;

namespace MakeApp
{
    public partial class FrmClient : Form
    {
        public FrmClient()
        {
            InitializeComponent();
        }

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper2;
        private void FrmClient_Load(object sender, EventArgs e)
        {
            vScrollHelper2 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(panel7, gunaVScrollBar2, true);

            C.DA = new SqlDataAdapter("select * from Marque", C.cn);
            DataSet data = new DataSet();
            C.DA.Fill(data, "Marque");
            gunaComboBox1.DataSource = data.Tables["Marque"];
            gunaComboBox1.DisplayMember = "NomMarque";
            gunaComboBox1.ValueMember = "idMarque";
            
            gunaComboBox1.Text = gunaComboBox1.Items[0].ToString();

            gunaComboBox2.Items.Add("Jour");
            gunaComboBox2.Items.Add("Soirée");
            gunaComboBox2.Items.Add("Fête");
            gunaComboBox2.Items.Add("Mariée");

            gunaComboBox2.Text = gunaComboBox2.Items[0].ToString();

            
            /* for (int x = pnlHome.Controls.Count - 1; x >=2 ; x--)
             {
                 pnlHome.Controls.RemoveAt(x);
             }
             for (int x = panel13.Controls.Count - 1; x >= 1; x--)
             {
                 panel13.Controls.RemoveAt(x);
             }
             for (int x = panel7.Controls.Count-1 ; x >= 1; x--)
             {
                 panel7.Controls.RemoveAt(x);
             }*/

            SqlCommand cmd = new SqlCommand("select TOP 3 ([Client].Nom + ' ' + Client.Prenom)as Name,  COUNT(*)as Total from Choisie inner join RDV on RDV.idRdv = Choisie.idRdv inner join Client on RDV.MailFrom = Client.Mail where Choisie.Finished = 1  group by [Client].Nom + ' ' + Client.Prenom order by Total DESC", C.cn);
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
            dr.Close();
            //profile

            lblPrenom.Text = C.user1.Prenom;
            lblMail.Text = C.user1.Mail;
            lblTel.Text = "0" + C.user1.NumTel.ToString();
            lblUserName.Text = "Hello " + C.user1.Prenom + " !";
            gunaLabel28.Text = "Hello " + C.user1.Prenom + " !";


            cmd = new SqlCommand("select Account.Prenom+ ' '+ Account.Nom , DateRdv ,HeurRdv  from rdv inner join choisie on choisie.idrdv = rdv.idrdv inner join account on account.mail = choisie.mailartist where mailfrom = '"+C.user1.Mail+"' and Finished = 0 order by DateRdv asc", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NextRdv nxt = new NextRdv();
                nxt.lblName.Text = dr[0].ToString();
                nxt.lblDate.Text = dr[1].ToString().Split(' ')[0];
                nxt.lblTime.Text = dr[2].ToString().Substring(0, 5);
                nxt.Location = new Point(0, panel13.Controls[panel13.Controls.Count - 1].Location.Y + panel13.Controls[panel13.Controls.Count - 1].Size.Height + 10);
                panel13.Controls.Add(nxt);
            }


            cmd = new SqlCommand("select  Nom + ' ' +Prenom , DateRdv ,Account.Tel,DescriptionRdv ,HeurRdv ,Choisie.mailArtist,account.img from rdv inner join choisie on choisie.idrdv = rdv.idrdv inner join account on account.mail = choisie.mailartist   where RDV.idRdv in (select idRdv from Choisie where finished = 1) and mailfrom = '"+C.user1.Mail+"'", C.cn);
            dr.Close();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Historique rdv = new Historique();
                rdv.lblName.Text = dr[0].ToString();
                rdv.lblDate.Text = dr[1].ToString().Split(' ')[0];
                rdv.lblHeur.Text = dr[4].ToString().Substring(0, 5);
                rdv.Location = new Point(10, panel7.Controls[panel7.Controls.Count - 1].Location.Y + panel7.Controls[panel7.Controls.Count - 1].Size.Height);
                if (dr[6].ToString() != "")
                {
                    byte[] img = (byte[])(dr[6]);
                    MemoryStream ms = new MemoryStream(img);
                    rdv.gunaTransfarantPictureBox1.Image = Image.FromStream(ms);
                }    
                panel7.Controls.Add(rdv);
                
            }

            C.cn.Close();

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = false;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = true;
            pnlHome.Visible = false;
            pnlProfil.Visible = false;
            pnlHome.Visible = true;
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            gunaCirclePictureBox4.Visible = true;
            //gunaCirclePictureBox3.Visible = false;
            gunaCirclePictureBox2.Visible = false;
            pnlProfil.Visible = true;
            pnlHome.Visible = false;
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

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into RDV values('"+ gunaDateTimePicker1.Value + "', '"+ gunaTextBox1.Text.ToString()+ "' , '"+ richTextBox1.Text.ToString() + "', '"+C.user1.Mail+"', '"+ gunaComboBox1.SelectedValue + "', '"+ gunaComboBox2.SelectedItem.ToString() + "')", C.cn);
            C.cn.Open();
            command.ExecuteNonQuery();
            C.cn.Close();
            gunaLabel30.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gunaLabel30.Visible == true)
                gunaLabel30.Visible = false;
        }

        private void gunaTextBox1_Enter(object sender, EventArgs e)
        {
            gunaTextBox1.ForeColor = Color.Black;
            if (gunaTextBox1.Text == "heure:minutes")
                gunaTextBox1.Text = "";
        }

        private void gunaTextBox1_Leave(object sender, EventArgs e)
        {
            if (gunaTextBox1.Text == "")
            {
                gunaTextBox1.Text = "heure:minutes";
                gunaTextBox1.ForeColor = Color.DarkGray;
            }
        }

        private void gunaTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());
            if ((char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false) )
            {                
                e.Handled = true;
            }
        }

    }
}
