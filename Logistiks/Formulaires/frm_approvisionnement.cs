using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_approvisionnement : MetroForm
    {
        public frm_approvisionnement()
        {
            InitializeComponent();
        }

        private void charger_depot()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_depot", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                    da.Fill(dtg);
                    cbx_depot.Items.Clear();
                    foreach (DataRow dr in dtg.Rows)
                    {
                    cbx_depot.Items.Add(Convert.ToString(dr[0]));
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
        private void charger_fournisseur()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_fournisseur", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_fournisseur.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_fournisseur.Items.Add(Convert.ToString(dr[0]));
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
        private void charger_equipement()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_produit", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                lstbox_equipement.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    lstbox_equipement.Items.Add(Convert.ToString(dr[0]));
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
        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "inserer_approvisionnement";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = txt_code_approv.Text;
                cmd.Parameters.Add(new SqlParameter("date_approvisionnement", SqlDbType.Date)).Value = Convert.ToDateTime(dtp_date_approv.Text);
                cmd.Parameters.Add(new SqlParameter("date_fabrication", SqlDbType.Date)).Value = Convert.ToDateTime(dt_date_fabrication.Text);
                cmd.Parameters.Add(new SqlParameter("date_expiration", SqlDbType.Date)).Value = Convert.ToDateTime(dt_expiration.Text);
                cmd.Parameters.Add(new SqlParameter("code_produit", SqlDbType.NVarChar)).Value =txt_produit.Text ;
                cmd.Parameters.Add(new SqlParameter("code_fournisseur", SqlDbType.NVarChar)).Value = cbx_fournisseur.Text;
                cmd.Parameters.Add(new SqlParameter("code_depot", SqlDbType.NVarChar)).Value = cbx_depot.Text;
                cmd.Parameters.Add(new SqlParameter("quantite", SqlDbType.Int)).Value = txt_quantite.Text;
                cmd.Parameters.Add(new SqlParameter("cout_total", SqlDbType.Decimal)).Value = txt_cout.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_approvisionnement_Load(sender, e);
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

        private void frm_approvisionnement_Load(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_approvisionnement";
                SqlCommand cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_approvisionnement.DataSource = dt;
            }
            catch (Exception ext)
            {
                MessageBox.Show("Erreur de connexion: " + ext.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
            charger_depot();
            charger_equipement();
            charger_fournisseur();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dtgrid_approvisionnement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_approv.Text = dtgrid_approvisionnement.SelectedRows[0].Cells[0].Value.ToString();
            dtp_date_approv.Text= dtgrid_approvisionnement.SelectedRows[0].Cells[1].Value.ToString();
            dt_date_fabrication.Text= dtgrid_approvisionnement.SelectedRows[0].Cells[2].Value.ToString();
            dt_expiration.Text= dtgrid_approvisionnement.SelectedRows[0].Cells[3].Value.ToString();
            txt_produit.Text= dtgrid_approvisionnement.SelectedRows[0].Cells[4].Value.ToString();
            cbx_fournisseur.Text= dtgrid_approvisionnement.SelectedRows[0].Cells[5].Value.ToString();
            cbx_depot.Text = dtgrid_approvisionnement.SelectedRows[0].Cells[6].Value.ToString();
            txt_quantite.Text = dtgrid_approvisionnement.SelectedRows[0].Cells[7].Value.ToString();
            txt_cout.Text = dtgrid_approvisionnement.SelectedRows[0].Cells[8].Value.ToString();

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "supprimer_approvisionnement";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_approvisionnement", SqlDbType.NVarChar)).Value = txt_code_approv.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_approvisionnement_Load(sender, e);
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

        private void lstbox_equipement_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_produit.Text = Convert.ToString(lstbox_equipement.SelectedItem);
        }
    }
}