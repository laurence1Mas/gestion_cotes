using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class clsCotation
    {
        string codecotation;
        string refinscription;
        string refcours;
        decimal tp;
        int maxtp;
        decimal td;
        int maxtd;
        decimal exam;
        int maxexam;
        decimal total;
        int totaux;

        public string Codecotation
        {
            get
            {
                return codecotation;
            }

            set
            {
                codecotation = value;
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

        public string Refcours
        {
            get
            {
                return refcours;
            }

            set
            {
                refcours = value;
            }
        }

        public decimal Tp
        {
            get
            {
                return tp;
            }

            set
            {
                tp = value;
            }
        }

        public int Maxtp
        {
            get
            {
                return maxtp;
            }

            set
            {
                maxtp = value;
            }
        }

        public decimal Td
        {
            get
            {
                return td;
            }

            set
            {
                td = value;
            }
        }

        public int Maxtd
        {
            get
            {
                return maxtd;
            }

            set
            {
                maxtd = value;
            }
        }

        public decimal Exam
        {
            get
            {
                return exam;
            }

            set
            {
                exam = value;
            }
        }

        public int Maxexam
        {
            get
            {
                return maxexam;
            }

            set
            {
                maxexam = value;
            }
        }

        public decimal Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public int Totaux
        {
            get
            {
                return totaux;
            }

            set
            {
                totaux = value;
            }
        }

        SqlConnection con;

        public int Ajoutercotation(clsCotation clsco)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec sp_insert_cotation @refinscription,@refcours,@TP,@MAXTP,@TD,@MAXTD,@EXAM,@MAXEXAM;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefinscription = new SqlParameter("@refinscription", clsco.refinscription);
                SqlParameter prrefcours = new SqlParameter("@refcours", clsco.refcours);
                SqlParameter prtp = new SqlParameter("@TP", clsco.tp);
                SqlParameter prmaxtp = new SqlParameter("@MAXTP", clsco.maxtp);
                SqlParameter prtd = new SqlParameter("@TD", clsco.td);
                SqlParameter prmaxtd = new SqlParameter("@MAXTD", clsco.maxtd);
                SqlParameter prexame = new SqlParameter("@EXAM", clsco.exam);
                SqlParameter prmaxexame = new SqlParameter("@MAXEXAM", clsco.maxexam);
                cmd.Parameters.Add(prrefinscription);
                cmd.Parameters.Add(prrefcours);
                cmd.Parameters.Add(prtp);
                cmd.Parameters.Add(prmaxtp);
                cmd.Parameters.Add(prtd);
                cmd.Parameters.Add(prmaxtd);
                cmd.Parameters.Add(prexame);
                cmd.Parameters.Add(prmaxexame);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public int Modifiercotation(clsCotation clsco)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec sp_update_cotation @codecaotation,@refinscription,@refcours,@TP,@MAXTP,@TD,@MAXTD,@EXAM,@MAXEXAM;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodecotation = new SqlParameter("@codecaotation", clsco.codecotation);
                SqlParameter prrefinscription = new SqlParameter("@refinscription", clsco.refinscription);
                SqlParameter prrefcours = new SqlParameter("@refcours", clsco.refcours);
                SqlParameter prtp = new SqlParameter("@TP", clsco.tp);
                SqlParameter prmaxtp = new SqlParameter("@MAXTP", clsco.maxtp);
                SqlParameter prtd = new SqlParameter("@TD", clsco.td);
                SqlParameter prmaxtd = new SqlParameter("@MAXTD", clsco.maxtd);
                SqlParameter prexame = new SqlParameter("@EXAM", clsco.exam);
                SqlParameter prmaxexame = new SqlParameter("@MAXEXAM", clsco.maxexam);
                cmd.Parameters.Add(prcodecotation);
                cmd.Parameters.Add(prrefinscription);
                cmd.Parameters.Add(prrefcours);
                cmd.Parameters.Add(prtp);
                cmd.Parameters.Add(prmaxtp);
                cmd.Parameters.Add(prtd);
                cmd.Parameters.Add(prmaxtd);
                cmd.Parameters.Add(prexame);
                cmd.Parameters.Add(prmaxexame);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public List<clsCotation> getcotation()
        {
            List<clsCotation> list = new List<clsCotation>();
            con = new connexion().DBConnect();
            string strquery = "select * from VcotationLmd";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsCotation clsco = new clsCotation();
                clsco.codecotation =dr["codecotation"].ToString();
                clsco.refinscription = dr["etudiant"].ToString();
                clsco.refcours = dr["UE"].ToString();
                clsco.tp = Convert.ToDecimal(dr["TP"]);
                clsco.maxtp = Convert.ToInt32(dr["MAXTP"]);
                clsco.td = Convert.ToDecimal(dr["TD"]);
                clsco.Maxtd = Convert.ToInt32(dr["MAXTD"]);
                clsco.exam = Convert.ToDecimal(dr["EXAM"]);
                clsco.maxexam = Convert.ToInt32(dr["MAXEXAM"]);
                clsco.total = Convert.ToDecimal(dr["total"]);
                clsco.totaux = Convert.ToInt32(dr["totaux"]);
                list.Add(clsco);
            }
            return list;
        }
    }
}
