using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace MakeApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(txtemail_p1.Text) == false)
            {                
                MessageBox.Show("la form de l'adresse Email est incorrect");
                return;
            }


            //notif de mot de passe
            if (txtpaas_p1.Text == "Mot de passe" && txtpaas_p1.UseSystemPasswordChar == false)
            {
                MessageBox.Show("la form de l'adresse Email est incorrect");
                return;
            }


            //Login_process
            
            C.cn.Open();
            SqlCommand cmd = new SqlCommand("select * from Account where Mail = @a and Pass = @b", C.cn);

            cmd.Parameters.AddWithValue("@a", txtemail_p1.Text);
            cmd.Parameters.AddWithValue("@b", txtpaas_p1.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                if (dr[2].ToString() == txtemail_p1.Text && dr[4].ToString() == txtpaas_p1.Text)
                {


                    C.user1.setdata(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), Convert.ToInt32(dr[3].ToString()), dr[4].ToString(), Convert.ToInt16(dr[6].ToString()));
                    if (C.user1.Type == 1) //Type = [0, 1, 2] // 0 = Admin; 1 = Artiste; 2 = Client;
                        C.frmAr.Show();
                    else if (C.user1.Type == 2)
                        C.FrmClient.Show();

                    C.cn.Close();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Introuvable");
            C.cn.Close();
        }

        private void txtpaas_p1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                btnConnexion.PerformClick();
        }
    }
}
