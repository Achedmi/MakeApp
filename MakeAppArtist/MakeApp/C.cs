using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MakeApp
{
    class C
    {
        public static SqlConnection cn = new SqlConnection("Data Source=.;Initial Catalog=MakeApp;Integrated Security=True");

        public static Users user1 = new Users();

        public static FrmArtiste frmAr = new FrmArtiste();
        public static FrmClient FrmClient = new FrmClient();
        public static SqlDataAdapter DA = new SqlDataAdapter();
    }

    class Users
    {

        public string Prenom, Nom, Mail, Mot_de_pass;        
        public Int32 NumTel;
        public int Type;

        public void setdata(string prenom, string nom, string mail, int numtel, string mot_de_pass, int type)
        {            
            this.Prenom = prenom;
            this.Nom = nom;
            this.Mail = mail;
            this.Mot_de_pass = mot_de_pass;            
            this.NumTel = numtel;
            this.Type = type;
        }

    }

}
