namespace Logistiks.Formulaires
{
    partial class frm_equipement
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
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.dtgrid_equipement = new System.Windows.Forms.DataGridView();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txt_designation_equipement = new MetroFramework.Controls.MetroTextBox();
            this.txt_code_produit = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_categorie = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_equipement)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton3
            // 
            this.metroButton3.DisplayFocus = true;
            this.metroButton3.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton3.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton3.Location = new System.Drawing.Point(23, 217);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(167, 35);
            this.metroButton3.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton3.TabIndex = 5;
            this.metroButton3.Text = "Effacer";
            this.metroButton3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            // 
            // dtgrid_equipement
            // 
            this.dtgrid_equipement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_equipement.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrid_equipement.BackgroundColor = System.Drawing.Color.Black;
            this.dtgrid_equipement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_equipement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_equipement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_equipement.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_equipement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_equipement.GridColor = System.Drawing.Color.White;
            this.dtgrid_equipement.Location = new System.Drawing.Point(20, 258);
            this.dtgrid_equipement.Name = "dtgrid_equipement";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_equipement.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_equipement.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrid_equipement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_equipement.ShowEditingIcon = false;
            this.dtgrid_equipement.Size = new System.Drawing.Size(878, 282);
            this.dtgrid_equipement.TabIndex = 26;
            this.dtgrid_equipement.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_equipement_CellContentClick);
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.metroButton2.Location = new System.Drawing.Point(731, 217);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(167, 35);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 4;
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
            this.metroButton1.Location = new System.Drawing.Point(557, 217);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(167, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Enregistrer";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txt_designation_equipement
            // 
            // 
            // 
            // 
            this.txt_designation_equipement.CustomButton.Image = null;
            this.txt_designation_equipement.CustomButton.Location = new System.Drawing.Point(650, 2);
            this.txt_designation_equipement.CustomButton.Name = "";
            this.txt_designation_equipement.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_designation_equipement.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_designation_equipement.CustomButton.TabIndex = 1;
            this.txt_designation_equipement.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_designation_equipement.CustomButton.UseSelectable = true;
            this.txt_designation_equipement.CustomButton.Visible = false;
            this.txt_designation_equipement.DisplayIcon = true;
            this.txt_designation_equipement.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_designation_equipement.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_designation_equipement.ForeColor = System.Drawing.Color.Lime;
            this.txt_designation_equipement.Lines = new string[0];
            this.txt_designation_equipement.Location = new System.Drawing.Point(178, 159);
            this.txt_designation_equipement.MaxLength = 50;
            this.txt_designation_equipement.Name = "txt_designation_equipement";
            this.txt_designation_equipement.PasswordChar = '\0';
            this.txt_designation_equipement.PromptText = "Entrez le vrai nom du produit";
            this.txt_designation_equipement.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_designation_equipement.SelectedText = "";
            this.txt_designation_equipement.SelectionLength = 0;
            this.txt_designation_equipement.SelectionStart = 0;
            this.txt_designation_equipement.ShortcutsEnabled = true;
            this.txt_designation_equipement.ShowClearButton = true;
            this.txt_designation_equipement.Size = new System.Drawing.Size(678, 30);
            this.txt_designation_equipement.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_designation_equipement.TabIndex = 4;
            this.txt_designation_equipement.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_designation_equipement.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_designation_equipement.UseSelectable = true;
            this.txt_designation_equipement.UseStyleColors = true;
            this.txt_designation_equipement.WaterMark = "Entrez le vrai nom du produit";
            this.txt_designation_equipement.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_designation_equipement.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_code_produit
            // 
            // 
            // 
            // 
            this.txt_code_produit.CustomButton.Image = null;
            this.txt_code_produit.CustomButton.Location = new System.Drawing.Point(314, 2);
            this.txt_code_produit.CustomButton.Name = "";
            this.txt_code_produit.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_code_produit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_produit.CustomButton.TabIndex = 1;
            this.txt_code_produit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_code_produit.CustomButton.UseSelectable = true;
            this.txt_code_produit.CustomButton.Visible = false;
            this.txt_code_produit.DisplayIcon = true;
            this.txt_code_produit.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_code_produit.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_code_produit.ForeColor = System.Drawing.Color.Lime;
            this.txt_code_produit.Lines = new string[0];
            this.txt_code_produit.Location = new System.Drawing.Point(178, 93);
            this.txt_code_produit.MaxLength = 50;
            this.txt_code_produit.Name = "txt_code_produit";
            this.txt_code_produit.PasswordChar = '\0';
            this.txt_code_produit.PromptText = "Entrez le nom de codu produit";
            this.txt_code_produit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_code_produit.SelectedText = "";
            this.txt_code_produit.SelectionLength = 0;
            this.txt_code_produit.SelectionStart = 0;
            this.txt_code_produit.ShortcutsEnabled = true;
            this.txt_code_produit.ShowClearButton = true;
            this.txt_code_produit.Size = new System.Drawing.Size(342, 30);
            this.txt_code_produit.Style = MetroFramework.MetroColorStyle.Red;
            this.txt_code_produit.TabIndex = 2;
            this.txt_code_produit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code_produit.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_code_produit.UseSelectable = true;
            this.txt_code_produit.UseStyleColors = true;
            this.txt_code_produit.WaterMark = "Entrez le nom de codu produit";
            this.txt_code_produit.WaterMarkColor = System.Drawing.Color.Crimson;
            this.txt_code_produit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Code du produit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Libelle du produit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(534, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 28;
            this.label3.Text = "Categorie";
            // 
            // cbx_categorie
            // 
            this.cbx_categorie.FormattingEnabled = true;
            this.cbx_categorie.ItemHeight = 23;
            this.cbx_categorie.Location = new System.Drawing.Point(563, 94);
            this.cbx_categorie.Name = "cbx_categorie";
            this.cbx_categorie.PromptText = "Chosissez la categorie";
            this.cbx_categorie.Size = new System.Drawing.Size(293, 29);
            this.cbx_categorie.Style = MetroFramework.MetroColorStyle.Red;
            this.cbx_categorie.TabIndex = 35;
            this.cbx_categorie.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_categorie.UseSelectable = true;
            // 
            // frm_equipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 560);
            this.Controls.Add(this.cbx_categorie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_designation_equipement);
            this.Controls.Add(this.txt_code_produit);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.dtgrid_equipement);
            this.MaximizeBox = false;
            this.Name = "frm_equipement";
            this.Resizable = false;
            this.Text = "Informations sur le produit";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frm_equipement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_equipement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.DataGridView dtgrid_equipement;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txt_designation_equipement;
        private MetroFramework.Controls.MetroTextBox txt_code_produit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbx_categorie;
    }
}