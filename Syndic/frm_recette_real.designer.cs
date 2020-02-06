namespace Syndic
{
    partial class frm_recette_real
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Recette_Ajouter = new System.Windows.Forms.Button();
            this.btn_Recette_modifier = new System.Windows.Forms.Button();
            this.btn_Recette_Annuler = new System.Windows.Forms.Button();
            this.btn_Recette_Supprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cyan;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(27, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(698, 418);
            this.dataGridView1.TabIndex = 0;
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(27, 78);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(494, 34);
            this.txt_search.TabIndex = 7;
            this.txt_search.Enter += new System.EventHandler(this.txt_search_Enter);
            this.txt_search.Leave += new System.EventHandler(this.txt_search_Leave);
            // 
            // btn_Recette_Ajouter
            // 
            this.btn_Recette_Ajouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Ajouter.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Ajouter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Ajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Ajouter.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Ajouter.Location = new System.Drawing.Point(365, 542);
            this.btn_Recette_Ajouter.Name = "btn_Recette_Ajouter";
            this.btn_Recette_Ajouter.Size = new System.Drawing.Size(116, 43);
            this.btn_Recette_Ajouter.TabIndex = 4;
            this.btn_Recette_Ajouter.Text = "Ajouter";
            this.btn_Recette_Ajouter.UseVisualStyleBackColor = false;
            this.btn_Recette_Ajouter.Click += new System.EventHandler(this.btn_Recette_Ajouter_Click);
            // 
            // btn_Recette_modifier
            // 
            this.btn_Recette_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_modifier.FlatAppearance.BorderSize = 0;
            this.btn_Recette_modifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_modifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_modifier.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_modifier.Location = new System.Drawing.Point(487, 542);
            this.btn_Recette_modifier.Name = "btn_Recette_modifier";
            this.btn_Recette_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_Recette_modifier.TabIndex = 5;
            this.btn_Recette_modifier.Text = "Modifier";
            this.btn_Recette_modifier.UseVisualStyleBackColor = false;
            this.btn_Recette_modifier.Click += new System.EventHandler(this.btn_Recette_Ajouter_Click);
            // 
            // btn_Recette_Annuler
            // 
            this.btn_Recette_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Annuler.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Annuler.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Annuler.Location = new System.Drawing.Point(27, 542);
            this.btn_Recette_Annuler.Name = "btn_Recette_Annuler";
            this.btn_Recette_Annuler.Size = new System.Drawing.Size(47, 36);
            this.btn_Recette_Annuler.TabIndex = 7;
            this.btn_Recette_Annuler.Text = "<<";
            this.btn_Recette_Annuler.UseVisualStyleBackColor = false;
            this.btn_Recette_Annuler.Click += new System.EventHandler(this.btn_Recette_Ajouter_Click);
            // 
            // btn_Recette_Supprimer
            // 
            this.btn_Recette_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Supprimer.Location = new System.Drawing.Point(609, 542);
            this.btn_Recette_Supprimer.Name = "btn_Recette_Supprimer";
            this.btn_Recette_Supprimer.Size = new System.Drawing.Size(116, 43);
            this.btn_Recette_Supprimer.TabIndex = 8;
            this.btn_Recette_Supprimer.Text = "Supprimer";
            this.btn_Recette_Supprimer.UseVisualStyleBackColor = false;
            this.btn_Recette_Supprimer.Click += new System.EventHandler(this.btn_Recette_Ajouter_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(581, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(199, 542);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 36);
            this.button2.TabIndex = 16;
            this.button2.Text = ">>";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(146, 542);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 36);
            this.button3.TabIndex = 17;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(80, 542);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 36);
            this.button4.TabIndex = 18;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // frm_recette_real
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Recette_Annuler);
            this.Controls.Add(this.btn_Recette_Supprimer);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Recette_modifier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Recette_Ajouter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recette_real";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_recette_real";
            this.Load += new System.EventHandler(this.frm_recette_real_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Recette_Ajouter;
        private System.Windows.Forms.Button btn_Recette_modifier;
        private System.Windows.Forms.Button btn_Recette_Annuler;
        private System.Windows.Forms.Button btn_Recette_Supprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}