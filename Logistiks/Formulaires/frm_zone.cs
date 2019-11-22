using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;
using Logistiks.Codes;

namespace Logistiks.Formulaires
{
    public partial class frm_zone : MetroForm
    {
        public frm_zone()
        {
            InitializeComponent();
            recuperer_ville();
        }
        private void afficher_zone()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            //agents.afficher_agent(bunifuCustomDataGrid1);
            try
            {
                SqlHelper helper = new SqlHelper("Data Source=DESKTOP-PO0I2OH;Initial Catalog = db_logisitik;User ID=sa;Password=Windy@2019.com?;");
                if (helper.estConnecte)
                {
                    cnx.Open();
                    var cmd = new SqlCommand("afficher_zone", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    cmd.ExecuteNonQuery();

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    var dt = new DataTable();
                    da.Fill(dt);
                    dtgrid.DataSource = dt;

                }
            }
            catch (Exception ect)
            {
                MessageBox.Show("Erreur de connexion: " + ect.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }
        private void recuperer_ville()
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=sa;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                var cmd = new SqlCommand("recuperer_ville", cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
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
        private void refreshDatas()
        {
            afficher_zone();
            recuperer_ville();
        }
        private void frm_zone_Load(object sender, EventArgs e)
        {
            refreshDatas();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "enregistrer_zone";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("id_zone", SqlDbType.NVarChar)).Value = txt_id_zone.Text;
                //cmd.Parameters.Add(new SqlParameter("date_approvisionnement", SqlDbType.Date)).Value = Convert.ToDateTime(dtp_date_approv.Text);
                cmd.Parameters.Add(new SqlParameter("descr_zone", SqlDbType.NVarChar)).Value = richTextBox1.Text;
                cmd.Parameters.Add(new SqlParameter("adresse", SqlDbType.NVarChar)).Value = txt_adresse.Text;
                cmd.Parameters.Add(new SqlParameter("telephone", SqlDbType.NVarChar)).Value = txt_telephone.Text;
                cmd.Parameters.Add(new SqlParameter("id_ville", SqlDbType.NVarChar)).Value = cbx_ville.Text;

                cmd.ExecuteNonQuery();
                MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                refreshDatas();
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

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id_zone.Text = dtgrid.SelectedRows[0].Cells[0].Value.ToString();
            richTextBox1.Text = dtgrid.SelectedRows[0].Cells[1].Value.ToString();
            txt_adresse.Text = dtgrid.SelectedRows[0].Cells[2].Value.ToString();
            txt_telephone.Text = dtgrid.SelectedRows[0].Cells[3].Value.ToString();
            cbx_ville.SelectedItem = dtgrid.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
