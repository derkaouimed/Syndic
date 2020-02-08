namespace Syndic
{
    partial class FrmAMAchat
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qteachat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_article = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_facture = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_prix = new System.Windows.Forms.TextBox();
            this.pnl_modifier = new System.Windows.Forms.Panel();
            this.btn_annuler_mod = new System.Windows.Forms.Button();
            this.btn_valider_mod = new System.Windows.Forms.Button();
            this.pnl_ajouter = new System.Windows.Forms.Panel();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_annuler_ajt = new System.Windows.Forms.Button();
            this.btn_valider_ajt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_modifier.SuspendLayout();
            this.pnl_ajouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 23);
            this.panel1.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(234, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(98, 18);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Ajouter Article";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantite Achat :";
            // 
            // txt_qteachat
            // 
            this.txt_qteachat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qteachat.Location = new System.Drawing.Point(249, 226);
            this.txt_qteachat.Name = "txt_qteachat";
            this.txt_qteachat.Size = new System.Drawing.Size(264, 27);
            this.txt_qteachat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Article :";
            // 
            // cb_article
            // 
            this.cb_article.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_article.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_article.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_article.FormattingEnabled = true;
            this.cb_article.Location = new System.Drawing.Point(249, 101);
            this.cb_article.Name = "cb_article";
            this.cb_article.Size = new System.Drawing.Size(264, 29);
            this.cb_article.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Facture :";
            // 
            // cb_facture
            // 
            this.cb_facture.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_facture.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_facture.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_facture.FormattingEnabled = true;
            this.cb_facture.Location = new System.Drawing.Point(249, 163);
            this.cb_facture.Name = "cb_facture";
            this.cb_facture.Size = new System.Drawing.Size(264, 29);
            this.cb_facture.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prix :";
            // 
            // txt_prix
            // 
            this.txt_prix.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.Location = new System.Drawing.Point(249, 293);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.Size = new System.Drawing.Size(264, 27);
            this.txt_prix.TabIndex = 3;
            // 
            // pnl_modifier
            // 
            this.pnl_modifier.Controls.Add(this.btn_annuler_mod);
            this.pnl_modifier.Controls.Add(this.btn_valider_mod);
            this.pnl_modifier.Location = new System.Drawing.Point(60, 389);
            this.pnl_modifier.Name = "pnl_modifier";
            this.pnl_modifier.Size = new System.Drawing.Size(432, 61);
            this.pnl_modifier.TabIndex = 64;
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
            this.btn_annuler_mod.TabIndex = 9;
            this.btn_annuler_mod.Text = "Annuler";
            this.btn_annuler_mod.UseVisualStyleBackColor = false;
            this.btn_annuler_mod.Click += new System.EventHandler(this.btn_vider_Click);
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
            this.btn_valider_mod.TabIndex = 8;
            this.btn_valider_mod.Text = "Valider";
            this.btn_valider_mod.UseVisualStyleBackColor = false;
            this.btn_valider_mod.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // pnl_ajouter
            // 
            this.pnl_ajouter.Controls.Add(this.btn_vider);
            this.pnl_ajouter.Controls.Add(this.btn_annuler_ajt);
            this.pnl_ajouter.Controls.Add(this.btn_valider_ajt);
            this.pnl_ajouter.Location = new System.Drawing.Point(60, 389);
            this.pnl_ajouter.Name = "pnl_ajouter";
            this.pnl_ajouter.Size = new System.Drawing.Size(432, 61);
            this.pnl_ajouter.TabIndex = 63;
            // 
            // btn_vider
            // 
            this.btn_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_vider.FlatAppearance.BorderSize = 0;
            this.btn_vider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vider.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vider.ForeColor = System.Drawing.Color.White;
            this.btn_vider.Location = new System.Drawing.Point(10, 9);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(134, 41);
            this.btn_vider.TabIndex = 4;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = false;
            this.btn_vider.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_annuler_ajt
            // 
            this.btn_annuler_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler_ajt.FlatAppearance.BorderSize = 0;
            this.btn_annuler_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_annuler_ajt.Location = new System.Drawing.Point(290, 9);
            this.btn_annuler_ajt.Name = "btn_annuler_ajt";
            this.btn_annuler_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler_ajt.TabIndex = 6;
            this.btn_annuler_ajt.Text = "Annuler";
            this.btn_annuler_ajt.UseVisualStyleBackColor = false;
            this.btn_annuler_ajt.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_valider_ajt
            // 
            this.btn_valider_ajt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider_ajt.FlatAppearance.BorderSize = 0;
            this.btn_valider_ajt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider_ajt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider_ajt.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider_ajt.ForeColor = System.Drawing.Color.White;
            this.btn_valider_ajt.Location = new System.Drawing.Point(150, 9);
            this.btn_valider_ajt.Name = "btn_valider_ajt";
            this.btn_valider_ajt.Size = new System.Drawing.Size(134, 41);
            this.btn_valider_ajt.TabIndex = 5;
            this.btn_valider_ajt.Text = "Valider";
            this.btn_valider_ajt.UseVisualStyleBackColor = false;
            this.btn_valider_ajt.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // FrmAMAchat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.pnl_ajouter);
            this.Controls.Add(this.pnl_modifier);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_facture);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_article);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_qteachat);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMAchat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMAchat";
            this.Load += new System.EventHandler(this.FrmAMAchat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_modifier.ResumeLayout(false);
            this.pnl_ajouter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_qteachat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_article;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_facture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_prix;
        private System.Windows.Forms.Panel pnl_modifier;
        private System.Windows.Forms.Button btn_annuler_mod;
        private System.Windows.Forms.Button btn_valider_mod;
        private System.Windows.Forms.Panel pnl_ajouter;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_annuler_ajt;
        private System.Windows.Forms.Button btn_valider_ajt;
    }
}