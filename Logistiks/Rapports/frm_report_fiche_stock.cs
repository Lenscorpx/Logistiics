using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Logistiks.Rapports
{
    public partial class frm_report_fiche_stock : Form
    {
        public frm_report_fiche_stock()
        {
            InitializeComponent();
        }

        private void btn_afficher_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "rechercher_stock";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.ExecuteNonQuery();

                var da = new SqlDataAdapter(cmd);
                var rpt = new rapport_stock();
                var dtset = new DataSet();
                da.Fill(dtset, "rechercher_stock");
                rpt.DataSource = dtset;
                documentViewer1.DocumentSource = rpt;
                rpt.CreateDocument();
                documentViewer1.Refresh();
            }
            catch (Exception etr)
            {
                MessageBox.Show("Erreur lors du chargement!", "Echec", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}