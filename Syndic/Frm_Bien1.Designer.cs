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
            this.grp_fichier = new System.Windows.Forms.GroupBox();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.movePrecedent = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.moveFirst = new System.Windows.Forms.Button();
            this.btn_Bien_Supprimer = new System.Windows.Forms.Button();
            this.btn_Bien_modifier = new System.Windows.Forms.Button();
            this.btn_Bien_Ajouter = new System.Windows.Forms.Button();
            this.gridBien = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_nomfich = new System.Windows.Forms.TextBox();
            this.grp_fichier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBien)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_fichier
            // 
            this.grp_fichier.Controls.Add(this.txt_nomfich);
            this.grp_fichier.Controls.Add(this.btn_rechercher);
            this.grp_fichier.Controls.Add(this.movePrecedent);
            this.grp_fichier.Controls.Add(this.MoveNext);
            this.grp_fichier.Controls.Add(this.MoveLast);
            this.grp_fichier.Controls.Add(this.moveFirst);
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
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
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
            // movePrecedent
            // 
            this.movePrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatAppearance.BorderSize = 0;
            this.movePrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrecedent.ForeColor = System.Drawing.Color.White;
            this.movePrecedent.Location = new System.Drawing.Point(79, 486);
            this.movePrecedent.Name = "movePrecedent";
            this.movePrecedent.Size = new System.Drawing.Size(47, 36);
            this.movePrecedent.TabIndex = 25;
            this.movePrecedent.Text = "<";
            this.movePrecedent.UseVisualStyleBackColor = false;
            this.movePrecedent.Click += new System.EventHandler(this.movePrecedent_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatAppearance.BorderSize = 0;
            this.MoveNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(145, 486);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(47, 36);
            this.MoveNext.TabIndex = 24;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            this.MoveNext.Click += new System.EventHandler(this.MoveNext_Click);
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatAppearance.BorderSize = 0;
            this.MoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(198, 486);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(47, 36);
            this.MoveLast.TabIndex = 23;
            this.MoveLast.Text = ">>";
            this.MoveLast.UseVisualStyleBackColor = false;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // moveFirst
            // 
            this.moveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatAppearance.BorderSize = 0;
            this.moveFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFirst.ForeColor = System.Drawing.Color.White;
            this.moveFirst.Location = new System.Drawing.Point(26, 486);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(47, 36);
            this.moveFirst.TabIndex = 21;
            this.moveFirst.Text = "<<";
            this.moveFirst.UseVisualStyleBackColor = false;
            this.moveFirst.Click += new System.EventHandler(this.moveFirst_Click);
            // 
            // btn_Bien_Supprimer
            // 
            this.btn_Bien_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
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
            this.btn_Bien_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
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
            this.btn_Bien_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
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
            // txt_nomfich
            // 
            this.txt_nomfich.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomfich.ForeColor = System.Drawing.Color.Gray;
            this.txt_nomfich.Location = new System.Drawing.Point(174, 28);
            this.txt_nomfich.Name = "txt_nomfich";
            this.txt_nomfich.Size = new System.Drawing.Size(309, 27);
            this.txt_nomfich.TabIndex = 27;
            this.txt_nomfich.Text = "Chercher Par Nom";
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
        private System.Windows.Forms.Button movePrecedent;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button btn_Bien_Supprimer;
        private System.Windows.Forms.Button btn_Bien_modifier;
        private System.Windows.Forms.Button btn_Bien_Ajouter;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.TextBox txt_nomfich;
    }
}