﻿namespace Syndic
{
    partial class FrmAMConge
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
            this.cb_emps = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.dt_debut = new System.Windows.Forms.DateTimePicker();
            this.dt_fin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_ajouter = new System.Windows.Forms.Panel();
            this.btn_annuler_ajt = new System.Windows.Forms.Button();
            this.btn_valider_ajt = new System.Windows.Forms.Button();
            this.pnl_modifier = new System.Windows.Forms.Panel();
            this.btn_annuler_mod = new System.Windows.Forms.Button();
            this.btn_valider_mod = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_ajouter.SuspendLayout();
            this.pnl_modifier.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_emps
            // 
            this.cb_emps.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_emps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_emps.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_emps.FormattingEnabled = true;
            this.cb_emps.Location = new System.Drawing.Point(227, 63);
            this.cb_emps.Name = "cb_emps";
            this.cb_emps.Size = new System.Drawing.Size(302, 29);
            this.cb_emps.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 71;
            this.label1.Text = "Les Employes :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 70;
            this.label2.Text = "Date Début :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 23);
            this.panel1.TabIndex = 69;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(224, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(127, 18);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Ajouter Document";
            // 
            // dt_debut
            // 
            this.dt_debut.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dt_debut.Location = new System.Drawing.Point(227, 122);
            this.dt_debut.Name = "dt_debut";
            this.dt_debut.Size = new System.Drawing.Size(302, 27);
            this.dt_debut.TabIndex = 72;
            // 
            // dt_fin
            // 
            this.dt_fin.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dt_fin.Location = new System.Drawing.Point(227, 190);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(302, 27);
            this.dt_fin.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 73;
            this.label3.Text = "Date Fin :";
            // 
            // pnl_ajouter
            // 
            this.pnl_ajouter.Controls.Add(this.btn_annuler_ajt);
            this.pnl_ajouter.Controls.Add(this.btn_valider_ajt);
            this.pnl_ajouter.Location = new System.Drawing.Point(67, 288);
            this.pnl_ajouter.Name = "pnl_ajouter";
            this.pnl_ajouter.Size = new System.Drawing.Size(432, 61);
            this.pnl_ajouter.TabIndex = 75;
            // 
            // btn_annuler_ajt
            // 
            this.btn_annuler_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler_ajt.FlatAppearance.BorderSize = 0;
            this.btn_annuler_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_ajt.Location = new System.Drawing.Point(229, 9);
            this.btn_annuler_ajt.Name = "btn_annuler_ajt";
            this.btn_annuler_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler_ajt.TabIndex = 5;
            this.btn_annuler_ajt.Text = "Annuler";
            this.btn_annuler_ajt.UseVisualStyleBackColor = false;
            this.btn_annuler_ajt.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // btn_valider_ajt
            // 
            this.btn_valider_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider_ajt.FlatAppearance.BorderSize = 0;
            this.btn_valider_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_valider_ajt.Location = new System.Drawing.Point(64, 9);
            this.btn_valider_ajt.Name = "btn_valider_ajt";
            this.btn_valider_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_valider_ajt.TabIndex = 4;
            this.btn_valider_ajt.Text = "Valider";
            this.btn_valider_ajt.UseVisualStyleBackColor = false;
            this.btn_valider_ajt.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // pnl_modifier
            // 
            this.pnl_modifier.Controls.Add(this.btn_annuler_mod);
            this.pnl_modifier.Controls.Add(this.btn_valider_mod);
            this.pnl_modifier.Location = new System.Drawing.Point(67, 288);
            this.pnl_modifier.Name = "pnl_modifier";
            this.pnl_modifier.Size = new System.Drawing.Size(432, 61);
            this.pnl_modifier.TabIndex = 76;
            // 
            // btn_annuler_mod
            // 
            this.btn_annuler_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler_mod.FlatAppearance.BorderSize = 0;
            this.btn_annuler_mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler_mod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_mod.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_mod.Location = new System.Drawing.Point(229, 9);
            this.btn_annuler_mod.Name = "btn_annuler_mod";
            this.btn_annuler_mod.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler_mod.TabIndex = 7;
            this.btn_annuler_mod.Text = "Annuler";
            this.btn_annuler_mod.UseVisualStyleBackColor = false;
            this.btn_annuler_mod.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // btn_valider_mod
            // 
            this.btn_valider_mod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider_mod.FlatAppearance.BorderSize = 0;
            this.btn_valider_mod.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider_mod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_mod.ForeColor = System.Drawing.Color.White;
            this.btn_valider_mod.Location = new System.Drawing.Point(64, 9);
            this.btn_valider_mod.Name = "btn_valider_mod";
            this.btn_valider_mod.Size = new System.Drawing.Size(134, 41);
            this.btn_valider_mod.TabIndex = 6;
            this.btn_valider_mod.Text = "Valider";
            this.btn_valider_mod.UseVisualStyleBackColor = false;
            this.btn_valider_mod.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // FrmAMConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 396);
            this.Controls.Add(this.pnl_ajouter);
            this.Controls.Add(this.pnl_modifier);
            this.Controls.Add(this.dt_fin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_debut);
            this.Controls.Add(this.cb_emps);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMConge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMConge";
            this.Load += new System.EventHandler(this.FrmAMConge_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_ajouter.ResumeLayout(false);
            this.pnl_modifier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_emps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.DateTimePicker dt_debut;
        private System.Windows.Forms.DateTimePicker dt_fin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnl_ajouter;
        private System.Windows.Forms.Button btn_annuler_ajt;
        private System.Windows.Forms.Button btn_valider_ajt;
        private System.Windows.Forms.Panel pnl_modifier;
        private System.Windows.Forms.Button btn_annuler_mod;
        private System.Windows.Forms.Button btn_valider_mod;
    }
}