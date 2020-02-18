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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bien_Remarque));
            this.grp_fichier = new System.Windows.Forms.GroupBox();
            this.btn_Bien_rem_Supprimer = new System.Windows.Forms.Button();
            this.btn_Bien_rem_modifier = new System.Windows.Forms.Button();
            this.btn_Bien_rem_Ajouter = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.list_bien = new System.Windows.Forms.ListBox();
            this.list_remarque = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_chercher_bien = new System.Windows.Forms.TextBox();
            this.txt_cherch_rem = new System.Windows.Forms.TextBox();
            this.grp_fichier.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_fichier
            // 
            this.grp_fichier.Controls.Add(this.groupBox2);
            this.grp_fichier.Controls.Add(this.groupBox1);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_Supprimer);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_modifier);
            this.grp_fichier.Controls.Add(this.btn_Bien_rem_Ajouter);
            this.grp_fichier.Controls.Add(this.btn_rechercher);
            this.grp_fichier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_fichier.Location = new System.Drawing.Point(12, 31);
            this.grp_fichier.Name = "grp_fichier";
            this.grp_fichier.Size = new System.Drawing.Size(746, 569);
            this.grp_fichier.TabIndex = 31;
            this.grp_fichier.TabStop = false;
            this.grp_fichier.Text = "Remarque";
            this.grp_fichier.Enter += new System.EventHandler(this.grp_fichier_Enter);
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
            // list_bien
            // 
            this.list_bien.FormattingEnabled = true;
            this.list_bien.ItemHeight = 16;
            this.list_bien.Location = new System.Drawing.Point(14, 81);
            this.list_bien.Name = "list_bien";
            this.list_bien.Size = new System.Drawing.Size(253, 308);
            this.list_bien.TabIndex = 43;
            // 
            // list_remarque
            // 
            this.list_remarque.FormattingEnabled = true;
            this.list_remarque.ItemHeight = 16;
            this.list_remarque.Location = new System.Drawing.Point(13, 81);
            this.list_remarque.Name = "list_remarque";
            this.list_remarque.Size = new System.Drawing.Size(354, 308);
            this.list_remarque.TabIndex = 44;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(229, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 34);
            this.button2.TabIndex = 42;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_chercher_bien);
            this.groupBox1.Controls.Add(this.btn_suivant);
            this.groupBox1.Controls.Add(this.btn_precedent);
            this.groupBox1.Controls.Add(this.btn_derniere);
            this.groupBox1.Controls.Add(this.btn_premiere);
            this.groupBox1.Controls.Add(this.list_bien);
            this.groupBox1.Location = new System.Drawing.Point(26, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 444);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nom Bien";
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
            this.btn_suivant.Location = new System.Drawing.Point(168, 395);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 56;
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
            this.btn_precedent.Location = new System.Drawing.Point(66, 395);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 55;
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
            this.btn_derniere.Location = new System.Drawing.Point(220, 395);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 57;
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
            this.btn_premiere.Location = new System.Drawing.Point(14, 395);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 54;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cherch_rem);
            this.groupBox2.Controls.Add(this.list_remarque);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(354, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 444);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Remarque";
            // 
            // txt_chercher_bien
            // 
            this.txt_chercher_bien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher_bien.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher_bien.Location = new System.Drawing.Point(14, 39);
            this.txt_chercher_bien.Name = "txt_chercher_bien";
            this.txt_chercher_bien.Size = new System.Drawing.Size(252, 27);
            this.txt_chercher_bien.TabIndex = 58;
            this.txt_chercher_bien.Text = "Chercher Par Nom Bien";
            this.txt_chercher_bien.Enter += new System.EventHandler(this.txt_chercher_bien_Enter);
            this.txt_chercher_bien.Leave += new System.EventHandler(this.txt_chercher_bien_Leave);
            // 
            // txt_cherch_rem
            // 
            this.txt_cherch_rem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cherch_rem.ForeColor = System.Drawing.Color.Gray;
            this.txt_cherch_rem.Location = new System.Drawing.Point(13, 35);
            this.txt_cherch_rem.Name = "txt_cherch_rem";
            this.txt_cherch_rem.Size = new System.Drawing.Size(210, 27);
            this.txt_cherch_rem.TabIndex = 58;
            this.txt_cherch_rem.Text = "Chercher Nom Remarque";
            this.txt_cherch_rem.Enter += new System.EventHandler(this.txt_cherch_rem_Enter);
            this.txt_cherch_rem.Leave += new System.EventHandler(this.txt_cherch_rem_Leave);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_fichier;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_Bien_rem_Supprimer;
        private System.Windows.Forms.Button btn_Bien_rem_modifier;
        private System.Windows.Forms.Button btn_Bien_rem_Ajouter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_bien;
        private System.Windows.Forms.ListBox list_remarque;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_chercher_bien;
        private System.Windows.Forms.TextBox txt_cherch_rem;
    }
}