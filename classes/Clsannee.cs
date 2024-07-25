using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clsannee
    {
        string codeannee;
        string designation;

        public string Codeannee
        {
            get
            {
                return codeannee;
            }

            set
            {
                codeannee = value;
            }
        }

        public string Designation
        {
            get
            {
                return designation;
            }

            set
            {
                designation = value;
            }
        }
        SqlConnection con;

        public int Ajouterannee(Clsannee clsan)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_annee @designation ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prdesignation = new SqlParameter("@designation", clsan.designation);
                cmd.Parameters.Add(prdesignation);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        //==============================================
        public int Modifierannee(Clsannee clsa)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_annee @codeannee, @desigantion;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeannee = new SqlParameter("@codeannee", clsa.codeannee);
                SqlParameter prdesignation = new SqlParameter("@desigantion", clsa.designation);
                cmd.Parameters.Add(prcodeannee);
                cmd.Parameters.Add(prdesignation);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }

        }
        //=====================================================DELETE ================================================
        public int supprimerannee(Clsannee clsa)
        {
            int value = 0;
            string strquery = " exec delete_annee @codeannee";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeannee = new SqlParameter("@codeannee", clsa.codeannee);
                cmd.Parameters.Add(prcodeannee);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<Clsannee> getannee()
        {
            List<Clsannee> list = new List<Clsannee>();
            con = new connexion().DBConnect();
            string strquery = "exec afficher_annee";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clsannee clsa = new Clsannee();
                clsa.codeannee =dr["codeannee"].ToString();
                clsa.designation = dr["designation"].ToString();
                list.Add(clsa);
            }
            return list;
        }
    }
}
