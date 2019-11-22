using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Logistiks.Codes
{
    public class Data_Login
    {
        Data_Parametres prms = new Data_Parametres();        
        public void insert_login(string nom_utilisateur, string mot_de_passe, string niveau_acces)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_login";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nom_utilisateur", SqlDbType.NVarChar)).Value = nom_utilisateur;
                cmd.Parameters.Add(new SqlParameter("mot_de_passe", SqlDbType.NVarChar)).Value = mot_de_passe;
                cmd.Parameters.Add(new SqlParameter("niveau_acces", SqlDbType.NVarChar)).Value = niveau_acces;


                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de l'insertion!", "Echec d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void supprimer_login(string nom_utilisateur)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "supprimer_login";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nom_utilisateur", SqlDbType.NVarChar)).Value = nom_utilisateur;

                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la suppression!", "Echec de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        public void rechercher_login(string nom_utilisateur, string mot_de_passe, string lbl_reponse)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                SqlCommand cmd = new SqlCommand("rechercher_login", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("nom_utilisateur", SqlDbType.NVarChar)).Value = nom_utilisateur;
                cmd.Parameters.Add(new SqlParameter("mot_de_passe", SqlDbType.NVarChar)).Value = mot_de_passe;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);  
                if(dt.Rows.Count==1)
                {
                    foreach (DataRow dr in dt.Rows)
                    {                        
                        prms.Niveau_acces= Convert.ToString(dr[2]);
                        lbl_reponse = "CONNECTE!";
                    }
                }
                else
                {
                    lbl_reponse = "ACCES REFUSE!";
                }                           

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion: " + e.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }

    }
}