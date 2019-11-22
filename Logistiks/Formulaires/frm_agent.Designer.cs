namespace Logistiks.Formulaires
{
    partial class frm_agent
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
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.dtgrid_agent = new System.Windows.Forms.DataGridView();
            this.txt_noms_agent = new MetroFramework.Controls.MetroTextBox();
            this.txt_fonction = new MetroFramework.Controls.MetroTextBox();
            this.txt_code_client = new MetroFramework.Controls.MetroTextBox();
            this.txt_telephone = new MetroFramework.Controls.MetroTextBox();
            this.txt_adresse = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_agent)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.DisplayFocus = true;
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton1.Location = new System.Drawing.Point(636, 315);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(122, 35);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Enregistrer";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.DisplayFocus = true;
            this.metroButton2.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton2.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.metroButton2.Location = new System.Drawing.Point(764, 315);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(122, 35);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.TabIndex = 4;
            this.metroButton2.Text = "Supprimer";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // dtgrid_agent
            // 
            this.dtgrid_agent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrid_agent.BackgroundColor = System.Drawing.Color.Black;
            this.dtgrid_agent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_agent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrid_agent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrid_agent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrid_agent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgrid_agent.GridColor = System.Drawing.Color.White;
            this.dtgrid_agent.Location = new System.Drawing.Point(20, 356);
            this.dtgrid_agent.Name = "dtgrid_agent";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgrid_agent.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgrid_agent.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgrid_agent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid_agent.ShowEditingIcon = false;
            this.dtgrid_agent.Size = new System.Drawing.Size(864, 174);
            this.dtgrid_agent.TabIndex = 18;
            this.dtgrid_agent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_agent_CellContentClick);
            // 
            // txt_noms_agent
            // 
            // 
            // 
            // 
            this.txt_noms_agent.CustomButton.Image = null;
            this.txt_noms_agent.CustomButton.Location = new System.Drawing.Point(801, 2);
            this.txt_noms_agent.CustomButton.Name = "";
            this.txt_noms_agent.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_noms_agent.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_noms_agent.CustomButton.TabIndex = 1;
            this.txt_noms_agent.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_noms_agent.CustomButton.UseSelectable = true;
            this.txt_noms_agent.CustomButton.Visible = false;
            this.txt_noms_agent.DisplayIcon = true;
            this.txt_noms_agent.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_noms_agent.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_noms_agent.ForeColor = System.Drawing.Color.Lime;
            this.txt_noms_agent.Lines = new string[0];
            this.txt_noms_agent.Location = new System.Drawing.Point(57, 141);
            this.txt_noms_agent.MaxLength = 50;
            this.txt_noms_agent.Name = "txt_noms_agent";
            this.txt_noms_agent.PasswordChar = '\0';
            this.txt_noms_agent.PromptText = "Entrez les noms du client";
            this.txt_noms_agent.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_noms_agent.SelectedText = "";
            this.txt_noms_agent.SelectionLength = 0;
            this.txt_noms_agent.SelectionStart = 0;
            this.txt_noms_agent.ShortcutsEnabled = true;
            this.txt_noms_agent.ShowClearButton = true;
            this.txt_noms_agent.Size = new System.Drawing.Size(829, 30);
            this.txt_noms_agent.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_noms_agent.TabIndex = 20;
            this.txt_noms_agent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_noms_agent.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_noms_agent.UseSelectable = true;
            this.txt_noms_agent.UseStyleColors = true;
            this.txt_noms_agent.WaterMark = "Entrez les noms du client";
            this.txt_noms_agent.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_noms_agent.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_fonction
            // 
            // 
            // 
            // 
            this.txt_fonction.CustomButton.Image = null;
            this.txt_fonction.CustomButton.Location = new System.Drawing.Point(801, 2);
            this.txt_fonction.CustomButton.Name = "";
            this.txt_fonction.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_fonction.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fonction.CustomButton.TabIndex = 1;
            this.txt_fonction.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_fonction.CustomButton.UseSelectable = true;
            this.txt_fonction.CustomButton.Visible = false;
            this.txt_fonction.DisplayIcon = true;
            this.txt_fonction.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_fonction.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_fonction.ForeColor = System.Drawing.Color.Lime;
            this.txt_fonction.Lines = new string[0];
            this.txt_fonction.Location = new System.Drawing.Point(57, 207);
            this.txt_fonction.MaxLength = 50;
            this.txt_fonction.Name = "txt_fonction";
            this.txt_fonction.PasswordChar = '\0';
            this.txt_fonction.PromptText = "Entrez la fonction de l\'agent";
            this.txt_fonction.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_fonction.SelectedText = "";
            this.txt_fonction.SelectionLength = 0;
            this.txt_fonction.SelectionStart = 0;
            this.txt_fonction.ShortcutsEnabled = true;
            this.txt_fonction.ShowClearButton = true;
            this.txt_fonction.Size = new System.Drawing.Size(829, 30);
            this.txt_fonction.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_fonction.TabIndex = 29;
            this.txt_fonction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_fonction.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_fonction.UseSelectable = true;
            this.txt_fonction.UseStyleColors = true;
            this.txt_fonction.WaterMark = "Entrez la fonction de l\'agent";
            this.txt_fonction.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_fonction.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_code_client
            // 
            // 
            // 
            // 
            this.txt_code_client.CustomButton.Image = null;
            this.txt_code_client.CustomButton.Location = new System.Drawing.Point(309, 2);
            this.txt_code_client.CustomButton.Name = "";
            this.txt_code_client.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_code_client.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_client.CustomButton.TabIndex = 1;
            this.txt_code_client.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_code_client.CustomButton.UseSelectable = true;
            this.txt_code_client.CustomButton.Visible = false;
            this.txt_code_client.DisplayIcon = true;
            this.txt_code_client.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_code_client.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_code_client.ForeColor = System.Drawing.Color.Lime;
            this.txt_code_client.Lines = new string[0];
            this.txt_code_client.Location = new System.Drawing.Point(57, 84);
            this.txt_code_client.MaxLength = 50;
            this.txt_code_client.Name = "txt_code_client";
            this.txt_code_client.PasswordChar = '\0';
            this.txt_code_client.PromptText = "Entrez le code agent";
            this.txt_code_client.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_code_client.SelectedText = "";
            this.txt_code_client.SelectionLength = 0;
            this.txt_code_client.SelectionStart = 0;
            this.txt_code_client.ShortcutsEnabled = true;
            this.txt_code_client.ShowClearButton = true;
            this.txt_code_client.Size = new System.Drawing.Size(337, 30);
            this.txt_code_client.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_code_client.TabIndex = 19;
            this.txt_code_client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_code_client.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_code_client.UseSelectable = true;
            this.txt_code_client.UseStyleColors = true;
            this.txt_code_client.WaterMark = "Entrez le code agent";
            this.txt_code_client.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_code_client.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txt_code_client.TextChanged += new System.EventHandler(this.txt_code_client_TextChanged);
            // 
            // txt_telephone
            // 
            // 
            // 
            // 
            this.txt_telephone.CustomButton.Image = null;
            this.txt_telephone.CustomButton.Location = new System.Drawing.Point(309, 2);
            this.txt_telephone.CustomButton.Name = "";
            this.txt_telephone.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_telephone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_telephone.CustomButton.TabIndex = 1;
            this.txt_telephone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_telephone.CustomButton.UseSelectable = true;
            this.txt_telephone.CustomButton.Visible = false;
            this.txt_telephone.DisplayIcon = true;
            this.txt_telephone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_telephone.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_telephone.ForeColor = System.Drawing.Color.Lime;
            this.txt_telephone.Lines = new string[0];
            this.txt_telephone.Location = new System.Drawing.Point(57, 264);
            this.txt_telephone.MaxLength = 50;
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.PasswordChar = '\0';
            this.txt_telephone.PromptText = "Entrez le numero de telephone";
            this.txt_telephone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_telephone.SelectedText = "";
            this.txt_telephone.SelectionLength = 0;
            this.txt_telephone.SelectionStart = 0;
            this.txt_telephone.ShortcutsEnabled = true;
            this.txt_telephone.ShowClearButton = true;
            this.txt_telephone.Size = new System.Drawing.Size(337, 30);
            this.txt_telephone.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_telephone.TabIndex = 28;
            this.txt_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_telephone.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_telephone.UseSelectable = true;
            this.txt_telephone.UseStyleColors = true;
            this.txt_telephone.WaterMark = "Entrez le numero de telephone";
            this.txt_telephone.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_telephone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txt_adresse
            // 
            // 
            // 
            // 
            this.txt_adresse.CustomButton.Image = null;
            this.txt_adresse.CustomButton.Location = new System.Drawing.Point(319, 2);
            this.txt_adresse.CustomButton.Name = "";
            this.txt_adresse.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txt_adresse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_adresse.CustomButton.TabIndex = 1;
            this.txt_adresse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_adresse.CustomButton.UseSelectable = true;
            this.txt_adresse.CustomButton.Visible = false;
            this.txt_adresse.DisplayIcon = true;
            this.txt_adresse.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_adresse.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txt_adresse.ForeColor = System.Drawing.Color.Lime;
            this.txt_adresse.Lines = new string[0];
            this.txt_adresse.Location = new System.Drawing.Point(539, 264);
            this.txt_adresse.MaxLength = 100;
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.PasswordChar = '\0';
            this.txt_adresse.PromptText = "Entrez l\'adresse du domicile";
            this.txt_adresse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_adresse.SelectedText = "";
            this.txt_adresse.SelectionLength = 0;
            this.txt_adresse.SelectionStart = 0;
            this.txt_adresse.ShortcutsEnabled = true;
            this.txt_adresse.ShowClearButton = true;
            this.txt_adresse.Size = new System.Drawing.Size(347, 30);
            this.txt_adresse.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_adresse.TabIndex = 27;
            this.txt_adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adresse.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txt_adresse.UseSelectable = true;
            this.txt_adresse.UseStyleColors = true;
            this.txt_adresse.WaterMark = "Entrez l\'adresse du domicile";
            this.txt_adresse.WaterMarkColor = System.Drawing.Color.DeepSkyBlue;
            this.txt_adresse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 30;
            this.label1.Text = "Code Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Noms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "Fonction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 21);
            this.label4.TabIndex = 33;
            this.label4.Text = "Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(495, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 21);
            this.label5.TabIndex = 34;
            this.label5.Text = "Adresse";
            // 
            // frm_agent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 550);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_noms_agent);
            this.Controls.Add(this.txt_fonction);
            this.Controls.Add(this.txt_code_client);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.dtgrid_agent);
            this.MaximizeBox = false;
            this.Name = "frm_agent";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Text = "Informations sur les agents";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.frm_agent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid_agent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private System.Windows.Forms.DataGridView dtgrid_agent;
        private MetroFramework.Controls.MetroTextBox txt_noms_agent;
        private MetroFramework.Controls.MetroTextBox txt_fonction;
        private MetroFramework.Controls.MetroTextBox txt_code_client;
        private MetroFramework.Controls.MetroTextBox txt_telephone;
        private MetroFramework.Controls.MetroTextBox txt_adresse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}