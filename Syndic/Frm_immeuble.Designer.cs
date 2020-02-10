namespace Syndic
{
    partial class Frm_immeuble
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dtG_utilisateur = new System.Windows.Forms.DataGridView();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.movePrecedent = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.moveFirst = new System.Windows.Forms.Button();
            this.btn_immeuble_Supprimer = new System.Windows.Forms.Button();
            this.btn_immeuble_modifier = new System.Windows.Forms.Button();
            this.btn_immeuble_Ajouter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_utilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.movePrecedent);
            this.groupBox1.Controls.Add(this.MoveNext);
            this.groupBox1.Controls.Add(this.MoveLast);
            this.groupBox1.Controls.Add(this.moveFirst);
            this.groupBox1.Controls.Add(this.btn_immeuble_Supprimer);
            this.groupBox1.Controls.Add(this.btn_immeuble_modifier);
            this.groupBox1.Controls.Add(this.btn_immeuble_Ajouter);
            this.groupBox1.Controls.Add(this.btn_rechercher);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dtG_utilisateur);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 569);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Immeuble";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 23);
            this.textBox1.TabIndex = 5;
            // 
            // dtG_utilisateur
            // 
            this.dtG_utilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_utilisateur.Location = new System.Drawing.Point(22, 77);
            this.dtG_utilisateur.Name = "dtG_utilisateur";
            this.dtG_utilisateur.Size = new System.Drawing.Size(705, 328);
            this.dtG_utilisateur.TabIndex = 4;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_rechercher.FlatAppearance.BorderSize = 0;
            this.btn_rechercher.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Location = new System.Drawing.Point(583, 32);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(144, 34);
            this.btn_rechercher.TabIndex = 30;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = false;
            // 
            // movePrecedent
            // 
            this.movePrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.movePrecedent.FlatAppearance.BorderSize = 0;
            this.movePrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrecedent.ForeColor = System.Drawing.Color.White;
            this.movePrecedent.Location = new System.Drawing.Point(76, 484);
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
            this.MoveNext.Location = new System.Drawing.Point(142, 484);
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
            this.MoveLast.Location = new System.Drawing.Point(195, 484);
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
            this.moveFirst.Location = new System.Drawing.Point(24, 484);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(47, 36);
            this.moveFirst.TabIndex = 44;
            this.moveFirst.Text = "<<";
            this.moveFirst.UseVisualStyleBackColor = false;
            // 
            // btn_immeuble_Supprimer
            // 
            this.btn_immeuble_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_Supprimer.Location = new System.Drawing.Point(609, 484);
            this.btn_immeuble_Supprimer.Name = "btn_immeuble_Supprimer";
            this.btn_immeuble_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_Supprimer.TabIndex = 45;
            this.btn_immeuble_Supprimer.Text = "Supprimer";
            this.btn_immeuble_Supprimer.UseVisualStyleBackColor = false;
            this.btn_immeuble_Supprimer.Click += new System.EventHandler(this.btn_immeuble_Supprimer_Click);
            // 
            // btn_immeuble_modifier
            // 
            this.btn_immeuble_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_modifier.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_modifier.Location = new System.Drawing.Point(487, 484);
            this.btn_immeuble_modifier.Name = "btn_immeuble_modifier";
            this.btn_immeuble_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_modifier.TabIndex = 43;
            this.btn_immeuble_modifier.Text = "Modifier";
            this.btn_immeuble_modifier.UseVisualStyleBackColor = false;
            this.btn_immeuble_modifier.Click += new System.EventHandler(this.btn_immeuble_Supprimer_Click);
            // 
            // btn_immeuble_Ajouter
            // 
            this.btn_immeuble_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_Ajouter.Location = new System.Drawing.Point(365, 484);
            this.btn_immeuble_Ajouter.Name = "btn_immeuble_Ajouter";
            this.btn_immeuble_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_Ajouter.TabIndex = 42;
            this.btn_immeuble_Ajouter.Text = "Ajouter";
            this.btn_immeuble_Ajouter.UseVisualStyleBackColor = false;
            this.btn_immeuble_Ajouter.Click += new System.EventHandler(this.btn_immeuble_Supprimer_Click);
            // 
            // Frm_immeuble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_immeuble";
            this.Text = "Frm_immeuble";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_utilisateur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dtG_utilisateur;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button movePrecedent;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button btn_immeuble_Supprimer;
        private System.Windows.Forms.Button btn_immeuble_modifier;
        private System.Windows.Forms.Button btn_immeuble_Ajouter;
    }
}