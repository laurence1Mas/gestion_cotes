using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class ClsCours
    {
        string codecours;
        Char categorie;
        string code;
        string designation;
        string ue;
        int cm;
        int tp;
        int td;
        int maximum;
        string refenseignant;
        string semestre;
        int credit;

        public string Codecours
        {
            get
            {
                return codecours;
            }

            set
            {
                codecours = value;
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

        public string Refenseignant
        {
            get
            {
                return refenseignant;
            }

            set
            {
                refenseignant = value;
            }
        }

        public char Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        public string Ue
        {
            get
            {
                return ue;
            }

            set
            {
                ue = value;
            }
        }

        public int Cm
        {
            get
            {
                return cm;
            }

            set
            {
                cm = value;
            }
        }

        public int Tp
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

        public int Td
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

        public int Maximum
        {
            get
            {
                return maximum;
            }

            set
            {
                maximum = value;
            }
        }

        public string Semestre
        {
            get
            {
                return semestre;
            }

            set
            {
                semestre = value;
            }
        }

        public int Credit
        {
            get
            {
                return credit;
            }

            set
            {
                credit = value;
            }
        }

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        SqlConnection con;
        public int Ajoutecours(ClsCours clsc)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec sp_insert_cours @categorie,@code,@designation,@UE,@CM,@TP,@TD,@maximam,@refenseignant,@semestre;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcategorie = new SqlParameter("@categorie", clsc.categorie);
                SqlParameter prcode = new SqlParameter("@code", clsc.code);
                SqlParameter prdesignation = new SqlParameter("@designation", clsc.designation);
                SqlParameter prue = new SqlParameter("@UE", clsc.ue);
                SqlParameter prcm = new SqlParameter("@CM", clsc.cm);
                SqlParameter prtp = new SqlParameter("@TP", clsc.tp);
                SqlParameter prtd = new SqlParameter("@TD", clsc.td);
                SqlParameter prmaximamun = new SqlParameter("@maximam", clsc.maximum);
                SqlParameter prrefenseignant = new SqlParameter("@refenseignant", clsc.refenseignant);
                SqlParameter prsemestre = new SqlParameter("@semestre", clsc.semestre);
                cmd.Parameters.Add(prcategorie);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prue);
                cmd.Parameters.Add(prcm);
                cmd.Parameters.Add(prtp);
                cmd.Parameters.Add(prtd);
                cmd.Parameters.Add(prmaximamun);
                cmd.Parameters.Add(prrefenseignant);
                cmd.Parameters.Add(prsemestre);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        public int Modifiercours(ClsCours clsc)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec sp_update_cours @codeCours,@categorie,@code,@designation,@UE,@CM,@TP,@TD,@maximam,@refenseignant,@semestre;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcategorie = new SqlParameter("@categorie", clsc.categorie);
                SqlParameter prcode = new SqlParameter("@code", clsc.code);
                SqlParameter prdesignation = new SqlParameter("@designation", clsc.designation);
                SqlParameter prue = new SqlParameter("@UE", clsc.ue);
                SqlParameter prcm = new SqlParameter("@CM", clsc.cm);
                SqlParameter prtp = new SqlParameter("@TP", clsc.tp);
                SqlParameter prtd = new SqlParameter("@TD", clsc.td);
                SqlParameter prmaximamun = new SqlParameter("@maximam", clsc.maximum);
                SqlParameter prrefenseignant = new SqlParameter("@refenseignant", clsc.refenseignant);
                SqlParameter prsemestre = new SqlParameter("@semestre", clsc.semestre);
                SqlParameter prcodecours = new SqlParameter("@codeCours", clsc.codecours);
                cmd.Parameters.Add(prcategorie);
                cmd.Parameters.Add(prcode);
                cmd.Parameters.Add(prdesignation);
                cmd.Parameters.Add(prue);
                cmd.Parameters.Add(prcm);
                cmd.Parameters.Add(prtp);
                cmd.Parameters.Add(prtd);
                cmd.Parameters.Add(prmaximamun);
                cmd.Parameters.Add(prrefenseignant);
                cmd.Parameters.Add(prsemestre);
                cmd.Parameters.Add(prcodecours);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        public List<ClsCours> getcours()
        {
            List<ClsCours> list = new List<ClsCours>();
            con = new connexion().DBConnect();
            string strquery = "select * from VcoursLmd";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ClsCours clsc = new ClsCours();
                clsc.codecours = dr["codeCours"].ToString();
                clsc.categorie =Convert.ToChar( dr["categorie"]);
                clsc.code = dr["code"].ToString();
                clsc.designation = dr["designation"].ToString();
                clsc.ue = dr["UE"].ToString();
                clsc.cm = Convert.ToInt32(dr["CM"]);
                clsc.tp = Convert.ToInt32(dr["TP"]);
                clsc.td = Convert.ToInt32(dr["TD"]);
                clsc.maximum = Convert.ToInt32(dr["maximam"]);
                clsc.credit = Convert.ToInt32(dr["credit"]);
                clsc.Refenseignant = dr["enseignant"].ToString();
                clsc.semestre = dr["semestre"].ToString();
                list.Add(clsc);
            }
            return list;
        }
    }
}
