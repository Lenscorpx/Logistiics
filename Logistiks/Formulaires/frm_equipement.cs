using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_equipement : MetroForm
    {
        public frm_equipement()
        {
            InitializeComponent();
            charger_categorie();
        }

        private void charger_categorie()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("charger_categorie", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dtg = new DataTable();
                da.Fill(dtg);
                cbx_categorie.Items.Clear();
                foreach (DataRow dr in dtg.Rows)
                {
                    cbx_categorie.Items.Add(Convert.ToString(dr[0]));
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
                const string requete = "enregistrer_produit";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_produit", SqlDbType.NVarChar)).Value = txt_code_produit.Text;
                cmd.Parameters.Add(new SqlParameter("designation_produit", SqlDbType.NVarChar)).Value = txt_designation_equipement.Text;
                cmd.Parameters.Add(new SqlParameter("code_categorie", SqlDbType.NVarChar)).Value = cbx_categorie.SelectedItem;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_equipement_Load(sender, e);
            }
            catch (Exception etx)
            {
                MessageBox.Show("Erreur lors de l'insertion!", "Echec d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                var rs = new DialogResult();
                rs = MessageBox.Show("Voulez vous consulter le message d'erreur?", "Message d'erreur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    MessageBox.Show(etx.ToString());
                }
            }
            finally
            {
                cnx.Close(); cnx.Dispose();
            }
        }

        private void frm_equipement_Load(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_produit";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_equipement.DataSource = dt;

            }
            catch (Exception etx)
            {
                MessageBox.Show("Erreur de connexion: " + etx.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
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
                    const string requete = "supprimer_produit";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("code_produit", SqlDbType.NVarChar)).Value = txt_code_produit.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    frm_equipement_Load(sender, e);
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

        private void dtgrid_equipement_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_produit.Text = dtgrid_equipement.SelectedRows[0].Cells[0].Value.ToString();
            txt_designation_equipement.Text = dtgrid_equipement.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
