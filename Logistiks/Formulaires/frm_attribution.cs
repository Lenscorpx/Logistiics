using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_attribution : MetroForm
    {
        public frm_attribution()
        {
            InitializeComponent();
            refresh_form();
        }

        private void charger_equipement_approv()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_nom_produit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = cbx_approv.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dtg = new DataTable();
                da.Fill(dtg);
                if (dtg.Rows.Count == 1)
                {
                    foreach (DataRow dr in dtg.Rows)
                    {
                        txt_equipement.Text = Convert.ToString(dr[0]);
                    }
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void charger_demande()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_commandes", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_demande.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_demande.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void charger_approvisionnement()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_approvisionnement", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_approv.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_approv.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void charger_air_de_sante()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_structure", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                lstbox_air_de_sante.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    lstbox_air_de_sante.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void frm_attribution_Load(object sender, EventArgs e)
        {         
            
        }
        private void charger_attribution()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_distribution", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_attribution.DataSource = dt;

            }
            catch (Exception ext)
            {
                MessageBox.Show("Erreur de connexion: " + ext.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
        private void refresh_form()
        {
            charger_demande();
            charger_approvisionnement();
            charger_air_de_sante();
            recuperer_province();
            charger_attribution();
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "inserer_attribution";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_attribution", SqlDbType.NVarChar)).Value = txt_attribution.Text;
                cmd.Parameters.Add(new SqlParameter("date_attribution", SqlDbType.Date)).Value = dtp_date_de_demande.Text;
                cmd.Parameters.Add(new SqlParameter("code_demande", SqlDbType.NVarChar)).Value = cbx_demande.Text;
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = cbx_approv.Text;
                cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = txt_code_structure.Text;
                cmd.Parameters.Add(new SqlParameter("qte_attribue", SqlDbType.Int)).Value = Convert.ToInt32(txt_quantite.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_attribution_Load(sender,e);
            }
            catch (Exception ext)
            {
                MessageBox.Show("Erreur lors de l'insertion!", "Echec d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(ext.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

        private void lstbox_agent_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_code_structure.Text = Convert.ToString(lstbox_air_de_sante.SelectedItem);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var confirmation = new DialogResult();
            confirmation = MessageBox.Show("Voulez vous supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    const string requete = "supprimer_attribution";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("code_attribution", SqlDbType.NVarChar)).Value = txt_attribution.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    frm_attribution_Load(sender, e);
                }
                catch (Exception ext)
                {
                    MessageBox.Show("Erreur lors de la suppression!", "Echec de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var rs = new DialogResult();
                    rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        MessageBox.Show(ext.ToString());
                    }
                }
                finally
                {
                    cnx.Close(); cnx.Dispose();
                }
            }
    }

        private void cbx_approv_TextChanged(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("select_produit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = cbx_approv.Text;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                txt_equipement.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    txt_equipement.Text=Convert.ToString(dr[0]);
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void somme_sorties()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "somme_sorties";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = cbx_approv.Text;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txt_qte_sortie.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    txt_qte_sortie.Text = Convert.ToString(dr[0]);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : " + e.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
        private void somme_entrees()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "somme_entrees";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = cbx_approv.Text;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                txt_qte_entree.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    txt_qte_entree.Text = Convert.ToString(dr[0]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur : " + e.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
        private void cbx_approv_SelectedIndexChanged(object sender, EventArgs e)
        {
            charger_equipement_approv();
            somme_entrees();
            somme_sorties();
            if(txt_qte_sortie.Text=="" & txt_qte_entree.Text!="")
            {
                txt_qte_sortie.Text = "0";
                MessageBox.Show("Quantite de l'equipement encore intacte!");
                int qte_entree, qte_sortie, qte_dispo;
                qte_entree = Convert.ToInt32(txt_qte_entree.Text);
                qte_sortie = Convert.ToInt32(txt_qte_sortie.Text);
                qte_dispo = qte_entree - qte_sortie;
                txt_qte_dispo.Text = Convert.ToString(qte_dispo);
            }
            else
            {
                int qte_entree, qte_sortie, qte_dispo;
                qte_entree = Convert.ToInt32(txt_qte_entree.Text);
                qte_sortie = Convert.ToInt32(txt_qte_sortie.Text);
                qte_dispo = qte_entree - qte_sortie;
                txt_qte_dispo.Text = Convert.ToString(qte_dispo);
            }
        }

        private void dtgrid_approvisionnement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_attribution.Text = dtgrid_attribution.SelectedRows[0].Cells[0].Value.ToString();
            cbx_demande.Text = dtgrid_attribution.SelectedRows[0].Cells[2].Value.ToString();
            cbx_approv.Text = dtgrid_attribution.SelectedRows[0].Cells[3].Value.ToString();
            txt_code_structure.Text = dtgrid_attribution.SelectedRows[0].Cells[4].Value.ToString();
            txt_quantite.Text = dtgrid_attribution.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void recuperer_province()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_province", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_province.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_province.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void recuperer_ville_parID_province(string id_province)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_ville_parID_province", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_province", SqlDbType.NVarChar)).Value = id_province;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_ville.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_ville.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void recuperer_zone_parID_ville(string id_ville)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_zone_parID_ville", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_ville", SqlDbType.NVarChar)).Value = id_ville;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_zone.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_zone.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void recuperer_structure_parID_zone(string id_zone)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_structure_parID_zone", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_zone", SqlDbType.NVarChar)).Value = id_zone;
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                lstbox_air_de_sante.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    lstbox_air_de_sante.Items.Add(Convert.ToString(dr[0]));
                }
            }
            catch (Exception df)
            {
                MessageBox.Show("Echec de connexion!\n" + df);
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }
        private void cbx_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            recuperer_ville_parID_province(cbx_province.SelectedItem.ToString()); 
        }

        private void cbx_ville_SelectedIndexChanged(object sender, EventArgs e)
        {
            recuperer_zone_parID_ville(cbx_ville.SelectedItem.ToString());
        }

        private void cbx_zone_SelectedIndexChanged(object sender, EventArgs e)
        {
            recuperer_structure_parID_zone(cbx_zone.SelectedItem.ToString());
        }
    }
}
