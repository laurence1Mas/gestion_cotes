using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clsenseignant
    {
        string codeenseignant;
        string noms;
        string genre;
        string etat_civil;
        string adresse;
        string numero;
        string mail;

        public string Codeenseignant
        {
            get
            {
                return codeenseignant;
            }

            set
            {
                codeenseignant = value;
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

        public string Genre
        {
            get
            {
                return genre;
            }

            set
            {
                genre = value;
            }
        }

        public string Etat_civil
        {
            get
            {
                return etat_civil;
            }

            set
            {
                etat_civil = value;
            }
        }

        public string Adresse
        {
            get
            {
                return adresse;
            }

            set
            {
                adresse = value;
            }
        }

        public string Numero
        {
            get
            {
                return numero;
            }

            set
            {
                numero = value;
            }
        }

        public string Mail
        {
            get
            {
                return mail;
            }

            set
            {
                mail = value;
            }
        }

        SqlConnection con;
        public int Ajouteenseigant(Clsenseignant clsens)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_enseignant @noms,@genre,@etat_civil,@adresse,@numero,@mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@noms", clsens.noms);
                SqlParameter prgenre = new SqlParameter("@genre", clsens.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsens.etat_civil);
                SqlParameter pradresse = new SqlParameter("@adresse", clsens.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsens.numero);
                SqlParameter prmail = new SqlParameter("@mail", clsens.mail);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                cmd.Parameters.Add(prmail);
                value = cmd.ExecuteNonQuery();

                return value;
            }
            else
            {
                return value;
            }

        }

        //==============================================
        public int Modifierenseignant(Clsenseignant clsens)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec Update_enseignant @codeenseignant, @noms,@genre,@etat_civil,@adresse,@numero,@mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeenseignant = new SqlParameter("@codeenseignant",clsens.codeenseignant);
                SqlParameter prnom = new SqlParameter("@noms", clsens.noms);
                SqlParameter prgenre = new SqlParameter("@genre", clsens.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clsens.etat_civil);
                SqlParameter pradresse = new SqlParameter("@adresse", clsens.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clsens.numero);
                SqlParameter prmail = new SqlParameter("@adresse", clsens.mail);
                cmd.Parameters.Add(prcodeenseignant);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(pradresse);
                cmd.Parameters.Add(prnumero);
                cmd.Parameters.Add(prmail);
                value = cmd.ExecuteNonQuery();
                return value;
            }
            else
            {
                return value;
            }

        }
        //=====================================================DELETE ================================================
        public int supprimerenseigant(Clsenseignant clsens)
        {
            int value = 0;
            string strquery = " exec delete_enseignant @codeenseignant";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeenseignant = new SqlParameter("@codeenseignant", clsens.codeenseignant);
                cmd.Parameters.Add(prcodeenseignant);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<Clsenseignant> getenseignant()
        {
            List<Clsenseignant> list = new List<Clsenseignant>();
            con = new connexion().DBConnect();
            string strquery = "exec affiche_enseignant";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clsenseignant clsens = new Clsenseignant();
                clsens.codeenseignant = dr["codeenseignant"].ToString();
                clsens.noms = dr["noms"].ToString();
                clsens.genre = dr["genre"].ToString();
                clsens.etat_civil = dr["etat_civil"].ToString();
                clsens.adresse = dr["Adresse"].ToString();
                clsens.numero = dr["telephone"].ToString();
                clsens.mail = dr["mail"].ToString();
                list.Add(clsens);
            }
            return list;
        }
    }
}
