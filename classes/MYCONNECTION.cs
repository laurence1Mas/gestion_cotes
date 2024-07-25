using DevExpress.Charts.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_cotes.classes
{
    class MYCONNECTION
    {
        public String ErrorProviser()
        {
            return "Ce champs ne doit pas etre vide";
        }
        public void APPEL_PANEL(UserControl s, Panel pan)
        {

            s.Dock = DockStyle.Fill;
            pan.Controls.Clear();
            pan.Controls.Add(s);
            pan.Show();

        }

        public string imgLon = "";
        public static string cons = @"Data Source=DESKTOP-HTI1CR5;Initial Catalog=db_gestion_cote_soft;User ID=SA;Password=laure";
        public static SqlConnection con = new SqlConnection("" + cons);
        public static SqlCommand cmd = new SqlCommand("", con);

        SqlDataReader dr;
        public static SqlDataAdapter dt = null;

        public static DataSet ds = new DataSet();


        public DataSet get_Report_Z()
        {
            Console.WriteLine("SELECT * from VcoursLmd ");
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * from VcoursLmd  ", con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, "VcoursLmd");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        //=========================METHODE D'IMPRESSION DE LA LISTE DES ETUDIANTS===================
        public DataSet get_Report_Z2()
        {
            Console.WriteLine("SELECT * from etudiant ");
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * from etudiant  ", con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, "etudiant");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        //=========================METHODE D'IMPRESSION DE LA LISTE DES ENSEIGNANTS===================
        public DataSet get_Report_ens()
        {
            Console.WriteLine("SELECT * from enseignant ");
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * from enseignant  ", con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, "enseignant");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        public DataSet get_Report_S(string nomTable, string idTable)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM " + nomTable + " ORDER BY " + idTable + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        //=========================METHODE D'IMPRESSION DE LA CARTE D'ETUDIANT===================
        public DataSet get_Report_carte(string nomTable, string idTable,string value)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("SELECT * FROM Vinscription WHERE codeinscription =@code", con);
                cmd.Parameters.AddWithValue("@code", value);
                //cmd = new SqlCommand("SELECT * FROM " + nomTable + " where " + idTable + " = " + value + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
        //=========================METHODE D'IMPRESSION DU RECU===================
        public DataSet get_Report_recu(string nomTable, string idTable, string value)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select * from Vrecupayement WHERE codepayement =@code", con);
                cmd.Parameters.AddWithValue("@code", value);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        public DataSet get_Report_relever(string nomTable, string idTable, string value)
        {
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                cmd = new SqlCommand("select * from relevercote WHERE etudiant=@etudiant", con);
                cmd.Parameters.AddWithValue("@etudiant", value);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        public void CHOISIR_IMAGE(PictureBox picture)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|GIF Files(*.gif)|*.gif|All Files(*.*)|*.*";
            dlg.Title = "Selectionner une image";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLon = dlg.FileName.ToString();
                picture.ImageLocation = imgLon;
            }
        }
        public void chargementCombo(ComboBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void chargementlIST(ListBox cmb, string rqt)
        {
            cmb.Items.Clear();

            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmb.Items.Add(dr[0].ToString());
                }
                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public String VALOR_OF(String rqt)
        {
            string caleur = "";
            try
            {
                con.Open();
                cmd.CommandText = rqt;
                dr = cmd.ExecuteReader();

                caleur = dr[0].ToString();

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return caleur;
        }

        public void chargementTableau(DataGridView dg, string rqt)
        {
            Console.WriteLine(rqt);
            con.Open();
            try
            {

                cmd = con.CreateCommand();
                SqlDataAdapter da = new SqlDataAdapter(rqt, con);
                DataSet ds = new DataSet();
                da.Fill(ds, "ETUDIANT");
                dg.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();

        }


        public void EXEC_UNIVERSEL(String proc, string parametre, string message)
        {
            Console.WriteLine("EXEC " + proc + " " + parametre);
            con.Open();
            try
            {

                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }

        public void EXEC_UNIVERSEL_picture(String proc, string parametre, string message)
        {
            con.Open();
            try
            {
                byte[] img = null;

                cmd.Parameters.Clear();
                FileStream fs = new FileStream(imgLon, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                cmd.CommandText = "EXEC " + proc + " " + parametre;
                cmd.Parameters.Add(new SqlParameter("@IMAGE", img));
                cmd.ExecuteNonQuery();
                MessageBox.Show("" + message, "Reussite", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();

        }




        

      


        public void GET_PHOTO(string RQT, PictureBox picemp, int row)
        {
            con.Open();
            try
            {

                cmd.CommandText = RQT + "";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    byte[] img = (byte[])(dr[row]);
                    if (img == null)
                        picemp.Image = null;
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        picemp.Image = System.Drawing.Image.FromStream(ms);
                    }

                }

                //  Console.WriteLine("select PHOTO from " + table + " where " + colonne_ref + "='" + reference + "'");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("" + ex);
            }
            con.Close();
        }

        public void chargementLabel(String id, Label nom, Label postnom, Label prenom)
        {
            con.Open();

            try
            {

                cmd.CommandText = "SELECT NOM,POSTNOM,PRENOM FROM TCITOYEN WHERE TCITOYEN.IDENTIFICATIONNATIONAL='" + id + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    nom.Text = dr[0].ToString();
                    postnom.Text = dr[1].ToString();
                    prenom.Text = dr[2].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void LOGIN(String USERNAME, string password, Form s)
        {


            try
            {
                con.Open();
                cmd.CommandText = "exec LOGER '" + USERNAME + "','" + password + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr[0].ToString() == "Le mot de passe ou nom d utilisateur est incorrect")
                    {
                        MessageBox.Show("" + dr[0].ToString(), "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    else
                    {


                        }
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UNIVERSALLabel(string RQT, Label prenom, int row)
        {
            Console.WriteLine("" + RQT);
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[row].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }
        public void UNIVERSALGROUPBOX(string RQT, GroupBox prenom)
        {
            Console.WriteLine("" + RQT);
            con.Open();

            try
            {

                cmd.CommandText = "" + RQT;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    prenom.Text = dr[0].ToString();
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

       

    }
}
