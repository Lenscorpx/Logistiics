namespace Logistiks.Formulaires
{
    partial class frm_demande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgrid_demande = new System.Windows.Forms.DataGridView();
            this.dtp_date_de_demande = new MetroFramework.Controls.MetroDateTime();
            this.txt_code_demande = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxt_demande = new System.Windows.Forms.RichTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.cbx_province = new MetroFramework.Controls.MetroComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_ville = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_zone = new MetroFramework.Controls.MetroComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_structure = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_demande)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgrid_demande
            // 
            this.dtgrid_demande.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_demande.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_demande.BackgroundColor = System.Drawing.Color.Black;
            this.dtgrid_demande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_demande.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgrid_demande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_demande.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgrid_demande.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_demande.GridColor = System.Drawing.Color.White;
            this.dtgrid_demande.Location = new System.Drawing.Point(20, 355);
            this.dtgrid_demande.Name = "dtgrid_demande";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_demande.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_demande.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgrid_demande.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_demande.ShowEditingIcon = false;
            this.dtgrid_demande.Size = new System.Drawing.Size(1046, 214);
            this.dtgrid_demande.TabIndex = 26;
            this.dtgrid_demande.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_demande_CellContentClick);
            // 
            // dtp_date_de_demande
            // 
            this.dtp_date_de_demande.DisplayFocus = true;
            this.dtp_date_de_demande.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_de_demande.Location = new System.Drawing.Point(919, 90);
            this.dtp_date_de_demande.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_date_de_demande.Name = "dtp_date_de_demande";
            this.dtp_date_de_demande.Size = new System.Drawing.Size(147, 29);
            this.dtp_date_de_demande.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtp_date_de_demande.TabIndex = 16;
            this.dtp_date_de_demande.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtp_date_de_demande.UseStyleColors = true;
            // 
            // txt_code_demande
            // 
            // 
            // 
            // 
            this.txt_code_demande.CustomButton.Image = null;
            this.txt_code_demande.CustomButton.Location = new System.Drawing.Point(370, 2);
            this.txt_code_demande.CustomButton.Name = "";
            this.txt_code_demande.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_code_demande.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_demande.CustomButton.TabIndex = 1;
            this.txt_code_demande.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_code_demande.CustomButton.UseSelectable = true;
            this.txt_code_demande.CustomButton.Visible = false;
            this.txt_code_demande.DisplayIcon = true;
            this.txt_code_demande.Enabled = false;
            this.txt_code_demande.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_code_demande.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_code_demande.ForeColor = System.Drawing.Color.Lime;
            this.txt_code_demande.Lines = new string[0];
            this.txt_code_demande.Location = new System.Drawing.Point(348, 319);
            this.txt_code_demande.MaxLength = 50;
            this.txt_code_demande.Name = "txt_code_demande";
            this.txt_code_demande.PasswordChar = '\0';
            this.txt_code_demande.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_code_demande.SelectedText = "";
            this.txt_code_demande.SelectionLength = 0;
            this.txt_code_demande.SelectionStart = 0;
            this.txt_code_demande.ShortcutsEnabled = true;
            this.txt_code_demande.ShowClearButton = true;
            this.txt_code_demande.Size = new System.Drawing.Size(398, 30);
            this.txt_code_demande.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_demande.TabIndex = 2;
            this.txt_code_demande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code_demande.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_code_demande.UseSelectable = true;
            this.txt_code_demande.UseStyleColors = true;
            this.txt_code_demande.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_code_demande.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(484, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Concerne de la demande";
            // 
            // rtxt_demande
            // 
            this.rtxt_demande.BackColor = System.Drawing.Color.Black;
            this.rtxt_demande.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxt_demande.ForeColor = System.Drawing.Color.White;
            this.rtxt_demande.Location = new System.Drawing.Point(488, 135);
            this.rtxt_demande.Name = "rtxt_demande";
            this.rtxt_demande.Size = new System.Drawing.Size(578, 173);
            this.rtxt_demande.TabIndex = 27;
            this.rtxt_demande.Text = "Ecrivez ici la declaration de commande des produits ainsi que toutes les autres o" +
    "bservations, la quantite, le delai de livraison etc...";
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(813, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 55;
            this.metroButton1.Text = "Enregistrer";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(941, 314);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(122, 35);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 56;
            this.metroButton2.Text = "Supprimer";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click_1);
            // 
            // cbx_province
            // 
            this.cbx_province.DisplayFocus = true;
            this.cbx_province.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_province.FormattingEnabled = true;
            this.cbx_province.ItemHeight = 23;
            this.cbx_province.Location = new System.Drawing.Point(89, 90);
            this.cbx_province.Name = "cbx_province";
            this.cbx_province.PromptText = "Selectionnez la province";
            this.cbx_province.Size = new System.Drawing.Size(377, 29);
            this.cbx_province.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_province.TabIndex = 57;
            this.cbx_province.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_province.UseSelectable = true;
            this.cbx_province.UseStyleColors = true;
            this.cbx_province.SelectedIndexChanged += new System.EventHandler(this.cbx_province_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 60;
            this.label4.Text = "Province";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 21);
            this.label3.TabIndex = 62;
            this.label3.Text = "Ville";
            // 
            // cbx_ville
            // 
            this.cbx_ville.DisplayFocus = true;
            this.cbx_ville.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_ville.FormattingEnabled = true;
            this.cbx_ville.ItemHeight = 23;
            this.cbx_ville.Location = new System.Drawing.Point(89, 153);
            this.cbx_ville.Name = "cbx_ville";
            this.cbx_ville.PromptText = "Selectionnez la ville dans laquelle se trouve la zone";
            this.cbx_ville.Size = new System.Drawing.Size(377, 29);
            this.cbx_ville.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_ville.TabIndex = 61;
            this.cbx_ville.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_ville.UseSelectable = true;
            this.cbx_ville.UseStyleColors = true;
            this.cbx_ville.SelectedIndexChanged += new System.EventHandler(this.cbx_ville_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 21);
            this.label5.TabIndex = 64;
            this.label5.Text = "Zone";
            // 
            // cbx_zone
            // 
            this.cbx_zone.DisplayFocus = true;
            this.cbx_zone.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_zone.FormattingEnabled = true;
            this.cbx_zone.ItemHeight = 23;
            this.cbx_zone.Location = new System.Drawing.Point(89, 218);
            this.cbx_zone.Name = "cbx_zone";
            this.cbx_zone.PromptText = "Selectionnez la zone";
            this.cbx_zone.Size = new System.Drawing.Size(377, 29);
            this.cbx_zone.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_zone.TabIndex = 63;
            this.cbx_zone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_zone.UseSelectable = true;
            this.cbx_zone.UseStyleColors = true;
            this.cbx_zone.SelectedIndexChanged += new System.EventHandler(this.cbx_zone_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(54, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 21);
            this.label6.TabIndex = 66;
            this.label6.Text = "Structure";
            // 
            // cbx_structure
            // 
            this.cbx_structure.DisplayFocus = true;
            this.cbx_structure.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cbx_structure.FormattingEnabled = true;
            this.cbx_structure.ItemHeight = 23;
            this.cbx_structure.Location = new System.Drawing.Point(89, 280);
            this.cbx_structure.Name = "cbx_structure";
            this.cbx_structure.PromptText = "Selectionnez la structure";
            this.cbx_structure.Size = new System.Drawing.Size(377, 29);
            this.cbx_structure.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_structure.TabIndex = 65;
            this.cbx_structure.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_structure.UseSelectable = true;
            this.cbx_structure.UseStyleColors = true;
            // 
            // frm_demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 589);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_structure);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_zone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_ville);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbx_province);
            this.Controls.Add(this.dtp_date_de_demande);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txt_code_demande);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.rtxt_demande);
            this.Controls.Add(this.dtgrid_demande);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "frm_demande";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Commandes de produits";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frm_demande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_demande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgrid_demande;
        private MetroFramework.Controls.MetroTextBox txt_code_demande;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dtp_date_de_demande;
        private System.Windows.Forms.RichTextBox rtxt_demande;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroComboBox cbx_province;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbx_ville;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbx_zone;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroComboBox cbx_structure;
    }
}