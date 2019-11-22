using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Logistiks.Codes
{
    public partial class Data_Fournisseur
    {
        Data_Parametres prms = new Data_Parametres();
        public void insert_fournisseur(string code_fournisseur, string noms_fournisseur, string adresse_fournisseur, string telephone_fournisseur, string mail_fournisseur, DataTable dx)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_fournisseur";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_fournisseur", SqlDbType.NVarChar)).Value = code_fournisseur;
                cmd.Parameters.Add(new SqlParameter("noms_fournisseur", SqlDbType.NVarChar)).Value = noms_fournisseur;
                cmd.Parameters.Add(new SqlParameter("adresse_fournisseur", SqlDbType.NVarChar)).Value = adresse_fournisseur;
                cmd.Parameters.Add(new SqlParameter("telephone_fournisseur", SqlDbType.NVarChar)).Value = telephone_fournisseur;
                cmd.Parameters.Add(new SqlParameter("mail_fournisseur", SqlDbType.NVarChar)).Value = mail_fournisseur;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                afficher_fournisseur(dx);
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
        public void supprimer_fournisseur(string code_fournisseur, DataTable dx)
        {
            var confirmation = new DialogResult();
            confirmation = MessageBox.Show("Voulez vous supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                SqlConnection cnx = new SqlConnection(prms.ToString());
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    const string requete = "supprimer_fournisseur";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = code_fournisseur;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    afficher_fournisseur(dx);
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

        }
        public void rechercher_fournisseur(string code_fournisseur, DataGridView dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "recherche_fournisseur";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("code_fournisseur", SqlDbType.NVarChar)).Value = code_fournisseur;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dtg.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion: " + e.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
        public void afficher_fournisseur(DataTable dt)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_fournisseur";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                //dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur de connexion: " + e.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
    }
}
