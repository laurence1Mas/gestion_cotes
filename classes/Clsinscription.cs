using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clsinscription
    {
        string codeinscription;
        string refetudiant;
        string refpromotion;
        DateTime date_inscription;
        string refannee;

        public string Codeinscription
        {
            get
            {
                return codeinscription;
            }

            set
            {
                codeinscription = value;
            }
        }

        public string Refetudiant
        {
            get
            {
                return refetudiant;
            }

            set
            {
                refetudiant = value;
            }
        }

        public string Refpromotion
        {
            get
            {
                return refpromotion;
            }

            set
            {
                refpromotion = value;
            }
        }

        public string Refannee
        {
            get
            {
                return refannee;
            }

            set
            {
                refannee = value;
            }
        }
        public DateTime Date_inscription
        {
            get
            {
                return date_inscription;
            }

            set
            {
                date_inscription = value;
            }
        }

        SqlConnection con;

        //==================METHODE POUR FAIRE L'AJOUT DES DONNEES===========
        public int Ajouterinscription(Clsinscription clsins)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_inscription @refetudiant,@refpromotion,@refannee,@date_inscription;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prrefetudiant = new SqlParameter("@refetudiant", clsins.refetudiant);
                SqlParameter prrefpromotion = new SqlParameter("@refpromotion", clsins.refpromotion);
                SqlParameter prrefannee = new SqlParameter("@refannee", clsins.refannee);
                SqlParameter prdateinscription = new SqlParameter("@date_inscription", clsins.date_inscription);
                cmd.Parameters.Add(prrefetudiant);
                cmd.Parameters.Add(prrefpromotion);
                cmd.Parameters.Add(prrefannee);
                cmd.Parameters.Add(prdateinscription);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        //=======================METHODE POUR FAIRE LA MODIFICATION===========
        public int Modifierinscription(Clsinscription clsins)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if(con != null)
            {
                string strquery = "exec update_inscription @codeinscription,@refetudiant,@refpromotion,@dateinscription,refannee ;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeinscription = new SqlParameter("@codeinscription", clsins.codeinscription);
                SqlParameter prrefetudiant = new SqlParameter("@refetudiant", clsins.refetudiant);
                SqlParameter prrefpromotion = new SqlParameter("@refpromotion", clsins.refpromotion);
                SqlParameter prdateinscription = new SqlParameter("@dateinscription", clsins.date_inscription);
                SqlParameter prrefannee = new SqlParameter("@refannee", clsins.refannee);
                cmd.Parameters.Add(prcodeinscription);
                cmd.Parameters.Add(prrefetudiant);
                cmd.Parameters.Add(prrefpromotion);
                cmd.Parameters.Add(prdateinscription);
                cmd.Parameters.Add(prrefannee);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }
        }

        //=================MAETHODE POUR FAIRE LA SUPPRESSION============
        public int supprimerInscription(Clsinscription clsins)
        {
            int value = 0;
            string strquery = " exec delete_inscription @codeinscription";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeinscription = new SqlParameter("@codeinscription", clsins.codeinscription);
                cmd.Parameters.Add(prcodeinscription);
                value = cmd.ExecuteNonQuery();
            }
            return value;
        }
    //============================METHODE POUR LA RECUPERATION DES DONNES DANS BD=============
        public List<Clsinscription> getInscription()
        {
            List<Clsinscription> list = new List<Clsinscription>();
            con = new connexion().DBConnect();
            string strquery = "select * from Vinscription";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clsinscription clsinsc = new Clsinscription();
                clsinsc.codeinscription = dr["codeinscription"].ToString();
                clsinsc.refetudiant = dr["refetudiant"].ToString();
                clsinsc.refpromotion = dr["refpromotion"].ToString();
                clsinsc.date_inscription = Convert.ToDateTime(dr["date_inscription"]);
                clsinsc.refannee = dr["refannee"].ToString();
                list.Add(clsinsc);
            }
            return list;
        }
    }
}
