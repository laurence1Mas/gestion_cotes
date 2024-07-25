using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_cotes.classes
{
    class Clsetudiant
    {
        string codeetudiant;
        string nom;
        string postnom;
        string prenom;
        string genre;
        string etat_civil;
        string lieu_naissance;
        string date_naissance;
        string adresse;
        string numero;
        string mail;

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

        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Postnom
        {
            get
            {
                return postnom;
            }

            set
            {
                postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
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

        public string Lieu_naissance
        {
            get
            {
                return lieu_naissance;
            }

            set
            {
                lieu_naissance = value;
            }
        }

        public string Date_naissance
        {
            get
            {
                return date_naissance;
            }

            set
            {
                date_naissance = value;
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
        public int Ajouteretudiant(Clsetudiant clse)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                string strquery = "exec insert_etudiant @nom,@postnom,@prenom,@genre,@etat_civil,@lieu_naissance,@date_naissance,@adresse,@numero,@mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prnom = new SqlParameter("@nom", clse.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clse.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clse.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clse.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clse.etat_civil);
                SqlParameter prlieu_naissance = new SqlParameter("@lieu_naissance", clse.lieu_naissance);
                SqlParameter prdate_naissance = new SqlParameter("@date_naissance", clse.date_naissance);
                SqlParameter pradresse = new SqlParameter("@adresse", clse.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clse.numero);
                SqlParameter prmail = new SqlParameter("@mail", clse.mail);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(prlieu_naissance);
                cmd.Parameters.Add(prdate_naissance);
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
        public int Modifieretudiant(Clsetudiant clse)
        {
            int value = 0;
            con = new connexion().DBConnect();
            if (con != null)
            {
                // string strquery1 = "insert into Client(codeclient,noms,telephone,mail,adresse) values(@codeclient,@noms,@telephone,@mail,@adresse)";
                string strquery = "exec Update_etudiant @codeetudiant, @nom,@postnom,@prenom,@genre,@etat_civil,@lieu_naissance,@date_naissance,@adresse,@numero,@mail;";

                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeetudiant = new SqlParameter("@codeetudiant", clse.codeetudiant);
                SqlParameter prnom = new SqlParameter("@nom", clse.nom);
                SqlParameter prpostnom = new SqlParameter("@postnom", clse.postnom);
                SqlParameter prprenom = new SqlParameter("@prenom", clse.prenom);
                SqlParameter prgenre = new SqlParameter("@genre", clse.genre);
                SqlParameter pretat = new SqlParameter("@etat_civil", clse.etat_civil);
                SqlParameter prlieu_naissance = new SqlParameter("@lieu_naissance", clse.lieu_naissance);
                SqlParameter prdate_naissance = new SqlParameter("@date_naissance", clse.date_naissance);
                SqlParameter pradresse = new SqlParameter("@adresse", clse.adresse);
                SqlParameter prnumero = new SqlParameter("@numero", clse.numero);
                SqlParameter prmail = new SqlParameter("@mail", clse.mail);
                cmd.Parameters.Add(prcodeetudiant);
                cmd.Parameters.Add(prnom);
                cmd.Parameters.Add(prpostnom);
                cmd.Parameters.Add(prprenom);
                cmd.Parameters.Add(prgenre);
                cmd.Parameters.Add(pretat);
                cmd.Parameters.Add(prlieu_naissance);
                cmd.Parameters.Add(prdate_naissance);
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
        public int supprimeretudiant(Clsetudiant clse)
        {
            int value = 0;
            string strquery = " exec delete_etudiant @codeetudiant";
            con = new connexion().DBConnect();
            if (con != null)
            {
                SqlCommand cmd = new SqlCommand(strquery, con);
                SqlParameter prcodeetudiant = new SqlParameter("@codeetudiant", clse.codeetudiant);
                cmd.Parameters.Add(prcodeetudiant);
                value = cmd.ExecuteNonQuery();
            }
            return value;

        }

        public List<Clsetudiant> getetudiant()
        {
            List<Clsetudiant> list = new List<Clsetudiant>();
            con = new connexion().DBConnect();
            string strquery = "exec affiche_etudiant ";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Clsetudiant clse = new Clsetudiant();
                clse.codeetudiant = dr["codeetudiant"].ToString();
                clse.nom = dr["nom"].ToString();
                clse.postnom = dr["postnom"].ToString();
                clse.prenom = dr["prenom"].ToString();
                clse.genre = dr["genre"].ToString();
                clse.etat_civil = dr["etat_civil"].ToString();
                clse.lieu_naissance = dr["lieu_naissance"].ToString();
                clse.date_naissance = dr["date_naissance"].ToString();
                clse.adresse = dr["Adresse"].ToString();
                clse.numero = dr["telephone"].ToString();
                clse.mail = dr["mail"].ToString();
                list.Add(clse);
            }
            return list;
        }
    }
}
