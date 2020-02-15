﻿namespace Syndic
{
    partial class FrmDocFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDocFacture));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_chercher_Fact = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_chercher_doc = new System.Windows.Forms.TextBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.btn_imprimerSel = new System.Windows.Forms.Button();
            this.btn_imprimerTous = new System.Windows.Forms.Button();
            this.lst_factures = new System.Windows.Forms.ListBox();
            this.lst_documents = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst_factures);
            this.groupBox1.Controls.Add(this.btn_suivant);
            this.groupBox1.Controls.Add(this.btn_precedent);
            this.groupBox1.Controls.Add(this.btn_derniere);
            this.groupBox1.Controls.Add(this.txt_chercher_Fact);
            this.groupBox1.Controls.Add(this.btn_premiere);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 609);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les Facture :";
            // 
            // txt_chercher_Fact
            // 
            this.txt_chercher_Fact.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher_Fact.Location = new System.Drawing.Point(7, 37);
            this.txt_chercher_Fact.Name = "txt_chercher_Fact";
            this.txt_chercher_Fact.Size = new System.Drawing.Size(288, 27);
            this.txt_chercher_Fact.TabIndex = 0;
            this.txt_chercher_Fact.Text = "Tapez Designation Pour Chercher";
            this.txt_chercher_Fact.Enter += new System.EventHandler(this.txt_chercher_Fact_Enter);
            this.txt_chercher_Fact.Leave += new System.EventHandler(this.txt_chercher_Fact_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_documents);
            this.groupBox2.Controls.Add(this.btn_imprimerTous);
            this.groupBox2.Controls.Add(this.btn_imprimerSel);
            this.groupBox2.Controls.Add(this.txt_chercher_doc);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(321, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(437, 609);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led Documents :";
            // 
            // txt_chercher_doc
            // 
            this.txt_chercher_doc.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher_doc.Location = new System.Drawing.Point(6, 37);
            this.txt_chercher_doc.Name = "txt_chercher_doc";
            this.txt_chercher_doc.Size = new System.Drawing.Size(425, 27);
            this.txt_chercher_doc.TabIndex = 6;
            this.txt_chercher_doc.Text = "Tapez Un Nom De Document Pour Chercher";
            this.txt_chercher_doc.Enter += new System.EventHandler(this.txt_chercher_doc_Enter);
            this.txt_chercher_doc.Leave += new System.EventHandler(this.txt_chercher_doc_Leave);
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
            this.btn_suivant.Location = new System.Drawing.Point(170, 555);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 4;
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
            this.btn_precedent.Location = new System.Drawing.Point(92, 555);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 3;
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
            this.btn_derniere.Location = new System.Drawing.Point(222, 555);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 5;
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
            this.btn_premiere.Location = new System.Drawing.Point(40, 555);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 2;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_derniere_Click);
            // 
            // btn_imprimerSel
            // 
            this.btn_imprimerSel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_imprimerSel.FlatAppearance.BorderSize = 0;
            this.btn_imprimerSel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_imprimerSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimerSel.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimerSel.ForeColor = System.Drawing.Color.White;
            this.btn_imprimerSel.Location = new System.Drawing.Point(53, 555);
            this.btn_imprimerSel.Name = "btn_imprimerSel";
            this.btn_imprimerSel.Size = new System.Drawing.Size(170, 41);
            this.btn_imprimerSel.TabIndex = 8;
            this.btn_imprimerSel.Text = "Imprimer";
            this.btn_imprimerSel.UseVisualStyleBackColor = false;
            // 
            // btn_imprimerTous
            // 
            this.btn_imprimerTous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_imprimerTous.FlatAppearance.BorderSize = 0;
            this.btn_imprimerTous.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_imprimerTous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimerTous.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimerTous.ForeColor = System.Drawing.Color.White;
            this.btn_imprimerTous.Location = new System.Drawing.Point(229, 555);
            this.btn_imprimerTous.Name = "btn_imprimerTous";
            this.btn_imprimerTous.Size = new System.Drawing.Size(170, 41);
            this.btn_imprimerTous.TabIndex = 9;
            this.btn_imprimerTous.Text = "Imprimer Tous";
            this.btn_imprimerTous.UseVisualStyleBackColor = false;
            // 
            // lst_factures
            // 
            this.lst_factures.FormattingEnabled = true;
            this.lst_factures.ItemHeight = 21;
            this.lst_factures.Location = new System.Drawing.Point(7, 71);
            this.lst_factures.Name = "lst_factures";
            this.lst_factures.Size = new System.Drawing.Size(288, 466);
            this.lst_factures.TabIndex = 1;
            this.lst_factures.SelectedIndexChanged += new System.EventHandler(this.lst_factures_SelectedIndexChanged);
            // 
            // lst_documents
            // 
            this.lst_documents.FormattingEnabled = true;
            this.lst_documents.ItemHeight = 21;
            this.lst_documents.Location = new System.Drawing.Point(6, 70);
            this.lst_documents.Name = "lst_documents";
            this.lst_documents.Size = new System.Drawing.Size(425, 466);
            this.lst_documents.TabIndex = 7;
            // 
            // FrmDocFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDocFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDocFacture";
            this.Load += new System.EventHandler(this.FrmDocFacture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_chercher_Fact;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_chercher_doc;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.Button btn_imprimerSel;
        private System.Windows.Forms.Button btn_imprimerTous;
        private System.Windows.Forms.ListBox lst_factures;
        private System.Windows.Forms.ListBox lst_documents;
    }
}