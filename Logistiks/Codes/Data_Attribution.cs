using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Logistiks.Codes
{
    public partial class Data_Attribution
    {
        Data_Parametres prms = new Data_Parametres();
        public void insert_attribution( DateTime date_attribution, string code_demande, string code_approvisionnement, string matricule_agent, int qte, DataTable dx)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "insert_approvisionnement";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_attribution", SqlDbType.NVarChar)).Value = date_attribution;
                cmd.Parameters.Add(new SqlParameter("code_demande", SqlDbType.NVarChar)).Value = code_demande;
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = code_approvisionnement;
                cmd.Parameters.Add(new SqlParameter("qte_attribue", SqlDbType.Int)).Value = qte;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                afficher_attribution(dx);
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
        public void supprimer_attribution(string numero_attribution, DataTable dx)
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
                    const string requete = "supprimer_attribution";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("numero_attribution", SqlDbType.Int)).Value = numero_attribution;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    afficher_attribution(dx);
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
        public void rechercher_attribution_entre_date_par_approvisionnement(string code_approvisionnement, DateTime date_un, DateTime date_deux, DataGridView dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "rechercher_attribution_entre_date_par_approvisionnement";
                SqlCommand cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = code_approvisionnement;
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.Date)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.Date)).Value = date_deux;
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
        public void rechercher_attribution_entre_dates(DateTime date_un, DateTime date_deux, DataGridView dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "rechercher_attribution_entre_dates";
                SqlCommand cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.Date)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.Date)).Value = date_deux;
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
        public void rechercher_attribution_matricule_entre_dates(string matricule_agent, DateTime date_un, DateTime date_deux, DataGridView dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "rechercher_attribution_matricule_entre_date";
                SqlCommand cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = matricule_agent;
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.Date)).Value = date_un;
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.Date)).Value = date_deux;
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
        public void afficher_attribution(DataTable dt)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_attribution";
                SqlCommand cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

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
