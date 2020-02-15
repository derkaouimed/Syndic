namespace Syndic
{
    partial class FrmAMFacture
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAMFacture));
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_montant = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_nom = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_paiment = new System.Windows.Forms.ComboBox();
            this.lbl_paiment = new System.Windows.Forms.Label();
            this.pnl_modifier = new System.Windows.Forms.Panel();
            this.btn_annuler_mod = new System.Windows.Forms.Button();
            this.btn_valider_mod = new System.Windows.Forms.Button();
            this.pnl_ajouter = new System.Windows.Forms.Panel();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_annuler_ajt = new System.Windows.Forms.Button();
            this.btn_valider_ajt = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.pnlMenuBar.SuspendLayout();
            this.pnl_modifier.SuspendLayout();
            this.pnl_ajouter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.pnlMenuBar.Controls.Add(this.btn_close);
            this.pnlMenuBar.Controls.Add(this.lbl_titre);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(566, 23);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(234, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(108, 18);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Ajouter Facture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Designation :";
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(260, 197);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(264, 29);
            this.cb_type.TabIndex = 7;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // txt_designation
            // 
            this.txt_designation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_designation.Location = new System.Drawing.Point(260, 60);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(264, 27);
            this.txt_designation.TabIndex = 6;
            // 
            // txt_numero
            // 
            this.txt_numero.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numero.Location = new System.Drawing.Point(260, 341);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(264, 27);
            this.txt_numero.TabIndex = 9;
            // 
            // dt_date
            // 
            this.dt_date.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dt_date.Location = new System.Drawing.Point(260, 106);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(264, 25);
            this.dt_date.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date Facture :";
            // 
            // txt_montant
            // 
            this.txt_montant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_montant.Location = new System.Drawing.Point(260, 150);
            this.txt_montant.Name = "txt_montant";
            this.txt_montant.Size = new System.Drawing.Size(264, 27);
            this.txt_montant.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Montant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 15;
            this.label4.Text = "Type :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nom :";
            // 
            // cb_nom
            // 
            this.cb_nom.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_nom.FormattingEnabled = true;
            this.cb_nom.Location = new System.Drawing.Point(260, 246);
            this.cb_nom.Name = "cb_nom";
            this.cb_nom.Size = new System.Drawing.Size(264, 29);
            this.cb_nom.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 22);
            this.label6.TabIndex = 19;
            this.label6.Text = "Type Paiment :";
            // 
            // cb_paiment
            // 
            this.cb_paiment.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_paiment.FormattingEnabled = true;
            this.cb_paiment.Location = new System.Drawing.Point(260, 289);
            this.cb_paiment.Name = "cb_paiment";
            this.cb_paiment.Size = new System.Drawing.Size(264, 29);
            this.cb_paiment.TabIndex = 18;
            this.cb_paiment.SelectedIndexChanged += new System.EventHandler(this.cb_paiment_SelectedIndexChanged);
            // 
            // lbl_paiment
            // 
            this.lbl_paiment.AutoSize = true;
            this.lbl_paiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paiment.Location = new System.Drawing.Point(56, 341);
            this.lbl_paiment.Name = "lbl_paiment";
            this.lbl_paiment.Size = new System.Drawing.Size(173, 22);
            this.lbl_paiment.TabIndex = 20;
            this.lbl_paiment.Text = "Numero De Chique :";
            // 
            // pnl_modifier
            // 
            this.pnl_modifier.Controls.Add(this.btn_annuler_mod);
            this.pnl_modifier.Controls.Add(this.btn_valider_mod);
            this.pnl_modifier.Location = new System.Drawing.Point(67, 410);
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
            this.btn_annuler_mod.TabIndex = 59;
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
            this.btn_valider_mod.TabIndex = 58;
            this.btn_valider_mod.Text = "Valider";
            this.btn_valider_mod.UseVisualStyleBackColor = false;
            this.btn_valider_mod.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // pnl_ajouter
            // 
            this.pnl_ajouter.Controls.Add(this.btn_vider);
            this.pnl_ajouter.Controls.Add(this.btn_annuler_ajt);
            this.pnl_ajouter.Controls.Add(this.btn_valider_ajt);
            this.pnl_ajouter.Location = new System.Drawing.Point(67, 410);
            this.pnl_ajouter.Name = "pnl_ajouter";
            this.pnl_ajouter.Size = new System.Drawing.Size(432, 61);
            this.pnl_ajouter.TabIndex = 65;
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
            this.btn_vider.TabIndex = 61;
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
            this.btn_annuler_ajt.TabIndex = 59;
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
            this.btn_valider_ajt.TabIndex = 58;
            this.btn_valider_ajt.Text = "Valider";
            this.btn_valider_ajt.UseVisualStyleBackColor = false;
            this.btn_valider_ajt.Click += new System.EventHandler(this.btn_vider_Click);
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(540, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 66;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmAMFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.pnl_ajouter);
            this.Controls.Add(this.pnl_modifier);
            this.Controls.Add(this.lbl_paiment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_paiment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_nom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_montant);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMFacture";
            this.Load += new System.EventHandler(this.FrmAMFacture_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.pnl_modifier.ResumeLayout(false);
            this.pnl_ajouter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_montant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_nom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_paiment;
        private System.Windows.Forms.Label lbl_paiment;
        private System.Windows.Forms.Panel pnl_modifier;
        private System.Windows.Forms.Button btn_annuler_mod;
        private System.Windows.Forms.Button btn_valider_mod;
        private System.Windows.Forms.Panel pnl_ajouter;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_annuler_ajt;
        private System.Windows.Forms.Button btn_valider_ajt;
        private System.Windows.Forms.PictureBox btn_close;
    }
}