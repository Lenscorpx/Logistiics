using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Formulaires
{
    public partial class frm_depot : MetroForm
    {
        public frm_depot()
        {
            InitializeComponent();
        }

        private void frm_depot_Load(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                SqlCommand cmd = new SqlCommand("afficher_depot", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };

                cmd.ExecuteNonQuery();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                dtgrid_depot.DataSource = dt;
            }
            catch (Exception ext)
            {
                MessageBox.Show("Erreur de connexion: " + ext.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_depot";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("code_depot", SqlDbType.NVarChar)).Value = txt_code_depot.Text;
                cmd.Parameters.Add(new SqlParameter("designation_depot", SqlDbType.NVarChar)).Value = txt_designation_depot.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                frm_depot_Load(sender, e);
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
                    const string requete = "supprimer_depot";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("code_depot", SqlDbType.NVarChar)).Value = txt_code_depot.Text;

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Suppression reussie!", "Reussite de suppression", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    frm_depot_Load(sender, e);
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

        private void dtgrid_depot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_depot.Text = dtgrid_depot.SelectedRows[0].Cells[0].Value.ToString();
            txt_designation_depot.Text = dtgrid_depot.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}