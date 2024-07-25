using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace gestion_cotes.classes
{
    class clsrelever
    {
        string codeetudiant;
        string etudiant;
        string annee;
        string mention;
        string moyennee;
        string telephone;

        public string Etudiant
        {
            get
            {
                return etudiant;
            }

            set
            {
                etudiant = value;
            }
        }

        public string Annee
        {
            get
            {
                return annee;
            }

            set
            {
                annee = value;
            }
        }

        public string Mention
        {
            get
            {
                return mention;
            }

            set
            {
                mention = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }

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

        public string Moyennee
        {
            get
            {
                return moyennee;
            }

            set
            {
                moyennee = value;
            }
        }

        SqlConnection con;
        public List<clsrelever> getsms()
        {
            List<clsrelever> list = new List<clsrelever>();
            con = new connexion().DBConnect();
            string strquery = "select * from sms";
            SqlCommand cmd = new SqlCommand(strquery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                clsrelever clsco = new clsrelever();
                clsco.codeetudiant = dr["codecotation"].ToString();
                clsco.etudiant = dr["etudiant"].ToString();
                clsco.annee = dr["annee"].ToString();
                clsco.mention = dr["mention"].ToString();
                clsco.Moyennee = dr["cotefinale"].ToString();
                clsco.telephone = dr["telephone"].ToString();
                list.Add(clsco);
            }
            return list;
        }

        public void SendSMS(string port, string noms, string telephone, string cote ,string mension,string annee)
        {
            try
            {
                string message = "Bonjour " + noms + " Vous aveez eu " + cote + " avec la mension " + mension + " annee academique "+ annee + "";

                SerialPort sp = new SerialPort();
                sp.PortName = port;
                sp.Open();
                sp.WriteLine("AT" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGF=1" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CSCS=\"GSM\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine("AT+CMGS=\"" + telephone + "\"" + Environment.NewLine);
                Thread.Sleep(100);
                sp.WriteLine(message + Environment.NewLine);
                sp.Write(new byte[] { 26 }, 0, 1);
                Thread.Sleep(100);
                var reponse = sp.ReadExisting();
                if (reponse.Contains("ERROR"))
                    MessageBox.Show("send faild", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else

                    MessageBox.Show("sms send", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sp.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       }
}
