using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using Logistiks.Codes;
using System.Data;
using System.Data.SqlClient;
namespace Logistiks.Formulaires
{
    public partial class frm_agent : MetroForm
    {
        
        public frm_agent()
        {
            InitializeComponent();
        }

        private void frm_agent_Load(object sender, EventArgs etra)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            //agents.afficher_agent(bunifuCustomDataGrid1);
            try
            {
                SqlHelper helper = new SqlHelper("Data Source=DESKTOP-PO0I2OH;Initial Catalog = db_logisitik;User ID=sa;Password=Windy@2019.com?;");
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
                    dtgrid_agent.DataSource = dt;

                }
            }
            catch (Exception ect)
            {
                MessageBox.Show("Erreur de connexion: " + ect.Message);
            }
            finally { cnx.Close(); cnx.Dispose(); }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (txt_adresse.Text == null ||
               txt_fonction.Text == null ||
               txt_code_client.Text == null ||
               txt_noms_agent.Text == null ||
               txt_telephone.Text == null)
            {
                MessageBox.Show("Completer les cases vides s'il vous plait!");
            }
            else
            {
                var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
                //agents
                try
                {

                    SqlHelper helper = new SqlHelper("Data Source=DESKTOP-PO0I2OH;Initial Catalog = db_logisitik;User ID=sa;Password=Windy@2019.com?;");
                    if (helper.estConnecte)
                    {
                        cnx.Open();
                        var cmd = new SqlCommand("enregistrer_agent", cnx)
                        {
                            CommandType = CommandType.StoredProcedure
                        };
                        cmd.Parameters.Add(new SqlParameter("matricule_client", SqlDbType.NVarChar)).Value = txt_code_client.Text;
                        cmd.Parameters.Add(new SqlParameter("noms_client", SqlDbType.NVarChar)).Value = txt_noms_agent.Text;
                        cmd.Parameters.Add(new SqlParameter("adresse", SqlDbType.NVarChar)).Value = txt_adresse.Text;
                        cmd.Parameters.Add(new SqlParameter("telephone", SqlDbType.NVarChar)).Value = txt_telephone.Text;
                        cmd.Parameters.Add(new SqlParameter("fonction", SqlDbType.NVarChar)).Value = txt_fonction.Text;
                        //cmd.Parameters.Add(new SqlParameter("date_naissance", SqlDbType.Date)).Value = dtp_date_de_naissance.Text;


                        cmd.ExecuteNonQuery();
                        frm_agent_Load(sender, e);
                        MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
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
        }

        private void metroButton2_Click(object sender, EventArgs eTR)
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
                    const string requete = "supprimer_agent";
                    var cmd = new SqlCommand(requete, cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("matricule_client", SqlDbType.NVarChar)).Value = txt_code_client.Text;

                    cmd.ExecuteNonQuery();
                    frm_agent_Load(sender, eTR);
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

        private void dtgrid_agent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_code_client.Text = dtgrid_agent.SelectedRows[0].Cells[0].Value.ToString();
            txt_noms_agent.Text = dtgrid_agent.SelectedRows[0].Cells[1].Value.ToString();
            txt_adresse.Text = dtgrid_agent.SelectedRows[0].Cells[2].Value.ToString();
            txt_telephone.Text = dtgrid_agent.SelectedRows[0].Cells[3].Value.ToString();
            txt_fonction.Text = dtgrid_agent.SelectedRows[0].Cells[4].Value.ToString();
            //dtp_date_de_naissance.Text = Convert.ToString(dtgrid_agent.SelectedRows[0].Cells[5].ToString());
        }

        private void txt_code_client_TextChanged(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            //agents
            try
            {

                SqlHelper helper = new SqlHelper("Data Source=DESKTOP-PO0I2OH;Initial Catalog = db_logisitik;User ID=sa;Password=Windy@2019.com?;");
                if (helper.estConnecte)
                {
                    cnx.Open();
                    var cmd = new SqlCommand("recherche_agent_par_matricule", cnx)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add(new SqlParameter("matricule_agent", SqlDbType.NVarChar)).Value = txt_code_client.Text;

                    cmd.ExecuteNonQuery();
                    frm_agent_Load(sender, e);
                    //MessageBox.Show("insertion reussie!", "Reussite d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
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
    }
}