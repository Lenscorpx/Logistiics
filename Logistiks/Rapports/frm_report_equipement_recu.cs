using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data.SqlClient;

namespace Logistiks.Rapports
{
    public partial class frm_report_equipement_recu : MetroForm
    {
        public frm_report_equipement_recu()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cnx = new SqlConnection("Data Source=DESKTOP-PO0I2OH;Initial Catalog=db_medical_store;User ID=Lens;Password=Windy@2019.com?;");
            try
            {
                if (cnx.State == ConnectionState.Closed)
                    cnx.Open();
                const string requete = "liste_equipement_recus_entre_dates";
                var cmd = new SqlCommand(requete, cnx)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.Add(new SqlParameter("date_un", SqlDbType.Date)).Value = Convert.ToDateTime(dtp_date_un.Text);
                cmd.Parameters.Add(new SqlParameter("date_deux", SqlDbType.Date)).Value = Convert.ToDateTime(dtp_date_deux.Text);
                cmd.ExecuteNonQuery();

                var da = new SqlDataAdapter(cmd);
                var rpt = new rep_liste_equipement_recus();
                var dtset = new DataSet();
                da.Fill(dtset, "liste_equipement_recus_entre_dates");
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
