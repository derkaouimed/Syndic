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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_Recette_Ajouter = new System.Windows.Forms.Button();
            this.btn_Recette_modifier = new System.Windows.Forms.Button();
            this.moveFirst = new System.Windows.Forms.Button();
            this.btn_Recette_Supprimer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MoveLast = new System.Windows.Forms.Button();
            this.MoveNext = new System.Windows.Forms.Button();
            this.movePrecedent = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(12, 35);
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
            this.btn_Recette_Ajouter.Location = new System.Drawing.Point(398, 561);
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
            this.btn_Recette_modifier.Location = new System.Drawing.Point(520, 561);
            this.btn_Recette_modifier.Name = "btn_Recette_modifier";
            this.btn_Recette_modifier.Size = new System.Drawing.Size(116, 43);
            this.btn_Recette_modifier.TabIndex = 5;
            this.btn_Recette_modifier.Text = "Modifier";
            this.btn_Recette_modifier.UseVisualStyleBackColor = false;
            this.btn_Recette_modifier.Click += new System.EventHandler(this.btn_Recette_Ajouter_Click);
            // 
            // moveFirst
            // 
            this.moveFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatAppearance.BorderSize = 0;
            this.moveFirst.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.moveFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.moveFirst.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moveFirst.ForeColor = System.Drawing.Color.White;
            this.moveFirst.Location = new System.Drawing.Point(12, 561);
            this.moveFirst.Name = "moveFirst";
            this.moveFirst.Size = new System.Drawing.Size(47, 36);
            this.moveFirst.TabIndex = 7;
            this.moveFirst.Text = "<<";
            this.moveFirst.UseVisualStyleBackColor = false;
            this.moveFirst.Click += new System.EventHandler(this.moveFirst_Click);
            // 
            // btn_Recette_Supprimer
            // 
            this.btn_Recette_Supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Supprimer.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Supprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Supprimer.Location = new System.Drawing.Point(642, 561);
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
            this.button1.Location = new System.Drawing.Point(614, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MoveLast
            // 
            this.MoveLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatAppearance.BorderSize = 0;
            this.MoveLast.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveLast.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveLast.ForeColor = System.Drawing.Color.White;
            this.MoveLast.Location = new System.Drawing.Point(184, 561);
            this.MoveLast.Name = "MoveLast";
            this.MoveLast.Size = new System.Drawing.Size(47, 36);
            this.MoveLast.TabIndex = 16;
            this.MoveLast.Text = ">>";
            this.MoveLast.UseVisualStyleBackColor = false;
            this.MoveLast.Click += new System.EventHandler(this.MoveLast_Click);
            // 
            // MoveNext
            // 
            this.MoveNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatAppearance.BorderSize = 0;
            this.MoveNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.MoveNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoveNext.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoveNext.ForeColor = System.Drawing.Color.White;
            this.MoveNext.Location = new System.Drawing.Point(131, 561);
            this.MoveNext.Name = "MoveNext";
            this.MoveNext.Size = new System.Drawing.Size(47, 36);
            this.MoveNext.TabIndex = 17;
            this.MoveNext.Text = ">";
            this.MoveNext.UseVisualStyleBackColor = false;
            this.MoveNext.Click += new System.EventHandler(this.MoveNext_Click);
            // 
            // movePrecedent
            // 
            this.movePrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatAppearance.BorderSize = 0;
            this.movePrecedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.movePrecedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movePrecedent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movePrecedent.ForeColor = System.Drawing.Color.White;
            this.movePrecedent.Location = new System.Drawing.Point(65, 561);
            this.movePrecedent.Name = "movePrecedent";
            this.movePrecedent.Size = new System.Drawing.Size(47, 36);
            this.movePrecedent.TabIndex = 18;
            this.movePrecedent.Text = "<";
            this.movePrecedent.UseVisualStyleBackColor = false;
            this.movePrecedent.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.ColumnHeadersHeight = 48;
            this.dataGridView1.Location = new System.Drawing.Point(12, 79);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(746, 476);
            this.dataGridView1.TabIndex = 19;
            // 
            // frm_recette_real
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.movePrecedent);
            this.Controls.Add(this.MoveNext);
            this.Controls.Add(this.MoveLast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moveFirst);
            this.Controls.Add(this.btn_Recette_Supprimer);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_Recette_modifier);
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
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_Recette_Ajouter;
        private System.Windows.Forms.Button btn_Recette_modifier;
        private System.Windows.Forms.Button moveFirst;
        private System.Windows.Forms.Button btn_Recette_Supprimer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button MoveLast;
        private System.Windows.Forms.Button MoveNext;
        private System.Windows.Forms.Button movePrecedent;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}