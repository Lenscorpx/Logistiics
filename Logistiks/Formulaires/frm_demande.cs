using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_demande : MetroForm
    {
        public frm_demande()
        {
            InitializeComponent();
            refreshDatas();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_demande_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgrid_demande_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_demande.Text = dtgrid_demande.SelectedRows[0].Cells[0].Value.ToString();
            rtxt_demande.Text = dtgrid_demande.SelectedRows[0].Cells[1].Value.ToString();
            dtp_date_de_demande.Text = dtgrid_demande.SelectedRows[0].Cells[2].Value.ToString();
            cbx_structure.Text = dtgrid_demande.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void refreshDatas()
        {
            recuperer_province();
            afficher_commande();
            txt_code_demande.Clear();
        }
        private void afficher_commande()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("afficher_commande", cnx) { CommandType = CommandType.StoredProcedure };

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_demande.DataSource = dt;

            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur de connexion: " + etr.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
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
                cbx_structure.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_structure.Items.Add(Convert.ToString(dr[0]));
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

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if(txt_code_demande.Text=="")
            {
                if(cbx_structure.Text != null && rtxt_demande.Text != null)
                {
                    var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
                    try
                    {
                        if (cnx.State == ConnectionState.Closed)
                            cnx.Open();
                        const string requete = "inserer_commande";
                        var cmd = new SqlCommand(requete, cnx)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("concerne_commande", SqlDbType.NVarChar)).Value = rtxt_demande.Text;
                        cmd.Parameters.Add(new SqlParameter("date_commande", SqlDbType.Date)).Value = DateTime.Now;
                        cmd.Parameters.Add(new SqlParameter("id_structure", SqlDbType.NVarChar)).Value = cbx_structure.SelectedItem.ToString();


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        frm_demande_Load(sender, e);
                    }
                    catch (Exception etr)
                    {
                        MessageBox.Show("Erreur lors de l'insertion!", "Echec d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var rs = new DialogResult();
                        rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            MessageBox.Show(etr.ToString());
                        }
                    }
                    finally
                    {
                        cnx.Close(); cnx.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez completer les informations de base!");
                }
                
            }
            else
            {
                if (cbx_structure.Text != null && rtxt_demande.Text != null)
                {
                    var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
                    try
                    {
                        if (cnx.State == ConnectionState.Closed)
                            cnx.Open();
                        const string requete = "modifier_commande";
                        var cmd = new SqlCommand(requete, cnx)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("num_commande", SqlDbType.Int)).Value = Convert.ToInt32(txt_code_demande.Text);
                        cmd.Parameters.Add(new SqlParameter("concerne_commande", SqlDbType.NVarChar)).Value = rtxt_demande.Text;
                        cmd.Parameters.Add(new SqlParameter("date_commande", SqlDbType.Date)).Value = DateTime.Now;
                        cmd.Parameters.Add(new SqlParameter("id_structure", SqlDbType.NVarChar)).Value = cbx_structure.SelectedItem.ToString();


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        frm_demande_Load(sender, e);
                    }
                    catch (Exception etr)
                    {
                        MessageBox.Show("Erreur lors de l'insertion!", "Echec d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        var rs = new DialogResult();
                        rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (rs == DialogResult.Yes)
                        {
                            MessageBox.Show(etr.ToString());
                        }
                    }
                    finally
                    {
                        cnx.Close(); cnx.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez completer les informations de base!");
                }
            }
            refreshDatas();
        }

        private void metroButton2_Click_1(object sender, EventArgs e)
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
                    const string requete = "supprimer_commande";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("num_commande", SqlDbType.NVarChar)).Value = txt_code_demande.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    frm_demande_Load(sender, e);
                }
                catch (Exception etr)
                {
                    MessageBox.Show("Erreur lors de la suppression!", "Echec de suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    var rs = new DialogResult();
                    rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rs == DialogResult.Yes)
                    {
                        MessageBox.Show(etr.ToString());
                    }
                }
                finally
                {
                    cnx.Close(); cnx.Dispose();
                }
            }
            refreshDatas();
        }
    }
}
