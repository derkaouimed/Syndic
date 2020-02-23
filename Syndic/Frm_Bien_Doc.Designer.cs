namespace Syndic
{
    partial class Frm_Bien_Doc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bien_Doc));
            this.grp_fichier = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_document = new System.Windows.Forms.ListBox();
            this.txtidDoc = new System.Windows.Forms.TextBox();
            this.txt_cherch_doc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_chercher_bien = new System.Windows.Forms.TextBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.list_bien = new System.Windows.Forms.ListBox();
            this.btn_Bien_Doc_Supprimer = new System.Windows.Forms.Button();
            this.btn_Bien_Doc_modifier = new System.Windows.Forms.Button();
            this.btn_Bien_Doc_Ajouter = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.grp_fichier.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_fichier
            // 
            this.grp_fichier.Controls.Add(this.groupBox2);
            this.grp_fichier.Controls.Add(this.groupBox1);
            this.grp_fichier.Controls.Add(this.btn_Bien_Doc_Supprimer);
            this.grp_fichier.Controls.Add(this.btn_Bien_Doc_modifier);
            this.grp_fichier.Controls.Add(this.btn_Bien_Doc_Ajouter);
            this.grp_fichier.Controls.Add(this.btn_rechercher);
            this.grp_fichier.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.grp_fichier.Location = new System.Drawing.Point(12, 34);
            this.grp_fichier.Name = "grp_fichier";
            this.grp_fichier.Size = new System.Drawing.Size(746, 569);
            this.grp_fichier.TabIndex = 32;
            this.grp_fichier.TabStop = false;
            this.grp_fichier.Text = "Document";
            this.grp_fichier.Enter += new System.EventHandler(this.grp_fichier_Enter_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list_document);
            this.groupBox2.Controls.Add(this.txtidDoc);
            this.groupBox2.Controls.Add(this.txt_cherch_doc);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(354, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(386, 444);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "fichier";
            // 
            // list_document
            // 
            this.list_document.FormattingEnabled = true;
            this.list_document.ItemHeight = 16;
            this.list_document.Location = new System.Drawing.Point(13, 81);
            this.list_document.Name = "list_document";
            this.list_document.Size = new System.Drawing.Size(354, 308);
            this.list_document.TabIndex = 44;
            this.list_document.SelectedIndexChanged += new System.EventHandler(this.list_document_SelectedIndexChanged);
            // 
            // txtidDoc
            // 
            this.txtidDoc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidDoc.ForeColor = System.Drawing.Color.Gray;
            this.txtidDoc.Location = new System.Drawing.Point(55, 143);
            this.txtidDoc.Name = "txtidDoc";
            this.txtidDoc.Size = new System.Drawing.Size(168, 27);
            this.txtidDoc.TabIndex = 58;
            this.txtidDoc.Text = "Chercher Nom document";
            this.txtidDoc.Enter += new System.EventHandler(this.txt_cherch_doc_Enter);
            this.txtidDoc.Leave += new System.EventHandler(this.txt_cherch_doc_Leave);
            // 
            // txt_cherch_doc
            // 
            this.txt_cherch_doc.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cherch_doc.ForeColor = System.Drawing.Color.Gray;
            this.txt_cherch_doc.Location = new System.Drawing.Point(13, 35);
            this.txt_cherch_doc.Name = "txt_cherch_doc";
            this.txt_cherch_doc.Size = new System.Drawing.Size(210, 27);
            this.txt_cherch_doc.TabIndex = 58;
            this.txt_cherch_doc.Text = "Chercher Nom document";
            this.txt_cherch_doc.Enter += new System.EventHandler(this.txt_cherch_doc_Enter);
            this.txt_cherch_doc.Leave += new System.EventHandler(this.txt_cherch_doc_Leave);
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
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            // txt_chercher_bien
            // 
            this.txt_chercher_bien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher_bien.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher_bien.Location = new System.Drawing.Point(14, 39);
            this.txt_chercher_bien.Name = "txt_chercher_bien";
            this.txt_chercher_bien.Size = new System.Drawing.Size(252, 27);
            this.txt_chercher_bien.TabIndex = 58;
            this.txt_chercher_bien.Text = "Chercher Par Nom Bien";
            this.txt_chercher_bien.TextChanged += new System.EventHandler(this.txt_chercher_bien_TextChanged);
            this.txt_chercher_bien.Enter += new System.EventHandler(this.txt_chercher_bien_Enter);
            this.txt_chercher_bien.Leave += new System.EventHandler(this.txt_chercher_bien_Leave);
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
            // list_bien
            // 
            this.list_bien.FormattingEnabled = true;
            this.list_bien.ItemHeight = 16;
            this.list_bien.Location = new System.Drawing.Point(14, 81);
            this.list_bien.Name = "list_bien";
            this.list_bien.Size = new System.Drawing.Size(253, 308);
            this.list_bien.TabIndex = 43;
            this.list_bien.SelectedIndexChanged += new System.EventHandler(this.list_bien_SelectedIndexChanged);
            // 
            // btn_Bien_Doc_Supprimer
            // 
            this.btn_Bien_Doc_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_Doc_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Bien_Doc_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_Doc_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_Doc_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_Doc_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_Doc_Supprimer.Location = new System.Drawing.Point(611, 485);
            this.btn_Bien_Doc_Supprimer.Name = "btn_Bien_Doc_Supprimer";
            this.btn_Bien_Doc_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_Doc_Supprimer.TabIndex = 38;
            this.btn_Bien_Doc_Supprimer.Text = "Supprimer";
            this.btn_Bien_Doc_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Bien_Doc_Supprimer.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
            // 
            // btn_Bien_Doc_modifier
            // 
            this.btn_Bien_Doc_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_Doc_modifier.FlatAppearance.BorderSize = 0;
            this.btn_Bien_Doc_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_Doc_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_Doc_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_Doc_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_Doc_modifier.Location = new System.Drawing.Point(489, 485);
            this.btn_Bien_Doc_modifier.Name = "btn_Bien_Doc_modifier";
            this.btn_Bien_Doc_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_Doc_modifier.TabIndex = 36;
            this.btn_Bien_Doc_modifier.Text = "Modifier";
            this.btn_Bien_Doc_modifier.UseVisualStyleBackColor = false;
            this.btn_Bien_Doc_modifier.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
            // 
            // btn_Bien_Doc_Ajouter
            // 
            this.btn_Bien_Doc_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Bien_Doc_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Bien_Doc_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Bien_Doc_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Bien_Doc_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bien_Doc_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Bien_Doc_Ajouter.Location = new System.Drawing.Point(367, 485);
            this.btn_Bien_Doc_Ajouter.Name = "btn_Bien_Doc_Ajouter";
            this.btn_Bien_Doc_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_Bien_Doc_Ajouter.TabIndex = 35;
            this.btn_Bien_Doc_Ajouter.Text = "Ajouter";
            this.btn_Bien_Doc_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Bien_Doc_Ajouter.Click += new System.EventHandler(this.btn_Bien_Supprimer_Click);
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
            // Frm_Bien_Doc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.grp_fichier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Bien_Doc";
            this.Text = "Frm_Bien_Doc";
            this.Load += new System.EventHandler(this.Frm_Bien_Doc_Load);
            this.grp_fichier.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_fichier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_cherch_doc;
        private System.Windows.Forms.ListBox list_document;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_chercher_bien;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.ListBox list_bien;
        private System.Windows.Forms.Button btn_Bien_Doc_Supprimer;
        private System.Windows.Forms.Button btn_Bien_Doc_modifier;
        private System.Windows.Forms.Button btn_Bien_Doc_Ajouter;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.TextBox txtidDoc;
    }
}