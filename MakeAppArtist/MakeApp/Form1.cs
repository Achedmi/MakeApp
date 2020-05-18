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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert Account values(null, null, '"+gunaTextBox1.Text.ToString()+"', null ,'"+ gunaTextBox2.Text.ToString() + "', null, '1')");
            C.cn.Open();
            cmd.ExecuteNonQuery();
            C.cn.Close();
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Account set Mail = '"+ gunaTextBox7.Text.ToString() + "' , pass = '"+ gunaTextBox5.Text.ToString() + "' where mail = '" + gunaTextBox6.Text.ToString() + "'");
            C.cn.Open();
            cmd.ExecuteNonQuery();
            C.cn.Close();
        }

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("delete from Account where Mail = '"+ gunaTextBox4 .Text.ToString()+ "'");
            C.cn.Open();
            cmd.ExecuteNonQuery();
            C.cn.Close();
        }
    }
}
