using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class ClsPayement
    {
        string codepayement;
        string refinscription;
        decimal montantp;
        DateTime datepayement;

        public string Codepayement
        {
            get
            {
                return codepayement;
            }

            set
            {
                codepayement = value;
            }
        }

        public string Refinscription
        {
            get
            {
                return refinscription;
            }

            set
            {
                refinscription = value;
            }
        }

        public decimal Montantp
        {
            get
            {
                return montantp;
            }

            set
            {
                montantp = value;
            }
        }

        public DateTime Datepayement
        {
            get
            {
                return datepayement;
            }

            set
            {
                datepayement = value;
            }
        }

        SqlConnection con;
        public int Ajoutepayement(ClsPayement clsPay)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_payement @refinscription,@montantp,@datepayement;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefinscription = new SqlParameter("@refinscription", clsPay.refinscription);
                SqlParameter prmontant = new SqlParameter("@montantp", clsPay.montantp);
                SqlParameter prdatepayement = new SqlParameter("@datepayement", clsPay.datepayement);
                cmd.Parameters.Add(prrefinscription);
                cmd.Parameters.Add(prmontant);
                cmd.Parameters.Add(prdatepayement);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int Modifierpayement(ClsPayement clsPay)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec update_payement @refinscription,@montantp,@datepayement,@codepayement;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefinscription = new SqlParameter("@refinscription", clsPay.refinscription);
                SqlParameter prmontant = new SqlParameter("@montantp", clsPay.montantp);
                SqlParameter prdatepayement = new SqlParameter("@datepayement", clsPay.datepayement);
                SqlParameter prcodepayement = new SqlParameter("@codepayement", clsPay.codepayement);
                cmd.Parameters.Add(prcodepayement);
                cmd.Parameters.Add(prrefinscription);
                cmd.Parameters.Add(prmontant);
                cmd.Parameters.Add(prdatepayement);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }
  
        public List<ClsPayement> getpayement()
        {
            List<ClsPayement> list = new List<ClsPayement>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vpayement";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ClsPayement clsPay = new ClsPayement();
                clsPay.codepayement = dr["codepayement"].ToString();
                clsPay.refinscription = dr["refetudiant"].ToString();
                clsPay.montantp = Convert.ToDecimal(dr["montantp"]);
                clsPay.datepayement = Convert.ToDateTime(dr["date_payement"]);
                list.Add(clsPay);
            }
            return list;
        }
    }
}
