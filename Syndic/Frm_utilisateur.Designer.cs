namespace Syndic
{
    partial class Frm_utilisateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_utilisateur));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_utilisateur_Ajouter = new System.Windows.Forms.Button();
            this.btn_utilisateur_modifier = new System.Windows.Forms.Button();
            this.btn_utilisateur_Supprimer = new System.Windows.Forms.Button();
            this.lst_utilisateur = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cmb_typ = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lst_utilisateur);
            this.groupBox1.Controls.Add(this.btn_suivant);
            this.groupBox1.Controls.Add(this.btn_precedent);
            this.groupBox1.Controls.Add(this.btn_derniere);
            this.groupBox1.Controls.Add(this.btn_premiere);
            this.groupBox1.Controls.Add(this.txt_chercher);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_valider);
            this.groupBox1.Controls.Add(this.btn_utilisateur_Ajouter);
            this.groupBox1.Controls.Add(this.btn_annuler);
            this.groupBox1.Controls.Add(this.btn_utilisateur_modifier);
            this.groupBox1.Controls.Add(this.btn_utilisateur_Supprimer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(3, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 569);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisateur";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.btn_suivant.Location = new System.Drawing.Point(260, 485);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 55;
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
            this.btn_precedent.Location = new System.Drawing.Point(83, 485);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 54;
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
            this.btn_derniere.Location = new System.Drawing.Point(312, 485);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 56;
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
            this.btn_premiere.Location = new System.Drawing.Point(31, 485);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 53;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // txt_chercher
            // 
            this.txt_chercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher.Location = new System.Drawing.Point(26, 37);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(187, 27);
            this.txt_chercher.TabIndex = 52;
            this.txt_chercher.Text = "Chercher Par Nom";
            this.txt_chercher.TextChanged += new System.EventHandler(this.txt_chercher_TextChanged_1);
            this.txt_chercher.Enter += new System.EventHandler(this.txt_chercher_Enter);
            this.txt_chercher.Leave += new System.EventHandler(this.txt_chercher_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(246, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 51;
            this.button1.Text = "rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_utilisateur_Ajouter
            // 
            this.btn_utilisateur_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_Ajouter.Location = new System.Drawing.Point(389, 485);
            this.btn_utilisateur_Ajouter.Name = "btn_utilisateur_Ajouter";
            this.btn_utilisateur_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_Ajouter.TabIndex = 42;
            this.btn_utilisateur_Ajouter.Text = "Ajouter";
            this.btn_utilisateur_Ajouter.UseVisualStyleBackColor = false;
            this.btn_utilisateur_Ajouter.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // btn_utilisateur_modifier
            // 
            this.btn_utilisateur_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_modifier.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_modifier.Location = new System.Drawing.Point(511, 485);
            this.btn_utilisateur_modifier.Name = "btn_utilisateur_modifier";
            this.btn_utilisateur_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_modifier.TabIndex = 43;
            this.btn_utilisateur_modifier.Text = "Modifier";
            this.btn_utilisateur_modifier.UseVisualStyleBackColor = false;
            this.btn_utilisateur_modifier.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // btn_utilisateur_Supprimer
            // 
            this.btn_utilisateur_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_Supprimer.Location = new System.Drawing.Point(633, 485);
            this.btn_utilisateur_Supprimer.Name = "btn_utilisateur_Supprimer";
            this.btn_utilisateur_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_Supprimer.TabIndex = 45;
            this.btn_utilisateur_Supprimer.Text = "Supprimer";
            this.btn_utilisateur_Supprimer.UseVisualStyleBackColor = false;
            this.btn_utilisateur_Supprimer.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // lst_utilisateur
            // 
            this.lst_utilisateur.FormattingEnabled = true;
            this.lst_utilisateur.ItemHeight = 16;
            this.lst_utilisateur.Location = new System.Drawing.Point(26, 86);
            this.lst_utilisateur.Name = "lst_utilisateur";
            this.lst_utilisateur.Size = new System.Drawing.Size(336, 356);
            this.lst_utilisateur.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 58;
            this.label1.Text = "Login :";
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(152, 45);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(100, 23);
            this.txt_log.TabIndex = 59;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(152, 93);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(100, 23);
            this.txt_pass.TabIndex = 59;
            // 
            // cmb_typ
            // 
            this.cmb_typ.FormattingEnabled = true;
            this.cmb_typ.Location = new System.Drawing.Point(152, 139);
            this.cmb_typ.Name = "cmb_typ";
            this.cmb_typ.Size = new System.Drawing.Size(100, 24);
            this.cmb_typ.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 58;
            this.label2.Text = "type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Password :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_typ);
            this.groupBox2.Controls.Add(this.txt_pass);
            this.groupBox2.Controls.Add(this.txt_log);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(424, 146);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 222);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information :";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler.FlatAppearance.BorderSize = 0;
            this.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(560, 417);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(116, 43);
            this.btn_annuler.TabIndex = 43;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Visible = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider.FlatAppearance.BorderSize = 0;
            this.btn_valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.White;
            this.btn_valider.Location = new System.Drawing.Point(438, 417);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(116, 43);
            this.btn_valider.TabIndex = 42;
            this.btn_valider.Text = "valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Visible = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // Frm_utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_utilisateur";
            this.Text = "Frm_utilisateur";
            this.Load += new System.EventHandler(this.Frm_utilisateur_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_utilisateur_Ajouter;
        private System.Windows.Forms.Button btn_utilisateur_modifier;
        private System.Windows.Forms.Button btn_utilisateur_Supprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_chercher;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lst_utilisateur;
        private System.Windows.Forms.ComboBox cmb_typ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_annuler;
    }
}