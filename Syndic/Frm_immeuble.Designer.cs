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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_immeuble));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.btn_immeuble_Supprimer = new System.Windows.Forms.Button();
            this.btn_immeuble_modifier = new System.Windows.Forms.Button();
            this.btn_immeuble_Ajouter = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.dtG_immeuble = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_immeuble)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_chercher);
            this.groupBox1.Controls.Add(this.btn_suivant);
            this.groupBox1.Controls.Add(this.btn_precedent);
            this.groupBox1.Controls.Add(this.btn_derniere);
            this.groupBox1.Controls.Add(this.btn_premiere);
            this.groupBox1.Controls.Add(this.btn_immeuble_Supprimer);
            this.groupBox1.Controls.Add(this.btn_immeuble_modifier);
            this.groupBox1.Controls.Add(this.btn_immeuble_Ajouter);
            this.groupBox1.Controls.Add(this.btn_rechercher);
            this.groupBox1.Controls.Add(this.dtG_immeuble);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 569);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Immeuble";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txt_chercher
            // 
            this.txt_chercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher.Location = new System.Drawing.Point(22, 32);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(381, 27);
            this.txt_chercher.TabIndex = 50;
            this.txt_chercher.Text = "Chercher Par Nom";
            this.txt_chercher.TextChanged += new System.EventHandler(this.txt_chercher_TextChanged);
            this.txt_chercher.Enter += new System.EventHandler(this.txt_chercher_Enter);
            this.txt_chercher.Leave += new System.EventHandler(this.txt_chercher_Leave);
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
            this.btn_suivant.Location = new System.Drawing.Point(152, 484);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 48;
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
            this.btn_precedent.Location = new System.Drawing.Point(74, 484);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 47;
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
            this.btn_derniere.Location = new System.Drawing.Point(204, 484);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 49;
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
            this.btn_premiere.Location = new System.Drawing.Point(22, 484);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 46;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_premiere_Click);
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
            this.btn_rechercher.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // dtG_immeuble
            // 
            this.dtG_immeuble.BackgroundColor = System.Drawing.Color.White;
            this.dtG_immeuble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtG_immeuble.Location = new System.Drawing.Point(22, 77);
            this.dtG_immeuble.Name = "dtG_immeuble";
            this.dtG_immeuble.Size = new System.Drawing.Size(705, 328);
            this.dtG_immeuble.TabIndex = 4;
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
            this.Load += new System.EventHandler(this.Frm_immeuble_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtG_immeuble)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtG_immeuble;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_immeuble_Supprimer;
        private System.Windows.Forms.Button btn_immeuble_modifier;
        private System.Windows.Forms.Button btn_immeuble_Ajouter;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.TextBox txt_chercher;
    }
}