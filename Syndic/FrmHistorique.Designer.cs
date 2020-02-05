namespace Syndic
{
    partial class FrmHistorique
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
            this.btn_connexion = new System.Windows.Forms.Button();
            this.btn_journal = new System.Windows.Forms.Button();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(770, 43);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // btn_connexion
            // 
            this.btn_connexion.BackColor = System.Drawing.Color.Black;
            this.btn_connexion.FlatAppearance.BorderSize = 0;
            this.btn_connexion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.ForeColor = System.Drawing.Color.White;
            this.btn_connexion.Location = new System.Drawing.Point(386, 0);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.Size = new System.Drawing.Size(384, 43);
            this.btn_connexion.TabIndex = 3;
            this.btn_connexion.Text = "Connexion";
            this.btn_connexion.UseVisualStyleBackColor = false;
            this.btn_connexion.Click += new System.EventHandler(this.btn_journal_Click);
            // 
            // btn_journal
            // 
            this.btn_journal.BackColor = System.Drawing.Color.Black;
            this.btn_journal.FlatAppearance.BorderSize = 0;
            this.btn_journal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_journal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_journal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_journal.ForeColor = System.Drawing.Color.White;
            this.btn_journal.Location = new System.Drawing.Point(0, 0);
            this.btn_journal.Name = "btn_journal";
            this.btn_journal.Size = new System.Drawing.Size(384, 43);
            this.btn_journal.TabIndex = 2;
            this.btn_journal.Text = "Journal";
            this.btn_journal.UseVisualStyleBackColor = false;
            this.btn_journal.Click += new System.EventHandler(this.btn_journal_Click);
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(0, 38);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(384, 5);
            this.pnl_selection.TabIndex = 4;
            // 
            // pnl_forms
            // 
            this.pnl_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_forms.Location = new System.Drawing.Point(0, 43);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(770, 634);
            this.pnl_forms.TabIndex = 5;
            // 
            // FrmHistorique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnl_selection);
            this.Controls.Add(this.btn_connexion);
            this.Controls.Add(this.btn_journal);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistorique";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmHistorique";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btn_connexion;
        private System.Windows.Forms.Button btn_journal;
        private System.Windows.Forms.Panel pnl_selection;
        private System.Windows.Forms.Panel pnl_forms;
    }
}