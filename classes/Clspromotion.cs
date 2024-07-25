using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clspromotion
    {
        string codepromotion;
        string designation;
        string refoption;

        public string Codepromotion
        {
            get
            {
                return codepromotion;
            }

            set
            {
                codepromotion = value;
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

        public string Refoption
        {
            get
            {
                return refoption;
            }

            set
            {
                refoption = value;
            }
        }

        SqlConnection con;

        //======================METHODE D'AJOUT DES DONNEES====================
        public int Ajouterpromotion(Clspromotion clspro)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_promotion @designation,@refoption ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prdesignation = new SqlParameter("@designation", clspro.designation);
                SqlParameter prrefoption = new SqlParameter("@refoption",clspro.refoption);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prrefoption);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        //============================================== MODIFICATION
        public int Modifierpromotion(Clspromotion clspro)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_promotion @codepromotion, @desigantion,@refoption;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodepromotion = new SqlParameter("@codepromotion", clspro.codepromotion);
                SqlParameter prdesignation = new SqlParameter("@desigantion", clspro.designation);
                SqlParameter prrefoption = new SqlParameter("@refoption", clspro.refoption);
                cmd.Parameters.Add(prcodepromotion);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prrefoption);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }

        }
        //=====================================================DELETE ================================================
        public int supprimerpromotion(Clspromotion clspro)
        {
            int value = 0;
            string strquery = " exec delete_promotion @codepromotion";
            con = new connexion().DBConnect();
            if (con != null)
            { 
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodepromotion = new SqlParameter("@codepromotion", clspro.codepromotion);
                cmd.Parameters.Add(prcodepromotion);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
        //==================== RECUPERATION DES DONNES===============
        public List<Clspromotion> getPromotion()
        {
            List<Clspromotion> list = new List<Clspromotion>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vpromotion";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clspromotion clsp = new Clspromotion();
                clsp.codepromotion = dr["codepromotion"].ToString();
                clsp.designation = dr["designation"].ToString();
                clsp.refoption = dr["options"].ToString();
                list.Add(clsp);
            }
            return list;
        }
    }
}
