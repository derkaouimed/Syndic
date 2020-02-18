namespace Syndic
{
    partial class Frm_Bien1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bien1));
            this.grp_fichier = new System.Windows.Forms.GroupBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.txt_nomfich = new System.Windows.Forms.TextBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_Bien_Supprimer = new System.Windows.Forms.Button();
            this.btn_Bien_modifier = new System.Windows.Forms.Button();
            this.btn_Bien_Ajouter = new System.Windows.Forms.Button();
            this.gridBien = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.grp_fichier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBien)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_fichier
            // 
            this.grp_fichier.Controls.Add(this.btn_suivant);
            this.grp_fichier.Controls.Add(this.btn_precedent);
            this.grp_fichier.Controls.Add(this.btn_derniere);
            this.grp_fichier.Controls.Add(this.btn_premiere);
            this.grp_fichier.Controls.Add(this.txt_nomfich);
            this.grp_fichier.Controls.Add(this.btn_rechercher);
            this.grp_fichier.Controls.Add(this.btn_Bien_Supprimer);
            this.grp_fichier.Controls.Add(this.btn_Bien_modifier);
            this.grp_fichier.Controls.Add(this.btn_Bien_Ajouter);
            this.grp_fichier.Controls.Add(this.gridBien);
            this.grp_fichier.Controls.Add(this.label8);
            this.grp_fichier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_fichier.Location = new System.Drawing.Point(12, 31);
            this.grp_fichier.Name = "grp_fichier";
            this.grp_fichier.Size = new System.Drawing.Size(746, 569);
            this.grp_fichier.TabIndex = 26;
            this.grp_fichier.TabStop = false;
            this.grp_fichier.Text = "Bien";
            this.grp_fichier.Enter += new System.EventHandler(this.grp_fichier_Enter);
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
            this.btn_suivant.Location = new System.Drawing.Point(152, 486);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 52;
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
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
            this.btn_precedent.Location = new System.Drawing.Point(74, 486);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 51;
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
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
            this.btn_derniere.Location = new System.Drawing.Point(204, 486);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 53;
            this.btn_derniere.UseVisualStyleBackColor = false;
            this.btn_derniere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_premiere
            // 
            this.btn_premiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_premiere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_premiere.BackgroundImage")));
            this.btn_premiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_premiere.FlatAppearance.BorderSize = 0;
            this.btn_premiere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_premiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_premiere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_premiere.ForeColor = System.Drawing.Color.White;
            this.btn_premiere.Location = new System.Drawing.Point(22, 486);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 50;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // txt_nomfich
            // 
            this.txt_nomfich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomfich.ForeColor = System.Drawing.Color.Gray;
            this.txt_nomfich.Location = new System.Drawing.Point(174, 28);
            this.txt_nomfich.Name = "txt_nomfich";
            this.txt_nomfich.Size = new System.Drawing.Size(309, 27);
            this.txt_nomfich.TabIndex = 27;
            this.txt_nomfich.Text = "Chercher Par Nom";
            this.txt_nomfich.Enter += new System.EventHandler(this.txt_nomfich_Enter);
            this.txt_nomfich.Leave += new System.EventHandler(this.txt_nomfich_Leave);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_rechercher.FlatAppearance.BorderSize = 0;
            this.btn_rechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Location = new System.Drawing.Point(583, 25);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(144, 34);
            this.btn_rechercher.TabIndex = 26;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // btn_Bien_Supprimer
            // 
            this.btn_Bien_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Bien_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_Supprimer.Location = new System.Drawing.Point(611, 486);
            this.btn_Bien_Supprimer.Name = "btn_Bien_Supprimer";
            this.btn_Bien_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_Supprimer.TabIndex = 22;
            this.btn_Bien_Supprimer.Text = "Supprimer";
            this.btn_Bien_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Bien_Supprimer.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
            // 
            // btn_Bien_modifier
            // 
            this.btn_Bien_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_modifier.FlatAppearance.BorderSize = 0;
            this.btn_Bien_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_modifier.Location = new System.Drawing.Point(489, 486);
            this.btn_Bien_modifier.Name = "btn_Bien_modifier";
            this.btn_Bien_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_modifier.TabIndex = 20;
            this.btn_Bien_modifier.Text = "Modifier";
            this.btn_Bien_modifier.UseVisualStyleBackColor = false;
            this.btn_Bien_modifier.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
            // 
            // btn_Bien_Ajouter
            // 
            this.btn_Bien_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Bien_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_Ajouter.Location = new System.Drawing.Point(367, 486);
            this.btn_Bien_Ajouter.Name = "btn_Bien_Ajouter";
            this.btn_Bien_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_Ajouter.TabIndex = 19;
            this.btn_Bien_Ajouter.Text = "Ajouter";
            this.btn_Bien_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Bien_Ajouter.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
            // 
            // gridBien
            // 
            this.gridBien.AllowUserToAddRows = false;
            this.gridBien.AllowUserToDeleteRows = false;
            this.gridBien.BackgroundColor = System.Drawing.Color.White;
            this.gridBien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBien.Location = new System.Drawing.Point(22, 77);
            this.gridBien.Name = "gridBien";
            this.gridBien.ReadOnly = true;
            this.gridBien.Size = new System.Drawing.Size(705, 328);
            this.gridBien.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nom  Appartement :";
            // 
            // Frm_Bien1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.grp_fichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Bien1";
            this.Text = "Frm_Bien1";
            this.Load += new System.EventHandler(this.Frm_Bien1_Load);
            this.grp_fichier.ResumeLayout(false);
            this.grp_fichier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_fichier;
        private System.Windows.Forms.DataGridView gridBien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Bien_Supprimer;
        private System.Windows.Forms.Button btn_Bien_modifier;
        private System.Windows.Forms.Button btn_Bien_Ajouter;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.TextBox txt_nomfich;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
    }
}