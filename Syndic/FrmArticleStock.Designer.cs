namespace Syndic
{
    partial class FrmArticleStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmArticleStock));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_utiliser = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premier = new System.Windows.Forms.Button();
            this.btn_chercher_designation = new System.Windows.Forms.Button();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.dt_grid = new System.Windows.Forms.DataGridView();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.grp_chercher = new System.Windows.Forms.GroupBox();
            this.rd_rubrique = new System.Windows.Forms.RadioButton();
            this.rd_IDdesination = new System.Windows.Forms.RadioButton();
            this.pnl_designation = new System.Windows.Forms.Panel();
            this.pnl_rubrique = new System.Windows.Forms.Panel();
            this.cb_rubrique = new System.Windows.Forms.ComboBox();
            this.btn_chercher_rubrique = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).BeginInit();
            this.grp_chercher.SuspendLayout();
            this.pnl_designation.SuspendLayout();
            this.pnl_rubrique.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_utiliser
            // 
            this.btn_utiliser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utiliser.FlatAppearance.BorderSize = 0;
            this.btn_utiliser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_utiliser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utiliser.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utiliser.ForeColor = System.Drawing.Color.White;
            this.btn_utiliser.Location = new System.Drawing.Point(624, 505);
            this.btn_utiliser.Name = "btn_utiliser";
            this.btn_utiliser.Size = new System.Drawing.Size(134, 41);
            this.btn_utiliser.TabIndex = 51;
            this.btn_utiliser.Text = "Utiliser";
            this.btn_utiliser.UseVisualStyleBackColor = false;
            this.btn_utiliser.Click += new System.EventHandler(this.btn_utiliser_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_suivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suivant.BackgroundImage")));
            this.btn_suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_suivant.FlatAppearance.BorderSize = 0;
            this.btn_suivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suivant.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.Location = new System.Drawing.Point(142, 505);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 50;
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_precedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_precedent.BackgroundImage")));
            this.btn_precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_precedent.FlatAppearance.BorderSize = 0;
            this.btn_precedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precedent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_precedent.ForeColor = System.Drawing.Color.White;
            this.btn_precedent.Location = new System.Drawing.Point(65, 505);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 49;
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_derniere
            // 
            this.btn_derniere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_derniere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_derniere.BackgroundImage")));
            this.btn_derniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_derniere.FlatAppearance.BorderSize = 0;
            this.btn_derniere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_derniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derniere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_derniere.ForeColor = System.Drawing.Color.White;
            this.btn_derniere.Location = new System.Drawing.Point(194, 505);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 48;
            this.btn_derniere.UseVisualStyleBackColor = false;
            this.btn_derniere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_premier
            // 
            this.btn_premier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_premier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_premier.BackgroundImage")));
            this.btn_premier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_premier.FlatAppearance.BorderSize = 0;
            this.btn_premier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_premier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_premier.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_premier.ForeColor = System.Drawing.Color.White;
            this.btn_premier.Location = new System.Drawing.Point(13, 505);
            this.btn_premier.Name = "btn_premier";
            this.btn_premier.Size = new System.Drawing.Size(46, 41);
            this.btn_premier.TabIndex = 47;
            this.btn_premier.UseVisualStyleBackColor = false;
            this.btn_premier.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_chercher_designation
            // 
            this.btn_chercher_designation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercher_designation.FlatAppearance.BorderSize = 0;
            this.btn_chercher_designation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercher_designation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercher_designation.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercher_designation.ForeColor = System.Drawing.Color.White;
            this.btn_chercher_designation.Location = new System.Drawing.Point(616, 9);
            this.btn_chercher_designation.Name = "btn_chercher_designation";
            this.btn_chercher_designation.Size = new System.Drawing.Size(115, 27);
            this.btn_chercher_designation.TabIndex = 46;
            this.btn_chercher_designation.Text = "Rechercher";
            this.btn_chercher_designation.UseVisualStyleBackColor = false;
            this.btn_chercher_designation.Click += new System.EventHandler(this.btn_chercher_rubrique_Click);
            // 
            // txt_chercher
            // 
            this.txt_chercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher.Location = new System.Drawing.Point(19, 9);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(591, 27);
            this.txt_chercher.TabIndex = 45;
            this.txt_chercher.Text = "Tapez ID Article Ou Designation Pour Rechercher";
            this.txt_chercher.Enter += new System.EventHandler(this.txt_chercher_Enter);
            this.txt_chercher.Leave += new System.EventHandler(this.txt_chercher_Leave);
            // 
            // dt_grid
            // 
            this.dt_grid.AllowUserToAddRows = false;
            this.dt_grid.AllowUserToDeleteRows = false;
            this.dt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_grid.ColumnHeadersHeight = 35;
            this.dt_grid.Location = new System.Drawing.Point(12, 147);
            this.dt_grid.Name = "dt_grid";
            this.dt_grid.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_grid.Size = new System.Drawing.Size(746, 350);
            this.dt_grid.TabIndex = 44;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_modifier.FlatAppearance.BorderSize = 0;
            this.btn_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modifier.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_modifier.Location = new System.Drawing.Point(152, 559);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(134, 41);
            this.btn_modifier.TabIndex = 54;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = false;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(292, 559);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(134, 41);
            this.btn_supprimer.TabIndex = 53;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_ajouter.FlatAppearance.BorderSize = 0;
            this.btn_ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ajouter.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_ajouter.Location = new System.Drawing.Point(12, 559);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(134, 41);
            this.btn_ajouter.TabIndex = 52;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = false;
            // 
            // grp_chercher
            // 
            this.grp_chercher.Controls.Add(this.rd_rubrique);
            this.grp_chercher.Controls.Add(this.rd_IDdesination);
            this.grp_chercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_chercher.Location = new System.Drawing.Point(13, 12);
            this.grp_chercher.Name = "grp_chercher";
            this.grp_chercher.Size = new System.Drawing.Size(745, 76);
            this.grp_chercher.TabIndex = 55;
            this.grp_chercher.TabStop = false;
            this.grp_chercher.Text = "Recherche Par :";
            // 
            // rd_rubrique
            // 
            this.rd_rubrique.AutoSize = true;
            this.rd_rubrique.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_rubrique.Location = new System.Drawing.Point(380, 35);
            this.rd_rubrique.Name = "rd_rubrique";
            this.rd_rubrique.Size = new System.Drawing.Size(126, 22);
            this.rd_rubrique.TabIndex = 1;
            this.rd_rubrique.Text = "Nom Rubrique";
            this.rd_rubrique.UseVisualStyleBackColor = true;
            this.rd_rubrique.CheckedChanged += new System.EventHandler(this.rd_IDdesination_CheckedChanged);
            // 
            // rd_IDdesination
            // 
            this.rd_IDdesination.AutoSize = true;
            this.rd_IDdesination.Checked = true;
            this.rd_IDdesination.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_IDdesination.Location = new System.Drawing.Point(181, 35);
            this.rd_IDdesination.Name = "rd_IDdesination";
            this.rd_IDdesination.Size = new System.Drawing.Size(153, 22);
            this.rd_IDdesination.TabIndex = 0;
            this.rd_IDdesination.TabStop = true;
            this.rd_IDdesination.Text = "ID Ou Designation";
            this.rd_IDdesination.UseVisualStyleBackColor = true;
            this.rd_IDdesination.CheckedChanged += new System.EventHandler(this.rd_IDdesination_CheckedChanged);
            // 
            // pnl_designation
            // 
            this.pnl_designation.Controls.Add(this.btn_chercher_designation);
            this.pnl_designation.Controls.Add(this.txt_chercher);
            this.pnl_designation.Location = new System.Drawing.Point(13, 93);
            this.pnl_designation.Name = "pnl_designation";
            this.pnl_designation.Size = new System.Drawing.Size(741, 45);
            this.pnl_designation.TabIndex = 56;
            // 
            // pnl_rubrique
            // 
            this.pnl_rubrique.Controls.Add(this.cb_rubrique);
            this.pnl_rubrique.Controls.Add(this.btn_chercher_rubrique);
            this.pnl_rubrique.Location = new System.Drawing.Point(13, 93);
            this.pnl_rubrique.Name = "pnl_rubrique";
            this.pnl_rubrique.Size = new System.Drawing.Size(741, 45);
            this.pnl_rubrique.TabIndex = 57;
            // 
            // cb_rubrique
            // 
            this.cb_rubrique.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_rubrique.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_rubrique.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_rubrique.FormattingEnabled = true;
            this.cb_rubrique.Location = new System.Drawing.Point(15, 7);
            this.cb_rubrique.Name = "cb_rubrique";
            this.cb_rubrique.Size = new System.Drawing.Size(591, 29);
            this.cb_rubrique.TabIndex = 47;
            // 
            // btn_chercher_rubrique
            // 
            this.btn_chercher_rubrique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercher_rubrique.FlatAppearance.BorderSize = 0;
            this.btn_chercher_rubrique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercher_rubrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercher_rubrique.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercher_rubrique.ForeColor = System.Drawing.Color.White;
            this.btn_chercher_rubrique.Location = new System.Drawing.Point(616, 9);
            this.btn_chercher_rubrique.Name = "btn_chercher_rubrique";
            this.btn_chercher_rubrique.Size = new System.Drawing.Size(115, 27);
            this.btn_chercher_rubrique.TabIndex = 46;
            this.btn_chercher_rubrique.Text = "Rechercher";
            this.btn_chercher_rubrique.UseVisualStyleBackColor = false;
            this.btn_chercher_rubrique.Click += new System.EventHandler(this.btn_chercher_rubrique_Click);
            // 
            // FrmArticleStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.pnl_rubrique);
            this.Controls.Add(this.pnl_designation);
            this.Controls.Add(this.grp_chercher);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_utiliser);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_premier);
            this.Controls.Add(this.dt_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticleStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArticleStock";
            this.Load += new System.EventHandler(this.FrmArticleStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).EndInit();
            this.grp_chercher.ResumeLayout(false);
            this.grp_chercher.PerformLayout();
            this.pnl_designation.ResumeLayout(false);
            this.pnl_designation.PerformLayout();
            this.pnl_rubrique.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_utiliser;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premier;
        private System.Windows.Forms.Button btn_chercher_designation;
        private System.Windows.Forms.TextBox txt_chercher;
        private System.Windows.Forms.DataGridView dt_grid;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.GroupBox grp_chercher;
        private System.Windows.Forms.RadioButton rd_rubrique;
        private System.Windows.Forms.RadioButton rd_IDdesination;
        private System.Windows.Forms.Panel pnl_designation;
        private System.Windows.Forms.Panel pnl_rubrique;
        private System.Windows.Forms.ComboBox cb_rubrique;
        private System.Windows.Forms.Button btn_chercher_rubrique;
    }
}