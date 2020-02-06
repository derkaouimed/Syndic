namespace Syndic
{
    partial class FrmAMArticle
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
            this.pnlMenuBar = new System.Windows.Forms.Panel();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_qteMinimale = new System.Windows.Forms.TextBox();
            this.txt_qteStock = new System.Windows.Forms.TextBox();
            this.cb_Rubrique = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btn_rubrique = new System.Windows.Forms.Button();
            this.pnlMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
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
            this.lbl_titre.Location = new System.Drawing.Point(255, 2);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(98, 18);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Ajouter Article";
            // 
            // txt_designation
            // 
            this.txt_designation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_designation.Location = new System.Drawing.Point(232, 108);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(264, 27);
            this.txt_designation.TabIndex = 1;
            // 
            // txt_qteMinimale
            // 
            this.txt_qteMinimale.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qteMinimale.Location = new System.Drawing.Point(232, 220);
            this.txt_qteMinimale.Name = "txt_qteMinimale";
            this.txt_qteMinimale.Size = new System.Drawing.Size(264, 27);
            this.txt_qteMinimale.TabIndex = 2;
            // 
            // txt_qteStock
            // 
            this.txt_qteStock.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qteStock.Location = new System.Drawing.Point(232, 162);
            this.txt_qteStock.Name = "txt_qteStock";
            this.txt_qteStock.Size = new System.Drawing.Size(264, 27);
            this.txt_qteStock.TabIndex = 3;
            // 
            // cb_Rubrique
            // 
            this.cb_Rubrique.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cb_Rubrique.FormattingEnabled = true;
            this.cb_Rubrique.Location = new System.Drawing.Point(232, 271);
            this.cb_Rubrique.Name = "cb_Rubrique";
            this.cb_Rubrique.Size = new System.Drawing.Size(264, 29);
            this.cb_Rubrique.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Designation :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nom De Rubrique :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantite Minimale :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Quantite En Stock :";
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_annuler.FlatAppearance.BorderSize = 0;
            this.btn_annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_annuler.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.ForeColor = System.Drawing.Color.White;
            this.btn_annuler.Location = new System.Drawing.Point(289, 374);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(134, 41);
            this.btn_annuler.TabIndex = 59;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_valider.FlatAppearance.BorderSize = 0;
            this.btn_valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.ForeColor = System.Drawing.Color.White;
            this.btn_valider.Location = new System.Drawing.Point(123, 374);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(134, 41);
            this.btn_valider.TabIndex = 58;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btn_rubrique
            // 
            this.btn_rubrique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_rubrique.FlatAppearance.BorderSize = 0;
            this.btn_rubrique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_rubrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rubrique.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rubrique.ForeColor = System.Drawing.Color.White;
            this.btn_rubrique.Location = new System.Drawing.Point(503, 271);
            this.btn_rubrique.Name = "btn_rubrique";
            this.btn_rubrique.Size = new System.Drawing.Size(31, 30);
            this.btn_rubrique.TabIndex = 60;
            this.btn_rubrique.Text = "+";
            this.btn_rubrique.UseVisualStyleBackColor = false;
            // 
            // FrmAMArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 505);
            this.Controls.Add(this.btn_rubrique);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Rubrique);
            this.Controls.Add(this.txt_qteStock);
            this.Controls.Add(this.txt_qteMinimale);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAMArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAMArticle";
            this.pnlMenuBar.ResumeLayout(false);
            this.pnlMenuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_qteMinimale;
        private System.Windows.Forms.TextBox txt_qteStock;
        private System.Windows.Forms.ComboBox cb_Rubrique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btn_rubrique;
    }
}