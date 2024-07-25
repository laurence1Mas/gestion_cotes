using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class clsetudiants
    {
        string codeetudiant;
        string noms;

        public string Codeetudiant
        {
            get
            {
                return codeetudiant;
            }

            set
            {
                codeetudiant = value;
            }
        }

        public string Noms
        {
            get
            {
                return noms;
            }

            set
            {
                noms = value;
            }
        }
        SqlConnection con;
        public List<clsetudiants> getlistetudiant()
        {
            List<clsetudiants> list = new List<clsetudiants>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vetudiant";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsetudiants clse = new clsetudiants();
                clse.codeetudiant = dr["codeetudiant"].ToString();
                clse.noms = dr["noms"].ToString();
                list.Add(clse);
            }
            return list;
        }
    }
}
