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

namespace Logistiks.Formulaires
{
    public partial class frm_admin : MetroForm
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        private void tileItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var form = new frm_demande();
            form.Show();
        }

        private void tileItem5_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var fr = new frm_approvisionnement();
            fr.Show();
        }

        private void tileItem2_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var fr = new frm_attribution();
            fr.Show();
        }

        private void tileItem6_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var fr = new frm_menu_principal();
            fr.Show();
        }

        private void frm_admin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void frm_admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tileItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            var fr = new frm_structures();
            fr.Show();
        }
    }
}
