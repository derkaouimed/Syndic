namespace Syndic
{
    partial class frm_recette_document
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
            this.btn_RecetteDocument_Supprimer = new System.Windows.Forms.Button();
            this.btn_RecetteDocument_modifier = new System.Windows.Forms.Button();
            this.btn_RecetteDocument_Ajouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Recette_Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_RecetteDocument_Supprimer
            // 
            this.btn_RecetteDocument_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_RecetteDocument_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_RecetteDocument_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_RecetteDocument_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecetteDocument_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecetteDocument_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_RecetteDocument_Supprimer.Location = new System.Drawing.Point(602, 541);
            this.btn_RecetteDocument_Supprimer.Name = "btn_RecetteDocument_Supprimer";
            this.btn_RecetteDocument_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_RecetteDocument_Supprimer.TabIndex = 8;
            this.btn_RecetteDocument_Supprimer.Text = "Supprimer";
            this.btn_RecetteDocument_Supprimer.UseVisualStyleBackColor = false;
            this.btn_RecetteDocument_Supprimer.Click += new System.EventHandler(this.btn_RecetteDocument_Ajouter_Click);
            // 
            // btn_RecetteDocument_modifier
            // 
            this.btn_RecetteDocument_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_RecetteDocument_modifier.FlatAppearance.BorderSize = 0;
            this.btn_RecetteDocument_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_RecetteDocument_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecetteDocument_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecetteDocument_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_RecetteDocument_modifier.Location = new System.Drawing.Point(469, 541);
            this.btn_RecetteDocument_modifier.Name = "btn_RecetteDocument_modifier";
            this.btn_RecetteDocument_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_RecetteDocument_modifier.TabIndex = 5;
            this.btn_RecetteDocument_modifier.Text = "Modifier";
            this.btn_RecetteDocument_modifier.UseVisualStyleBackColor = false;
            this.btn_RecetteDocument_modifier.Click += new System.EventHandler(this.btn_RecetteDocument_Ajouter_Click);
            // 
            // btn_RecetteDocument_Ajouter
            // 
            this.btn_RecetteDocument_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_RecetteDocument_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_RecetteDocument_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_RecetteDocument_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RecetteDocument_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RecetteDocument_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_RecetteDocument_Ajouter.Location = new System.Drawing.Point(329, 541);
            this.btn_RecetteDocument_Ajouter.Name = "btn_RecetteDocument_Ajouter";
            this.btn_RecetteDocument_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_RecetteDocument_Ajouter.TabIndex = 4;
            this.btn_RecetteDocument_Ajouter.Text = "Ajouter";
            this.btn_RecetteDocument_Ajouter.UseVisualStyleBackColor = false;
            this.btn_RecetteDocument_Ajouter.Click += new System.EventHandler(this.btn_RecetteDocument_Ajouter_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(679, 455);
            this.dataGridView1.TabIndex = 11;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(39, 40);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(484, 34);
            this.txt_search.TabIndex = 12;
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(602, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 14;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(92, 541);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(158, 541);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 36);
            this.button3.TabIndex = 21;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(211, 541);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 36);
            this.button2.TabIndex = 20;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_Recette_Annuler
            // 
            this.btn_Recette_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_Recette_Annuler.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Annuler.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Annuler.Location = new System.Drawing.Point(39, 541);
            this.btn_Recette_Annuler.Name = "btn_Recette_Annuler";
            this.btn_Recette_Annuler.Size = new System.Drawing.Size(47, 36);
            this.btn_Recette_Annuler.TabIndex = 19;
            this.btn_Recette_Annuler.Text = "<<";
            this.btn_Recette_Annuler.UseVisualStyleBackColor = false;
            // 
            // frm_recette_document
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Recette_Annuler);
            this.Controls.Add(this.btn_RecetteDocument_Supprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_RecetteDocument_modifier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_RecetteDocument_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recette_document";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_recette_document";
            this.Load += new System.EventHandler(this.frm_recette_document_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_RecetteDocument_Supprimer;
        private System.Windows.Forms.Button btn_RecetteDocument_modifier;
        private System.Windows.Forms.Button btn_RecetteDocument_Ajouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Recette_Annuler;
    }
}