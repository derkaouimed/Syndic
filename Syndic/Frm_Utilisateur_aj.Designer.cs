namespace Syndic
{
    partial class Frm_Utilisateur_aj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Utilisateur_aj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.pnl_ajouter = new System.Windows.Forms.Panel();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_annuler_ajt = new System.Windows.Forms.Button();
            this.btn_valider_ajt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.cb_nomc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_salt = new System.Windows.Forms.TextBox();
            this.btn_rubrique = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            this.pnl_ajouter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.lbl_titre);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 23);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(188, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(120, 18);
            this.lbl_titre.TabIndex = 87;
            this.lbl_titre.Text = "Ajouter utilisateur";
            // 
            // btn_close
            // 
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(451, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 23);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 81;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 83;
            this.label5.Text = "Type :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 82;
            this.label6.Text = "Password :";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(170, 162);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(264, 27);
            this.txt_pass.TabIndex = 81;
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(170, 227);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(264, 29);
            this.cb_type.TabIndex = 80;
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // pnl_ajouter
            // 
            this.pnl_ajouter.Controls.Add(this.btn_vider);
            this.pnl_ajouter.Controls.Add(this.btn_annuler_ajt);
            this.pnl_ajouter.Controls.Add(this.btn_valider_ajt);
            this.pnl_ajouter.Location = new System.Drawing.Point(12, 398);
            this.pnl_ajouter.Name = "pnl_ajouter";
            this.pnl_ajouter.Size = new System.Drawing.Size(432, 61);
            this.pnl_ajouter.TabIndex = 84;
            // 
            // btn_vider
            // 
            this.btn_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_vider.FlatAppearance.BorderSize = 0;
            this.btn_vider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vider.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vider.ForeColor = System.Drawing.Color.White;
            this.btn_vider.Location = new System.Drawing.Point(3, 9);
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
            this.btn_annuler_ajt.Click += new System.EventHandler(this.btn_annuler_ajt_Click);
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
            this.btn_valider_ajt.Click += new System.EventHandler(this.btn_valider_ajt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 86;
            this.label1.Text = "login :";
            // 
            // txt_log
            // 
            this.txt_log.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(170, 96);
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(264, 27);
            this.txt_log.TabIndex = 85;
            // 
            // cb_nomc
            // 
            this.cb_nomc.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_nomc.FormattingEnabled = true;
            this.cb_nomc.Location = new System.Drawing.Point(170, 287);
            this.cb_nomc.Name = "cb_nomc";
            this.cb_nomc.Size = new System.Drawing.Size(264, 29);
            this.cb_nomc.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 294);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 83;
            this.label2.Text = "Nom Complet :";
            // 
            // txt_salt
            // 
            this.txt_salt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_salt.Location = new System.Drawing.Point(170, 347);
            this.txt_salt.Name = "txt_salt";
            this.txt_salt.Size = new System.Drawing.Size(264, 27);
            this.txt_salt.TabIndex = 81;
            this.txt_salt.Visible = false;
            // 
            // btn_rubrique
            // 
            this.btn_rubrique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_rubrique.FlatAppearance.BorderSize = 0;
            this.btn_rubrique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_rubrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubrique.ForeColor = System.Drawing.Color.White;
            this.btn_rubrique.Location = new System.Drawing.Point(440, 227);
            this.btn_rubrique.Name = "btn_rubrique";
            this.btn_rubrique.Size = new System.Drawing.Size(31, 30);
            this.btn_rubrique.TabIndex = 87;
            this.btn_rubrique.Text = "+";
            this.btn_rubrique.UseVisualStyleBackColor = false;
            this.btn_rubrique.Click += new System.EventHandler(this.btn_rubrique_Click);
            // 
            // Frm_Utilisateur_aj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(475, 517);
            this.Controls.Add(this.btn_rubrique);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.pnl_ajouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_salt);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.cb_nomc);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Utilisateur_aj";
            this.Text = "Frm_Utilisateur_aj";
            this.Load += new System.EventHandler(this.Frm_Utilisateur_aj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            this.pnl_ajouter.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Panel pnl_ajouter;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_annuler_ajt;
        private System.Windows.Forms.Button btn_valider_ajt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ComboBox cb_nomc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_salt;
        private System.Windows.Forms.Button btn_rubrique;
    }
}