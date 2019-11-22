using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Logistiks.Codes;
using System.Data.SQLite;
using System.IO;
using System.Data;
namespace Logistiks.Formulaires
{
    public partial class frm_login : MetroForm
    {
        public SQLiteConnection conx;
        Data_Login log_in = new Data_Login();
        frm_agent fr = new frm_agent();
        string reponse_server;
        Data_Parametres prms = new Data_Parametres();
        public frm_login()
        {
            conx = new SQLiteConnection("Data Source=bd_login.sqlite3");
            if (!File.Exists("./bd_login.sqlite3"))
            {
                try
                {
                    SQLiteConnection.CreateFile("bd_login.sqlite3");
                    string requete = "CREATE TABLE login_acces(servername varchar(50) primary key, database_name varchar(50), username varchar(50), password varchar(50))";
                    SQLiteCommand cmd = new SQLiteCommand(requete, conx);
                    if (conx.State != ConnectionState.Open)
                    {
                        conx.Open();
                        var resultat = cmd.ExecuteNonQuery();
                        conx.Close();

                     }
                        
                }
                catch (Exception ext)
                {
                    MessageBox.Show("Erreur de connexion au login" + ext);
                }


            }
            InitializeComponent();
            prms.Nom_serveur = txt_serveur.Text;
            prms.Nom_base_de_donnees = txt_database.Text;
            prms.Nom_user = txt_nom_user.Text;
            prms.Mot_de_passe_user = txt_password_bd.Text;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {            
            MessageBox.Show(prms.ToString());
            log_in.rechercher_login(txt_nom_user.Text, txt_mot_de_passe.Text, reponse_server);
            if(reponse_server== "CONNECTE!")
            {
                fr.Show();
            }
            else
            {
                MessageBox.Show("Veuillez vous connecter avec les bons identifiants svp!");
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
