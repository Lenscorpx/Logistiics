namespace Logistiks.Formulaires
{
    partial class frm_approvisionnement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lstbox_equipement = new System.Windows.Forms.ListBox();
            this.dtgrid_approvisionnement = new System.Windows.Forms.DataGridView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_cout = new MetroFramework.Controls.MetroTextBox();
            this.txt_quantite = new MetroFramework.Controls.MetroTextBox();
            this.cbx_depot = new MetroFramework.Controls.MetroComboBox();
            this.cbx_fournisseur = new MetroFramework.Controls.MetroComboBox();
            this.dtp_date_approv = new MetroFramework.Controls.MetroDateTime();
            this.txt_code_approv = new MetroFramework.Controls.MetroTextBox();
            this.dt_date_fabrication = new MetroFramework.Controls.MetroDateTime();
            this.dt_expiration = new MetroFramework.Controls.MetroDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_produit = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_approvisionnement)).BeginInit();
            this.SuspendLayout();
            // 
            // lstbox_equipement
            // 
            this.lstbox_equipement.BackColor = System.Drawing.Color.Black;
            this.lstbox_equipement.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbox_equipement.ForeColor = System.Drawing.Color.Crimson;
            this.lstbox_equipement.FormattingEnabled = true;
            this.lstbox_equipement.ItemHeight = 25;
            this.lstbox_equipement.Location = new System.Drawing.Point(15, 71);
            this.lstbox_equipement.Name = "lstbox_equipement";
            this.lstbox_equipement.Size = new System.Drawing.Size(223, 529);
            this.lstbox_equipement.TabIndex = 0;
            this.lstbox_equipement.SelectedIndexChanged += new System.EventHandler(this.lstbox_equipement_SelectedIndexChanged);
            // 
            // dtgrid_approvisionnement
            // 
            this.dtgrid_approvisionnement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_approvisionnement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_approvisionnement.BackgroundColor = System.Drawing.Color.Black;
            this.dtgrid_approvisionnement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrid_approvisionnement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_approvisionnement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_approvisionnement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_approvisionnement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_approvisionnement.GridColor = System.Drawing.Color.White;
            this.dtgrid_approvisionnement.Location = new System.Drawing.Point(244, 317);
            this.dtgrid_approvisionnement.Name = "dtgrid_approvisionnement";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_approvisionnement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_approvisionnement.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrid_approvisionnement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_approvisionnement.ShowEditingIcon = false;
            this.dtgrid_approvisionnement.Size = new System.Drawing.Size(1035, 283);
            this.dtgrid_approvisionnement.TabIndex = 28;
            this.dtgrid_approvisionnement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_approvisionnement_CellContentClick);
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(1112, 276);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(167, 35);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton2.TabIndex = 30;
            this.metroButton2.Text = "Supprimer";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton1.Location = new System.Drawing.Point(939, 276);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(167, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroButton1.TabIndex = 29;
            this.metroButton1.Text = "Enregistrer";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_cout
            // 
            // 
            // 
            // 
            this.txt_cout.CustomButton.Image = null;
            this.txt_cout.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.txt_cout.CustomButton.Name = "";
            this.txt_cout.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_cout.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_cout.CustomButton.TabIndex = 1;
            this.txt_cout.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_cout.CustomButton.UseSelectable = true;
            this.txt_cout.CustomButton.Visible = false;
            this.txt_cout.DisplayIcon = true;
            this.txt_cout.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_cout.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_cout.ForeColor = System.Drawing.Color.Crimson;
            this.txt_cout.Lines = new string[0];
            this.txt_cout.Location = new System.Drawing.Point(276, 206);
            this.txt_cout.MaxLength = 50;
            this.txt_cout.Name = "txt_cout";
            this.txt_cout.PasswordChar = '\0';
            this.txt_cout.PromptText = "Entrez le cout total de l\'approvisionnement";
            this.txt_cout.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_cout.SelectedText = "";
            this.txt_cout.SelectionLength = 0;
            this.txt_cout.SelectionStart = 0;
            this.txt_cout.ShortcutsEnabled = true;
            this.txt_cout.ShowClearButton = true;
            this.txt_cout.Size = new System.Drawing.Size(293, 30);
            this.txt_cout.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_cout.TabIndex = 37;
            this.txt_cout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_cout.UseSelectable = true;
            this.txt_cout.UseStyleColors = true;
            this.txt_cout.WaterMark = "Entrez le cout total de l\'approvisionnement";
            this.txt_cout.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_cout.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_quantite
            // 
            // 
            // 
            // 
            this.txt_quantite.CustomButton.Image = null;
            this.txt_quantite.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.txt_quantite.CustomButton.Name = "";
            this.txt_quantite.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_quantite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_quantite.CustomButton.TabIndex = 1;
            this.txt_quantite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_quantite.CustomButton.UseSelectable = true;
            this.txt_quantite.CustomButton.Visible = false;
            this.txt_quantite.DisplayIcon = true;
            this.txt_quantite.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_quantite.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_quantite.ForeColor = System.Drawing.Color.Crimson;
            this.txt_quantite.Lines = new string[0];
            this.txt_quantite.Location = new System.Drawing.Point(276, 171);
            this.txt_quantite.MaxLength = 50;
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.PasswordChar = '\0';
            this.txt_quantite.PromptText = "Entrez la quantite (en nombres)";
            this.txt_quantite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_quantite.SelectedText = "";
            this.txt_quantite.SelectionLength = 0;
            this.txt_quantite.SelectionStart = 0;
            this.txt_quantite.ShortcutsEnabled = true;
            this.txt_quantite.ShowClearButton = true;
            this.txt_quantite.Size = new System.Drawing.Size(293, 30);
            this.txt_quantite.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_quantite.TabIndex = 36;
            this.txt_quantite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_quantite.UseSelectable = true;
            this.txt_quantite.UseStyleColors = true;
            this.txt_quantite.WaterMark = "Entrez la quantite (en nombres)";
            this.txt_quantite.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_quantite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cbx_depot
            // 
            this.cbx_depot.FormattingEnabled = true;
            this.cbx_depot.ItemHeight = 23;
            this.cbx_depot.Location = new System.Drawing.Point(851, 138);
            this.cbx_depot.Name = "cbx_depot";
            this.cbx_depot.PromptText = "Selectionnez le depot";
            this.cbx_depot.Size = new System.Drawing.Size(428, 29);
            this.cbx_depot.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_depot.TabIndex = 35;
            this.cbx_depot.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_depot.UseSelectable = true;
            // 
            // cbx_fournisseur
            // 
            this.cbx_fournisseur.FormattingEnabled = true;
            this.cbx_fournisseur.ItemHeight = 23;
            this.cbx_fournisseur.Location = new System.Drawing.Point(851, 102);
            this.cbx_fournisseur.Name = "cbx_fournisseur";
            this.cbx_fournisseur.PromptText = "Selectionnez le fournisseur";
            this.cbx_fournisseur.Size = new System.Drawing.Size(428, 29);
            this.cbx_fournisseur.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_fournisseur.TabIndex = 34;
            this.cbx_fournisseur.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_fournisseur.UseSelectable = true;
            // 
            // dtp_date_approv
            // 
            this.dtp_date_approv.DisplayFocus = true;
            this.dtp_date_approv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date_approv.Location = new System.Drawing.Point(276, 102);
            this.dtp_date_approv.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtp_date_approv.Name = "dtp_date_approv";
            this.dtp_date_approv.Size = new System.Drawing.Size(293, 29);
            this.dtp_date_approv.Style = MetroFramework.MetroColorStyle.Blue;
            this.dtp_date_approv.TabIndex = 33;
            this.dtp_date_approv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtp_date_approv.UseStyleColors = true;
            // 
            // txt_code_approv
            // 
            // 
            // 
            // 
            this.txt_code_approv.CustomButton.Image = null;
            this.txt_code_approv.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.txt_code_approv.CustomButton.Name = "";
            this.txt_code_approv.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_code_approv.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_approv.CustomButton.TabIndex = 1;
            this.txt_code_approv.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_code_approv.CustomButton.UseSelectable = true;
            this.txt_code_approv.CustomButton.Visible = false;
            this.txt_code_approv.DisplayIcon = true;
            this.txt_code_approv.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_code_approv.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_code_approv.ForeColor = System.Drawing.Color.Crimson;
            this.txt_code_approv.Lines = new string[0];
            this.txt_code_approv.Location = new System.Drawing.Point(276, 137);
            this.txt_code_approv.MaxLength = 50;
            this.txt_code_approv.Name = "txt_code_approv";
            this.txt_code_approv.PasswordChar = '\0';
            this.txt_code_approv.PromptText = "Entrez le nom de code de l\'approvisionnement";
            this.txt_code_approv.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_code_approv.SelectedText = "";
            this.txt_code_approv.SelectionLength = 0;
            this.txt_code_approv.SelectionStart = 0;
            this.txt_code_approv.ShortcutsEnabled = true;
            this.txt_code_approv.ShowClearButton = true;
            this.txt_code_approv.Size = new System.Drawing.Size(293, 30);
            this.txt_code_approv.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_code_approv.TabIndex = 31;
            this.txt_code_approv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code_approv.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_code_approv.UseSelectable = true;
            this.txt_code_approv.UseStyleColors = true;
            this.txt_code_approv.WaterMark = "Entrez le nom de code de l\'approvisionnement";
            this.txt_code_approv.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_code_approv.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dt_date_fabrication
            // 
            this.dt_date_fabrication.DisplayFocus = true;
            this.dt_date_fabrication.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_date_fabrication.Location = new System.Drawing.Point(955, 180);
            this.dt_date_fabrication.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_fabrication.Name = "dt_date_fabrication";
            this.dt_date_fabrication.Size = new System.Drawing.Size(324, 29);
            this.dt_date_fabrication.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_fabrication.TabIndex = 44;
            this.dt_date_fabrication.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dt_date_fabrication.UseStyleColors = true;
            // 
            // dt_expiration
            // 
            this.dt_expiration.DisplayFocus = true;
            this.dt_expiration.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_expiration.Location = new System.Drawing.Point(955, 215);
            this.dt_expiration.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_expiration.Name = "dt_expiration";
            this.dt_expiration.Size = new System.Drawing.Size(324, 29);
            this.dt_expiration.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_expiration.TabIndex = 45;
            this.dt_expiration.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dt_expiration.UseStyleColors = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(847, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Fabrication";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(847, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 47;
            this.label2.Text = "Expiration";
            // 
            // txt_produit
            // 
            // 
            // 
            // 
            this.txt_produit.CustomButton.Image = null;
            this.txt_produit.CustomButton.Location = new System.Drawing.Point(265, 2);
            this.txt_produit.CustomButton.Name = "";
            this.txt_produit.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_produit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_produit.CustomButton.TabIndex = 1;
            this.txt_produit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_produit.CustomButton.UseSelectable = true;
            this.txt_produit.CustomButton.Visible = false;
            this.txt_produit.DisplayIcon = true;
            this.txt_produit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_produit.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_produit.ForeColor = System.Drawing.Color.Crimson;
            this.txt_produit.Lines = new string[0];
            this.txt_produit.Location = new System.Drawing.Point(276, 71);
            this.txt_produit.MaxLength = 50;
            this.txt_produit.Name = "txt_produit";
            this.txt_produit.PasswordChar = '\0';
            this.txt_produit.PromptText = "Entrez le nom de code de l\'approvisionnement";
            this.txt_produit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_produit.SelectedText = "";
            this.txt_produit.SelectionLength = 0;
            this.txt_produit.SelectionStart = 0;
            this.txt_produit.ShortcutsEnabled = true;
            this.txt_produit.ShowClearButton = true;
            this.txt_produit.Size = new System.Drawing.Size(293, 30);
            this.txt_produit.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_produit.TabIndex = 48;
            this.txt_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_produit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_produit.UseSelectable = true;
            this.txt_produit.UseStyleColors = true;
            this.txt_produit.WaterMark = "Entrez le nom de code de l\'approvisionnement";
            this.txt_produit.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_produit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_approvisionnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1291, 615);
            this.Controls.Add(this.txt_produit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_expiration);
            this.Controls.Add(this.dt_date_fabrication);
            this.Controls.Add(this.txt_cout);
            this.Controls.Add(this.txt_quantite);
            this.Controls.Add(this.cbx_depot);
            this.Controls.Add(this.cbx_fournisseur);
            this.Controls.Add(this.dtp_date_approv);
            this.Controls.Add(this.txt_code_approv);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.dtgrid_approvisionnement);
            this.Controls.Add(this.lstbox_equipement);
            this.MaximizeBox = false;
            this.Name = "frm_approvisionnement";
            this.Opacity = 0.9D;
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Approvisionnement produits";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frm_approvisionnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_approvisionnement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstbox_equipement;
        private System.Windows.Forms.DataGridView dtgrid_approvisionnement;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txt_cout;
        private MetroFramework.Controls.MetroTextBox txt_quantite;
        private MetroFramework.Controls.MetroComboBox cbx_depot;
        private MetroFramework.Controls.MetroComboBox cbx_fournisseur;
        private MetroFramework.Controls.MetroDateTime dtp_date_approv;
        private MetroFramework.Controls.MetroTextBox txt_code_approv;
        private MetroFramework.Controls.MetroDateTime dt_date_fabrication;
        private MetroFramework.Controls.MetroDateTime dt_expiration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroTextBox txt_produit;
    }
}