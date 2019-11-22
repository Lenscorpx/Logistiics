using System;
using System.Collections.Generic;
using System.Linq;
using MetroFramework.Forms;
using Logistiks.Codes;
using System.Windows.Forms;

namespace Logistiks.Formulaires
{
    public partial class frm_menu_principal : MetroForm
    {
        public frm_menu_principal()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_agent agnt = new frm_agent()
            {
                MdiParent = this
            };
            agnt.Show();
        }

        private void approvisionnementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_approvisionnement apprvs = new frm_approvisionnement()
            {
                MdiParent = this
            };
            apprvs.Show();
        }

        private void attributionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_attribution attribs = new frm_attribution()
            {
                MdiParent = this
            };
            attribs.Show();
        }

        private void demandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_demande demnds = new frm_demande()
            {
                MdiParent = this
            };
            demnds.Show();
        }

        private void depotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_depot depot = new frm_depot()
            {
                MdiParent = this
            };
            depot.Show();
        }

        private void equipementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_equipement equips = new frm_equipement()
            {
                MdiParent = this
            };
            equips.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_fournisseur frnsr = new frm_fournisseur()
            {
                MdiParent = this
        };
            frnsr.Show();   
        }

        private void frm_menu_principal_Load(object sender, EventArgs e)
        {
            Data_Parametres prms = new Data_Parametres()
            {
                Nom_serveur = "DESKTOP-PO0I2OH",
                Nom_base_de_donnees = "db_logisitik",
                Nom_user = "sa",
                Mot_de_passe_user = "Windy@2019.com?"
            };
            //MessageBox.Show(prms.ToString());
        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            fournisseurToolStripMenuItem_Click(sender, e);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            agentsToolStripMenuItem_Click(sender, e);
        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            equipementToolStripMenuItem_Click(sender, e);
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            depotToolStripMenuItem_Click(sender, e);
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            demandeToolStripMenuItem_Click(sender, e);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            attributionToolStripMenuItem_Click(sender, e);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            approvisionnementToolStripMenuItem_Click(sender, e);
        }

        private void listeEquipementsEntrésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fr = new Rapports.frm_report_equipement_recu();
            fr.ShowDialog();
        }

        private void listeEquipementsSortisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fr = new Rapports.frm_report_equipement_sorties();
            fr.ShowDialog();
        }

        private void ficheDeStockPeriodiqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fr = new Rapports.frm_report_fiche_stock();
            fr.ShowDialog();
            
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            var agnt = new frm_zone()
            {
                MdiParent = this
            };
            agnt.Show();
        }

        private void metroButton9_Click(object sender, EventArgs e)
        {
            var agnt = new frm_structures()
            {
                MdiParent = this
            };
            agnt.Show();
        }

        private void metroButton10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm_menu_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
