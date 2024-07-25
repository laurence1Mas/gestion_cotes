using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class clspromotions
    {
        string codepromotion;
        string promotion;

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

        public string Promotion
        {
            get
            {
                return promotion;
            }

            set
            {
                promotion = value;
            }
        }
        SqlConnection con;

        public List<clspromotions> getPromotion()
        {
            List<clspromotions> list = new List<clspromotions>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vpromotions";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clspromotions clsp = new clspromotions();
                clsp.codepromotion = dr["codepromotion"].ToString();
                clsp.promotion = dr["promotion"].ToString();
                list.Add(clsp);
            }
            return list;
        }
    }
}
