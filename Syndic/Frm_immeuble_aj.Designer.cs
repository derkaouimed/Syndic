namespace Syndic
{
    partial class Frm_immeuble_aj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_immeuble_aj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tit = new System.Windows.Forms.TextBox();
            this.txt_nm = new System.Windows.Forms.TextBox();
            this.btn_immeuble_Annuler = new System.Windows.Forms.Button();
            this.btn_immeuble_valider = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rd_anne = new System.Windows.Forms.RadioButton();
            this.rd_mois = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 23);
            this.panel1.TabIndex = 26;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(453, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 24);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(84, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Titre Foncier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(84, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nom immeuble :";
            // 
            // txt_tit
            // 
            this.txt_tit.Location = new System.Drawing.Point(233, 213);
            this.txt_tit.Name = "txt_tit";
            this.txt_tit.Size = new System.Drawing.Size(197, 20);
            this.txt_tit.TabIndex = 55;
            // 
            // txt_nm
            // 
            this.txt_nm.Location = new System.Drawing.Point(233, 142);
            this.txt_nm.Name = "txt_nm";
            this.txt_nm.Size = new System.Drawing.Size(197, 20);
            this.txt_nm.TabIndex = 54;
            // 
            // btn_immeuble_Annuler
            // 
            this.btn_immeuble_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_Annuler.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_Annuler.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_Annuler.Location = new System.Drawing.Point(249, 377);
            this.btn_immeuble_Annuler.Name = "btn_immeuble_Annuler";
            this.btn_immeuble_Annuler.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_Annuler.TabIndex = 60;
            this.btn_immeuble_Annuler.Text = "Annuler";
            this.btn_immeuble_Annuler.UseVisualStyleBackColor = false;
            this.btn_immeuble_Annuler.Click += new System.EventHandler(this.btn_immeuble_Annuler_Click);
            // 
            // btn_immeuble_valider
            // 
            this.btn_immeuble_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_valider.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_valider.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_valider.Location = new System.Drawing.Point(101, 377);
            this.btn_immeuble_valider.Name = "btn_immeuble_valider";
            this.btn_immeuble_valider.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_valider.TabIndex = 59;
            this.btn_immeuble_valider.Text = "Valider";
            this.btn_immeuble_valider.UseVisualStyleBackColor = false;
            this.btn_immeuble_valider.Click += new System.EventHandler(this.btn_immeuble_valider_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(84, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Paiment :";
            // 
            // rd_anne
            // 
            this.rd_anne.AutoSize = true;
            this.rd_anne.Location = new System.Drawing.Point(341, 276);
            this.rd_anne.Name = "rd_anne";
            this.rd_anne.Size = new System.Drawing.Size(56, 17);
            this.rd_anne.TabIndex = 61;
            this.rd_anne.TabStop = true;
            this.rd_anne.Text = "Année";
            this.rd_anne.UseVisualStyleBackColor = true;
            // 
            // rd_mois
            // 
            this.rd_mois.AutoSize = true;
            this.rd_mois.Location = new System.Drawing.Point(235, 275);
            this.rd_mois.Name = "rd_mois";
            this.rd_mois.Size = new System.Drawing.Size(50, 17);
            this.rd_mois.TabIndex = 61;
            this.rd_mois.TabStop = true;
            this.rd_mois.Text = "Mois ";
            this.rd_mois.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(168, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 62;
            this.label5.Text = "Ajouter Immeuble";
            // 
            // Frm_immeuble_aj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 517);
            this.Controls.Add(this.rd_mois);
            this.Controls.Add(this.rd_anne);
            this.Controls.Add(this.btn_immeuble_Annuler);
            this.Controls.Add(this.btn_immeuble_valider);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nm);
            this.Controls.Add(this.txt_tit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_immeuble_aj";
            this.Text = "Frm_immeuble_aj";
            this.Load += new System.EventHandler(this.Frm_immeuble_aj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tit;
        private System.Windows.Forms.TextBox txt_nm;
        private System.Windows.Forms.Button btn_immeuble_Annuler;
        private System.Windows.Forms.Button btn_immeuble_valider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rd_anne;
        private System.Windows.Forms.RadioButton rd_mois;
        private System.Windows.Forms.Label label5;
    }
}