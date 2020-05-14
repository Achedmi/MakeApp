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

namespace MakeApp
{
    public partial class RDV : UserControl
    {
        public RDV()
        {
            InitializeComponent();
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

            if (BtnPrendre.Text == "Prendre")
                cmd = new SqlCommand("insert choisie values (@a,@b,0,0)", C.cn);
            else
                cmd = new SqlCommand("delete from choisie where idrdv = @a and mailartist = @b", C.cn);

            cmd.Parameters.Add("@a", label1.Text);
            cmd.Parameters.Add("@b", C.user1.Mail);

            cmd.ExecuteNonQuery();

            BtnPrendre.Text = BtnPrendre.Text == "Prendre" ? "Annuler" : "Prendre";
            C.cn.Close();            

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
