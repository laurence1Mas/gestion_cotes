using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clsoptions
    {
        string codeoption;
        string designation;

        public string Codeoption
        {
            get
            {
                return codeoption;
            }

            set
            {
                codeoption = value;
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

        public int Ajouteroption(Clsoptions clsop)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_option @designation ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prdesignation = new SqlParameter("@designation", clsop.designation);
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
        public int Modifieroption(Clsoptions clsop)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_option @codeoption, @desigantion;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeoption = new SqlParameter("@codeoption", clsop.codeoption);
                SqlParameter prdesignation = new SqlParameter("@desigantion", clsop.designation);
                cmd.Parameters.Add(prcodeoption);
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
        public int supprimeroption(Clsoptions clsop)
        {
            int value = 0;
            string strquery = " exec delete_option @codeoption";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeoption = new SqlParameter("@codeoption", clsop.codeoption);
                cmd.Parameters.Add(prcodeoption);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<Clsoptions> getoption()
        {
            List<Clsoptions> list = new List<Clsoptions>();
            con = new connexion().DBConnect();
            string strquery = "exec afficher_options";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clsoptions clsop = new Clsoptions();
                clsop.codeoption = dr["codeoption"].ToString();
                clsop.designation = dr["designation"].ToString();
                list.Add(clsop);
            }
            return list;
        }
    }
}
