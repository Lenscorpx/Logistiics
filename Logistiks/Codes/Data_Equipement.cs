using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Logistiks.Codes
{
    public partial class Data_Equipement
    {
        Data_Parametres prms = new Data_Parametres();
        public void enregistrer_equipement(string code_produit, string designation_equipement, DataTable dx)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_equipement";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_produit", SqlDbType.NVarChar)).Value = code_produit;
                cmd.Parameters.Add(new SqlParameter("designation_equipement", SqlDbType.NVarChar)).Value = designation_equipement;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                afficher_equipement(dx);
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
        public void supprimer_equipement(string code_produit, DataTable dx)
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
                    const string requete = "supprimer_equipement";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("code_produit", SqlDbType.NVarChar)).Value = code_produit;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    afficher_equipement(dx);
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
        //public void rechercher_depot_par(string matricule_agent, DataGridView dtg)
        //{
        //    Data_Parametres prms = new Data_Parametres();
        //    //SqlConnection cnx = GetCnx();
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        string requete = "recherche_agent_par_matricule";
        //        SqlCommand cmd = new SqlCommand(requete, cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = matricule_agent;
        //        cmd.ExecuteNonQuery();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dtg.DataSource = dt;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Erreur de connexion: " + e.Message);
        //    }
        //    finally { cnx.Close(); cnx.Dispose(); }
        //}
        //public void rechercher_agent_par_nom(string nom_agent, DataGridView dtg)
        //{
        //    Data_Parametres prms = new Data_Parametres();
        //    //SqlConnection cnx = GetCnx();
        //    try
        //    {
        //        if (cnx.State == ConnectionState.Closed)
        //            cnx.Open();
        //        string requete = "recherche_agent_par_nom";
        //        SqlCommand cmd = new SqlCommand(requete, cnx);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add(new SqlParameter("noms_agent", SqlDbType.NVarChar)).Value = nom_agent;
        //        cmd.ExecuteNonQuery();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        DataTable dt = new DataTable();
        //        da.Fill(dt);
        //        dtg.DataSource = dt;
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("Erreur de connexion: " + e.Message);
        //    }
        //    finally { cnx.Close(); cnx.Dispose(); }
        //}
        public void afficher_equipement(DataTable dt)
        {
            SqlConnection cnx = new SqlConnection(prms.ToString());
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_equipement";
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
