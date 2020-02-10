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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtG_utilisateur = new System.Windows.Forms.DataGridView();
            this.movePrecedent = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.moveFirst = new System.Windows.Forms.Button();
            this.btn_utilisateur_Supprimer = new System.Windows.Forms.Button();
            this.btn_utilisateur_modifier = new System.Windows.Forms.Button();
            this.btn_utilisateur_Ajouter = new System.Windows.Forms.Button();
            this.txt_nomfich = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txt_nomfich);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.movePrecedent);
            this.groupBox1.Controls.Add(this.dtG_utilisateur);
            this.groupBox1.Controls.Add(this.MoveNext);
            this.groupBox1.Controls.Add(this.btn_utilisateur_Ajouter);
            this.groupBox1.Controls.Add(this.MoveLast);
            this.groupBox1.Controls.Add(this.btn_utilisateur_modifier);
            this.groupBox1.Controls.Add(this.moveFirst);
            this.groupBox1.Controls.Add(this.btn_utilisateur_Supprimer);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 569);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Utilisateur";
            // 
            // dtG_utilisateur
            // 
            this.dtG_utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_utilisateur.Location = new System.Drawing.Point(3, 97);
            this.dtG_utilisateur.Name = "dtG_utilisateur";
            this.dtG_utilisateur.Size = new System.Drawing.Size(722, 348);
            this.dtG_utilisateur.TabIndex = 4;
            // 
            // movePrecedent
            // 
            this.movePrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.movePrecedent.FlatAppearance.BorderSize = 0;
            this.movePrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrecedent.ForeColor = System.Drawing.Color.White;
            this.movePrecedent.Location = new System.Drawing.Point(79, 485);
            this.movePrecedent.Name = "movePrecedent";
            this.movePrecedent.Size = new System.Drawing.Size(47, 36);
            this.movePrecedent.TabIndex = 48;
            this.movePrecedent.Text = "<";
            this.movePrecedent.UseVisualStyleBackColor = false;
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.MoveNext.FlatAppearance.BorderSize = 0;
            this.MoveNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(141, 485);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(47, 36);
            this.MoveNext.TabIndex = 47;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.MoveLast.FlatAppearance.BorderSize = 0;
            this.MoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(194, 485);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(47, 36);
            this.MoveLast.TabIndex = 46;
            this.MoveLast.Text = ">>";
            this.MoveLast.UseVisualStyleBackColor = false;
            // 
            // moveFirst
            // 
            this.moveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.moveFirst.FlatAppearance.BorderSize = 0;
            this.moveFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFirst.ForeColor = System.Drawing.Color.White;
            this.moveFirst.Location = new System.Drawing.Point(26, 485);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(47, 36);
            this.moveFirst.TabIndex = 44;
            this.moveFirst.Text = "<<";
            this.moveFirst.UseVisualStyleBackColor = false;
            // 
            // btn_utilisateur_Supprimer
            // 
            this.btn_utilisateur_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_Supprimer.Location = new System.Drawing.Point(611, 485);
            this.btn_utilisateur_Supprimer.Name = "btn_utilisateur_Supprimer";
            this.btn_utilisateur_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_Supprimer.TabIndex = 45;
            this.btn_utilisateur_Supprimer.Text = "Supprimer";
            this.btn_utilisateur_Supprimer.UseVisualStyleBackColor = false;
            this.btn_utilisateur_Supprimer.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // btn_utilisateur_modifier
            // 
            this.btn_utilisateur_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_modifier.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_modifier.Location = new System.Drawing.Point(489, 485);
            this.btn_utilisateur_modifier.Name = "btn_utilisateur_modifier";
            this.btn_utilisateur_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_modifier.TabIndex = 43;
            this.btn_utilisateur_modifier.Text = "Modifier";
            this.btn_utilisateur_modifier.UseVisualStyleBackColor = false;
            this.btn_utilisateur_modifier.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // btn_utilisateur_Ajouter
            // 
            this.btn_utilisateur_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_utilisateur_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_utilisateur_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_utilisateur_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_utilisateur_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_utilisateur_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_utilisateur_Ajouter.Location = new System.Drawing.Point(367, 485);
            this.btn_utilisateur_Ajouter.Name = "btn_utilisateur_Ajouter";
            this.btn_utilisateur_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_utilisateur_Ajouter.TabIndex = 42;
            this.btn_utilisateur_Ajouter.Text = "Ajouter";
            this.btn_utilisateur_Ajouter.UseVisualStyleBackColor = false;
            this.btn_utilisateur_Ajouter.Click += new System.EventHandler(this.btn_utilisateur_Ajouter_Click);
            // 
            // txt_nomfich
            // 
            this.txt_nomfich.Location = new System.Drawing.Point(162, 41);
            this.txt_nomfich.Name = "txt_nomfich";
            this.txt_nomfich.Size = new System.Drawing.Size(264, 23);
            this.txt_nomfich.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 50;
            this.label8.Text = "Nom  :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(609, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 51;
            this.button1.Text = "rechercher";
            this.button1.UseVisualStyleBackColor = false;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_utilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtG_utilisateur;
        private System.Windows.Forms.Button movePrecedent;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button btn_utilisateur_Ajouter;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button btn_utilisateur_modifier;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button btn_utilisateur_Supprimer;
        private System.Windows.Forms.TextBox txt_nomfich;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}