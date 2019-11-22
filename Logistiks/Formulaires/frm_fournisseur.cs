using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_fournisseur : MetroForm
    {
        public frm_fournisseur()
        {
            InitializeComponent();
        }

        private void dtgrid_fournisseur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_fournisseur.Text = dtgrid_fournisseur.SelectedRows[0].Cells[0].Value.ToString();
            txt_noms_agent.Text = dtgrid_fournisseur.SelectedRows[0].Cells[1].Value.ToString();
            txt_adresse.Text = dtgrid_fournisseur.SelectedRows[0].Cells[2].Value.ToString();
            txt_telephone.Text = dtgrid_fournisseur.SelectedRows[0].Cells[3].Value.ToString();
            txt_mail.Text = dtgrid_fournisseur.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_fournisseur";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_fournisseur", SqlDbType.NVarChar)).Value = txt_code_fournisseur.Text;
                cmd.Parameters.Add(new SqlParameter("noms_fournisseur", SqlDbType.NVarChar)).Value = txt_noms_agent.Text;
                cmd.Parameters.Add(new SqlParameter("adresse_fournisseur", SqlDbType.NVarChar)).Value = txt_adresse.Text;
                cmd.Parameters.Add(new SqlParameter("telephone_fournisseur", SqlDbType.NVarChar)).Value = txt_telephone.Text;
                cmd.Parameters.Add(new SqlParameter("mail_fournisseur", SqlDbType.NVarChar)).Value = txt_mail.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_fournisseur_Load(sender, e);
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

        private void metroButton2_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            var confirmation = new DialogResult();
            confirmation = MessageBox.Show("Voulez vous supprimer cet enregistrement?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    if (cnx.State == ConnectionState.Closed)
                        cnx.Open();
                    const string requete = "supprimer_fournisseur";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("code_fournisseur", SqlDbType.NVarChar)).Value = txt_code_fournisseur.Text;

                    cmd.ExecuteNonQuery();
                    frm_fournisseur_Load(sender, e);
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
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

        private void frm_fournisseur_Load(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                string requete = "afficher_fournisseur";
                SqlCommand cmd = new SqlCommand(requete, cnx);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_fournisseur.DataSource = dt;

            }
            catch (Exception ert)
            {
                MessageBox.Show("Erreur de connexion: " + ert.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
    }
}
