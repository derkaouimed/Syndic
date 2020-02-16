namespace Syndic
{
    partial class FrmFactures
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
            this.btn_remarques = new System.Windows.Forms.Button();
            this.btn_documents = new System.Windows.Forms.Button();
            this.btn_facture = new System.Windows.Forms.Button();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.pnlMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.btn_remarques);
            this.pnlMenuBar.Controls.Add(this.btn_documents);
            this.pnlMenuBar.Controls.Add(this.btn_facture);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(770, 43);
            this.pnlMenuBar.TabIndex = 0;
            // 
            // btn_remarques
            // 
            this.btn_remarques.BackColor = System.Drawing.Color.Black;
            this.btn_remarques.FlatAppearance.BorderSize = 0;
            this.btn_remarques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_remarques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_remarques.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_remarques.ForeColor = System.Drawing.Color.White;
            this.btn_remarques.Location = new System.Drawing.Point(515, 0);
            this.btn_remarques.Name = "btn_remarques";
            this.btn_remarques.Size = new System.Drawing.Size(255, 43);
            this.btn_remarques.TabIndex = 6;
            this.btn_remarques.Text = "Les Remarques";
            this.btn_remarques.UseVisualStyleBackColor = false;
            this.btn_remarques.Click += new System.EventHandler(this.btn_facture_Click);
            // 
            // btn_documents
            // 
            this.btn_documents.BackColor = System.Drawing.Color.Black;
            this.btn_documents.FlatAppearance.BorderSize = 0;
            this.btn_documents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_documents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_documents.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_documents.ForeColor = System.Drawing.Color.White;
            this.btn_documents.Location = new System.Drawing.Point(258, 0);
            this.btn_documents.Name = "btn_documents";
            this.btn_documents.Size = new System.Drawing.Size(255, 43);
            this.btn_documents.TabIndex = 5;
            this.btn_documents.Text = "Les Documents";
            this.btn_documents.UseVisualStyleBackColor = false;
            this.btn_documents.Click += new System.EventHandler(this.btn_facture_Click);
            // 
            // btn_facture
            // 
            this.btn_facture.BackColor = System.Drawing.Color.Black;
            this.btn_facture.FlatAppearance.BorderSize = 0;
            this.btn_facture.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_facture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_facture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_facture.ForeColor = System.Drawing.Color.White;
            this.btn_facture.Location = new System.Drawing.Point(0, 0);
            this.btn_facture.Name = "btn_facture";
            this.btn_facture.Size = new System.Drawing.Size(256, 43);
            this.btn_facture.TabIndex = 4;
            this.btn_facture.Text = "Les Factures";
            this.btn_facture.UseVisualStyleBackColor = false;
            this.btn_facture.Click += new System.EventHandler(this.btn_facture_Click);
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(0, 39);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(255, 5);
            this.pnl_selection.TabIndex = 5;
            // 
            // pnl_forms
            // 
            this.pnl_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_forms.Location = new System.Drawing.Point(0, 43);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(770, 634);
            this.pnl_forms.TabIndex = 6;
            // 
            // FrmFactures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnl_selection);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFactures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFactures";
            this.Load += new System.EventHandler(this.FrmFactures_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btn_remarques;
        private System.Windows.Forms.Button btn_documents;
        private System.Windows.Forms.Button btn_facture;
        private System.Windows.Forms.Panel pnl_selection;
        private System.Windows.Forms.Panel pnl_forms;
    }
}