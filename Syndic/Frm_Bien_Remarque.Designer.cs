namespace Syndic
{
    partial class Frm_Bien_Remarque
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
            this.button1 = new System.Windows.Forms.Button();
            this.movePrecedent = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.moveFirst = new System.Windows.Forms.Button();
            this.btn_Bien_rem_Supprimer = new System.Windows.Forms.Button();
            this.btn_Bien_rem_modifier = new System.Windows.Forms.Button();
            this.btn_Bien_rem_Ajouter = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.grid_bien_rem = new System.Windows.Forms.DataGridView();
            this.txt_nomfich = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grp_fichier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bien_rem)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_fichier
            // 
            this.grp_fichier.Controls.Add(this.button1);
            this.grp_fichier.Controls.Add(this.movePrecedent);
            this.grp_fichier.Controls.Add(this.MoveNext);
            this.grp_fichier.Controls.Add(this.MoveLast);
            this.grp_fichier.Controls.Add(this.moveFirst);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_Supprimer);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_modifier);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_Ajouter);
            this.grp_fichier.Controls.Add(this.btn_rechercher);
            this.grp_fichier.Controls.Add(this.grid_bien_rem);
            this.grp_fichier.Controls.Add(this.txt_nomfich);
            this.grp_fichier.Controls.Add(this.label8);
            this.grp_fichier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_fichier.Location = new System.Drawing.Point(12, 31);
            this.grp_fichier.Name = "grp_fichier";
            this.grp_fichier.Size = new System.Drawing.Size(746, 569);
            this.grp_fichier.TabIndex = 31;
            this.grp_fichier.TabStop = false;
            this.grp_fichier.Text = "Remarque";
            this.grp_fichier.Enter += new System.EventHandler(this.grp_fichier_Enter);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(583, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 42;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // movePrecedent
            // 
            this.movePrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.movePrecedent.FlatAppearance.BorderSize = 0;
            this.movePrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrecedent.ForeColor = System.Drawing.Color.White;
            this.movePrecedent.Location = new System.Drawing.Point(78, 485);
            this.movePrecedent.Name = "movePrecedent";
            this.movePrecedent.Size = new System.Drawing.Size(47, 36);
            this.movePrecedent.TabIndex = 41;
            this.movePrecedent.Text = "<";
            this.movePrecedent.UseVisualStyleBackColor = false;
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.MoveNext.FlatAppearance.BorderSize = 0;
            this.MoveNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(144, 485);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(47, 36);
            this.MoveNext.TabIndex = 40;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.MoveLast.FlatAppearance.BorderSize = 0;
            this.MoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(197, 485);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(47, 36);
            this.MoveLast.TabIndex = 39;
            this.MoveLast.Text = ">>";
            this.MoveLast.UseVisualStyleBackColor = false;
            // 
            // moveFirst
            // 
            this.moveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.moveFirst.FlatAppearance.BorderSize = 0;
            this.moveFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFirst.ForeColor = System.Drawing.Color.White;
            this.moveFirst.Location = new System.Drawing.Point(26, 485);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(47, 36);
            this.moveFirst.TabIndex = 37;
            this.moveFirst.Text = "<<";
            this.moveFirst.UseVisualStyleBackColor = false;
            // 
            // btn_Bien_rem_Supprimer
            // 
            this.btn_Bien_rem_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_rem_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Bien_rem_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_rem_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_rem_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_rem_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_rem_Supprimer.Location = new System.Drawing.Point(611, 485);
            this.btn_Bien_rem_Supprimer.Name = "btn_Bien_rem_Supprimer";
            this.btn_Bien_rem_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_rem_Supprimer.TabIndex = 38;
            this.btn_Bien_rem_Supprimer.Text = "Supprimer";
            this.btn_Bien_rem_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Bien_rem_Supprimer.Click += new System.EventHandler(this.btn_Bien_rem_Supprimer_Click);
            // 
            // btn_Bien_rem_modifier
            // 
            this.btn_Bien_rem_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_rem_modifier.FlatAppearance.BorderSize = 0;
            this.btn_Bien_rem_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_rem_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_rem_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_rem_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_rem_modifier.Location = new System.Drawing.Point(489, 485);
            this.btn_Bien_rem_modifier.Name = "btn_Bien_rem_modifier";
            this.btn_Bien_rem_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_rem_modifier.TabIndex = 36;
            this.btn_Bien_rem_modifier.Text = "Modifier";
            this.btn_Bien_rem_modifier.UseVisualStyleBackColor = false;
            this.btn_Bien_rem_modifier.Click += new System.EventHandler(this.btn_Bien_rem_Supprimer_Click);
            // 
            // btn_Bien_rem_Ajouter
            // 
            this.btn_Bien_rem_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_rem_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Bien_rem_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_rem_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_rem_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_rem_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_rem_Ajouter.Location = new System.Drawing.Point(367, 485);
            this.btn_Bien_rem_Ajouter.Name = "btn_Bien_rem_Ajouter";
            this.btn_Bien_rem_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_rem_Ajouter.TabIndex = 35;
            this.btn_Bien_rem_Ajouter.Text = "Ajouter";
            this.btn_Bien_rem_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Bien_rem_Ajouter.Click += new System.EventHandler(this.btn_Bien_rem_Supprimer_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_rechercher.FlatAppearance.BorderSize = 0;
            this.btn_rechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Location = new System.Drawing.Point(583, 28);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(0, 0);
            this.btn_rechercher.TabIndex = 32;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            // 
            // grid_bien_rem
            // 
            this.grid_bien_rem.AllowUserToAddRows = false;
            this.grid_bien_rem.AllowUserToDeleteRows = false;
            this.grid_bien_rem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_bien_rem.Location = new System.Drawing.Point(22, 77);
            this.grid_bien_rem.Name = "grid_bien_rem";
            this.grid_bien_rem.ReadOnly = true;
            this.grid_bien_rem.Size = new System.Drawing.Size(705, 328);
            this.grid_bien_rem.TabIndex = 9;
            // 
            // txt_nomfich
            // 
            this.txt_nomfich.Location = new System.Drawing.Point(126, 39);
            this.txt_nomfich.Name = "txt_nomfich";
            this.txt_nomfich.Size = new System.Drawing.Size(264, 23);
            this.txt_nomfich.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "Nom  :";
            // 
            // Frm_Bien_Remarque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.grp_fichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(12, 31);
            this.Name = "Frm_Bien_Remarque";
            this.Text = "Frm_Bien_Remarque";
            this.Load += new System.EventHandler(this.Frm_Bien_Remarque_Load);
            this.grp_fichier.ResumeLayout(false);
            this.grp_fichier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_bien_rem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_fichier;
        private System.Windows.Forms.DataGridView grid_bien_rem;
        private System.Windows.Forms.TextBox txt_nomfich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button movePrecedent;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button btn_Bien_rem_Supprimer;
        private System.Windows.Forms.Button btn_Bien_rem_modifier;
        private System.Windows.Forms.Button btn_Bien_rem_Ajouter;
        private System.Windows.Forms.Button button1;
    }
}