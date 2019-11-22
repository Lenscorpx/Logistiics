using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Logistiks.Codes
{
    public partial class Data_Agent
    {
        Data_Parametres prms = new Data_Parametres();
        //SqlConnection cnx = new SqlConnection(@"Data Source=LENSCORP\LENSCORPX;Initial Catalog=db_logisitik;User ID=sa;Password=Windy@2019.com?");
        public void insert_agent(string matricule_agent, string noms_agent, string adresse, string telephone, string fonction, DateTime date_naissance)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {

                SqlHelper helper = new SqlHelper(prms.ToString());
                if (helper.estConnecte)
                {
                    cnx.Open();
                    string requete = "enregistrer_agent";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = matricule_agent;
                    cmd.Parameters.Add(new SqlParameter("noms_agent", SqlDbType.NVarChar)).Value = noms_agent;
                    cmd.Parameters.Add(new SqlParameter("adresse", SqlDbType.NVarChar)).Value = adresse;
                    cmd.Parameters.Add(new SqlParameter("telephone", SqlDbType.NVarChar)).Value = telephone;
                    cmd.Parameters.Add(new SqlParameter("fonction", SqlDbType.NVarChar)).Value = fonction;
                    cmd.Parameters.Add(new SqlParameter("date_naissance", SqlDbType.Date)).Value = date_naissance;


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
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
        public void supprimer_agent(string matricule_agent)
        {
            var confirmation = new DialogResult();
            confirmation = MessageBox.Show("Voulez vous supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirmation==DialogResult.Yes)
            {
                SqlConnection cnx = new SqlConnection(prms.ToString());
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    const string requete = "supprimer_agent";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = matricule_agent;

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
            
        }
        public void rechercher_agent_par_matricule(string matricule_agent, BunifuCustomDataGrid dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "recherche_agent_par_matricule";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = matricule_agent;
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
        public void rechercher_agent_par_nom(string nom_agent, BunifuCustomDataGrid dtg)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "recherche_agent_par_nom";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("noms_agent", SqlDbType.NVarChar)).Value = nom_agent;
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
        public void afficher_agent(BunifuCustomDataGrid dtg)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?");
            try
            {
                SqlHelper helper = new SqlHelper(prms.ToString());
                if (helper.estConnecte)
                {
                    cnx.Open();
                    var cmd = new SqlCommand("afficher_agent", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dtg.DataSource = dt;

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
