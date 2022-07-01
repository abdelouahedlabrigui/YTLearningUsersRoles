namespace YTLearningUsersRoles
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxUserTools = new System.Windows.Forms.GroupBox();
            this.metroSetComboBoxRolesByNames = new MetroSet_UI.Controls.MetroSetComboBox();
            this.metroSetLabelRolesByNames = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetButtonFilterUsersById = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetTextBoxUserId = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabelFilterUserById = new MetroSet_UI.Controls.MetroSetLabel();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.groupBoxUserTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUserTools
            // 
            this.groupBoxUserTools.Controls.Add(this.dataGridViewUsers);
            this.groupBoxUserTools.Controls.Add(this.metroSetLabelFilterUserById);
            this.groupBoxUserTools.Controls.Add(this.metroSetTextBoxUserId);
            this.groupBoxUserTools.Controls.Add(this.metroSetButtonFilterUsersById);
            this.groupBoxUserTools.Controls.Add(this.metroSetLabelRolesByNames);
            this.groupBoxUserTools.Controls.Add(this.metroSetComboBoxRolesByNames);
            this.groupBoxUserTools.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUserTools.Location = new System.Drawing.Point(12, 12);
            this.groupBoxUserTools.Name = "groupBoxUserTools";
            this.groupBoxUserTools.Size = new System.Drawing.Size(776, 426);
            this.groupBoxUserTools.TabIndex = 0;
            this.groupBoxUserTools.TabStop = false;
            this.groupBoxUserTools.Text = "Users Roles ToolBox";
            // 
            // metroSetComboBoxRolesByNames
            // 
            this.metroSetComboBoxRolesByNames.AllowDrop = true;
            this.metroSetComboBoxRolesByNames.ArrowColor = System.Drawing.Color.Aqua;
            this.metroSetComboBoxRolesByNames.BackColor = System.Drawing.Color.Transparent;
            this.metroSetComboBoxRolesByNames.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.metroSetComboBoxRolesByNames.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroSetComboBoxRolesByNames.CausesValidation = false;
            this.metroSetComboBoxRolesByNames.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.metroSetComboBoxRolesByNames.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBoxRolesByNames.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroSetComboBoxRolesByNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.metroSetComboBoxRolesByNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metroSetComboBoxRolesByNames.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetComboBoxRolesByNames.FormattingEnabled = true;
            this.metroSetComboBoxRolesByNames.IsDerivedStyle = true;
            this.metroSetComboBoxRolesByNames.ItemHeight = 20;
            this.metroSetComboBoxRolesByNames.Location = new System.Drawing.Point(279, 57);
            this.metroSetComboBoxRolesByNames.Name = "metroSetComboBoxRolesByNames";
            this.metroSetComboBoxRolesByNames.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetComboBoxRolesByNames.SelectedItemForeColor = System.Drawing.Color.White;
            this.metroSetComboBoxRolesByNames.Size = new System.Drawing.Size(293, 26);
            this.metroSetComboBoxRolesByNames.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetComboBoxRolesByNames.StyleManager = null;
            this.metroSetComboBoxRolesByNames.TabIndex = 0;
            this.metroSetComboBoxRolesByNames.ThemeAuthor = "Narwin";
            this.metroSetComboBoxRolesByNames.ThemeName = "MetroDark";
            // 
            // metroSetLabelRolesByNames
            // 
            this.metroSetLabelRolesByNames.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabelRolesByNames.IsDerivedStyle = true;
            this.metroSetLabelRolesByNames.Location = new System.Drawing.Point(145, 59);
            this.metroSetLabelRolesByNames.Name = "metroSetLabelRolesByNames";
            this.metroSetLabelRolesByNames.Size = new System.Drawing.Size(128, 23);
            this.metroSetLabelRolesByNames.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabelRolesByNames.StyleManager = null;
            this.metroSetLabelRolesByNames.TabIndex = 1;
            this.metroSetLabelRolesByNames.Text = "Roles By Names:";
            this.metroSetLabelRolesByNames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabelRolesByNames.ThemeAuthor = "Narwin";
            this.metroSetLabelRolesByNames.ThemeName = "MetroLite";
            // 
            // metroSetButtonFilterUsersById
            // 
            this.metroSetButtonFilterUsersById.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonFilterUsersById.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonFilterUsersById.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButtonFilterUsersById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetButtonFilterUsersById.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonFilterUsersById.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButtonFilterUsersById.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButtonFilterUsersById.IsDerivedStyle = true;
            this.metroSetButtonFilterUsersById.Location = new System.Drawing.Point(401, 125);
            this.metroSetButtonFilterUsersById.Name = "metroSetButtonFilterUsersById";
            this.metroSetButtonFilterUsersById.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonFilterUsersById.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButtonFilterUsersById.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButtonFilterUsersById.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonFilterUsersById.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButtonFilterUsersById.PressTextColor = System.Drawing.Color.White;
            this.metroSetButtonFilterUsersById.Size = new System.Drawing.Size(171, 32);
            this.metroSetButtonFilterUsersById.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetButtonFilterUsersById.StyleManager = null;
            this.metroSetButtonFilterUsersById.TabIndex = 2;
            this.metroSetButtonFilterUsersById.Text = "Filter";
            this.metroSetButtonFilterUsersById.ThemeAuthor = "Narwin";
            this.metroSetButtonFilterUsersById.ThemeName = "MetroLite";
            this.metroSetButtonFilterUsersById.Click += new System.EventHandler(this.metroSetButtonFilterUsersById_Click);
            // 
            // metroSetTextBoxUserId
            // 
            this.metroSetTextBoxUserId.AutoCompleteCustomSource = null;
            this.metroSetTextBoxUserId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.metroSetTextBoxUserId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.metroSetTextBoxUserId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBoxUserId.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.metroSetTextBoxUserId.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.metroSetTextBoxUserId.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.metroSetTextBoxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetTextBoxUserId.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.metroSetTextBoxUserId.Image = null;
            this.metroSetTextBoxUserId.IsDerivedStyle = true;
            this.metroSetTextBoxUserId.Lines = null;
            this.metroSetTextBoxUserId.Location = new System.Drawing.Point(279, 89);
            this.metroSetTextBoxUserId.MaxLength = 32767;
            this.metroSetTextBoxUserId.Multiline = false;
            this.metroSetTextBoxUserId.Name = "metroSetTextBoxUserId";
            this.metroSetTextBoxUserId.ReadOnly = false;
            this.metroSetTextBoxUserId.Size = new System.Drawing.Size(293, 30);
            this.metroSetTextBoxUserId.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetTextBoxUserId.StyleManager = null;
            this.metroSetTextBoxUserId.TabIndex = 3;
            this.metroSetTextBoxUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.metroSetTextBoxUserId.ThemeAuthor = "Narwin";
            this.metroSetTextBoxUserId.ThemeName = "MetroLite";
            this.metroSetTextBoxUserId.UseSystemPasswordChar = false;
            this.metroSetTextBoxUserId.WatermarkText = "";
            // 
            // metroSetLabelFilterUserById
            // 
            this.metroSetLabelFilterUserById.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabelFilterUserById.IsDerivedStyle = true;
            this.metroSetLabelFilterUserById.Location = new System.Drawing.Point(145, 93);
            this.metroSetLabelFilterUserById.Name = "metroSetLabelFilterUserById";
            this.metroSetLabelFilterUserById.Size = new System.Drawing.Size(128, 23);
            this.metroSetLabelFilterUserById.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabelFilterUserById.StyleManager = null;
            this.metroSetLabelFilterUserById.TabIndex = 4;
            this.metroSetLabelFilterUserById.Text = "Users By Id";
            this.metroSetLabelFilterUserById.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabelFilterUserById.ThemeAuthor = "Narwin";
            this.metroSetLabelFilterUserById.ThemeName = "MetroLite";
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(6, 163);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.Size = new System.Drawing.Size(764, 257);
            this.dataGridViewUsers.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxUserTools);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "YTLearning Users Roles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUserTools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUserTools;
        private MetroSet_UI.Controls.MetroSetComboBox metroSetComboBoxRolesByNames;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabelRolesByNames;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabelFilterUserById;
        private MetroSet_UI.Controls.MetroSetTextBox metroSetTextBoxUserId;
        private MetroSet_UI.Controls.MetroSetButton metroSetButtonFilterUsersById;
    }
}

