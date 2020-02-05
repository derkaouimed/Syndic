namespace Syndic
{
    partial class FrmArticle
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
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.btn_article = new System.Windows.Forms.Button();
            this.btn_achat = new System.Windows.Forms.Button();
            this.pnl_forms = new System.Windows.Forms.Panel();
            this.pnlMenuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuBar
            // 
            this.pnlMenuBar.Controls.Add(this.pnl_selection);
            this.pnlMenuBar.Controls.Add(this.btn_article);
            this.pnlMenuBar.Controls.Add(this.btn_achat);
            this.pnlMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuBar.Name = "pnlMenuBar";
            this.pnlMenuBar.Size = new System.Drawing.Size(770, 43);
            this.pnlMenuBar.TabIndex = 36;
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(386, 38);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(384, 5);
            this.pnl_selection.TabIndex = 6;
            // 
            // btn_article
            // 
            this.btn_article.BackColor = System.Drawing.Color.Black;
            this.btn_article.FlatAppearance.BorderSize = 0;
            this.btn_article.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_article.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_article.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_article.ForeColor = System.Drawing.Color.White;
            this.btn_article.Location = new System.Drawing.Point(0, 0);
            this.btn_article.Name = "btn_article";
            this.btn_article.Size = new System.Drawing.Size(384, 43);
            this.btn_article.TabIndex = 5;
            this.btn_article.Text = "Les Articles En Stock";
            this.btn_article.UseVisualStyleBackColor = false;
            this.btn_article.Click += new System.EventHandler(this.btn_article_Click);
            // 
            // btn_achat
            // 
            this.btn_achat.BackColor = System.Drawing.Color.Black;
            this.btn_achat.FlatAppearance.BorderSize = 0;
            this.btn_achat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_achat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_achat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_achat.ForeColor = System.Drawing.Color.White;
            this.btn_achat.Location = new System.Drawing.Point(386, 0);
            this.btn_achat.Name = "btn_achat";
            this.btn_achat.Size = new System.Drawing.Size(384, 43);
            this.btn_achat.TabIndex = 4;
            this.btn_achat.Text = "Les Achats";
            this.btn_achat.UseVisualStyleBackColor = false;
            this.btn_achat.Click += new System.EventHandler(this.btn_article_Click);
            // 
            // pnl_forms
            // 
            this.pnl_forms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_forms.Location = new System.Drawing.Point(0, 43);
            this.pnl_forms.Name = "pnl_forms";
            this.pnl_forms.Size = new System.Drawing.Size(770, 634);
            this.pnl_forms.TabIndex = 37;
            // 
            // FrmArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnl_forms);
            this.Controls.Add(this.pnlMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArticle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArticle";
            this.Load += new System.EventHandler(this.FrmArticle_Load);
            this.pnlMenuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlMenuBar;
        private System.Windows.Forms.Button btn_article;
        private System.Windows.Forms.Button btn_achat;
        private System.Windows.Forms.Panel pnl_selection;
        private System.Windows.Forms.Panel pnl_forms;
    }
}