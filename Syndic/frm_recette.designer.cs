namespace Syndic
{
    partial class frm_recette
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.btn_Recette_remarque = new System.Windows.Forms.Button();
            this.btn_Recette_Document = new System.Windows.Forms.Button();
            this.btn_recette = new System.Windows.Forms.Button();
            this.pnl_recette_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnl_selection);
            this.panel1.Controls.Add(this.btn_recette);
            this.panel1.Controls.Add(this.btn_Recette_remarque);
            this.panel1.Controls.Add(this.btn_Recette_Document);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 43);
            this.panel1.TabIndex = 0;
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(2, 38);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(255, 5);
            this.pnl_selection.TabIndex = 2;
            // 
            // btn_Recette_remarque
            // 
            this.btn_Recette_remarque.BackColor = System.Drawing.Color.Black;
            this.btn_Recette_remarque.FlatAppearance.BorderSize = 0;
            this.btn_Recette_remarque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_remarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_remarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_remarque.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_remarque.Location = new System.Drawing.Point(515, 1);
            this.btn_Recette_remarque.Name = "btn_Recette_remarque";
            this.btn_Recette_remarque.Size = new System.Drawing.Size(255, 43);
            this.btn_Recette_remarque.TabIndex = 5;
            this.btn_Recette_remarque.Text = "Remarque";
            this.btn_Recette_remarque.UseVisualStyleBackColor = false;
            this.btn_Recette_remarque.Click += new System.EventHandler(this.btn_recette_Click);
            // 
            // btn_Recette_Document
            // 
            this.btn_Recette_Document.BackColor = System.Drawing.Color.Black;
            this.btn_Recette_Document.FlatAppearance.BorderSize = 0;
            this.btn_Recette_Document.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_Recette_Document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recette_Document.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Recette_Document.ForeColor = System.Drawing.Color.White;
            this.btn_Recette_Document.Location = new System.Drawing.Point(259, 1);
            this.btn_Recette_Document.Name = "btn_Recette_Document";
            this.btn_Recette_Document.Size = new System.Drawing.Size(255, 43);
            this.btn_Recette_Document.TabIndex = 3;
            this.btn_Recette_Document.Text = "Document";
            this.btn_Recette_Document.UseVisualStyleBackColor = false;
            this.btn_Recette_Document.Click += new System.EventHandler(this.btn_recette_Click);
            // 
            // btn_recette
            // 
            this.btn_recette.BackColor = System.Drawing.Color.Black;
            this.btn_recette.FlatAppearance.BorderSize = 0;
            this.btn_recette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_recette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recette.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recette.ForeColor = System.Drawing.Color.White;
            this.btn_recette.Location = new System.Drawing.Point(1, 1);
            this.btn_recette.Name = "btn_recette";
            this.btn_recette.Size = new System.Drawing.Size(256, 43);
            this.btn_recette.TabIndex = 2;
            this.btn_recette.Text = "Recette";
            this.btn_recette.UseVisualStyleBackColor = false;
            this.btn_recette.Click += new System.EventHandler(this.btn_recette_Click);
            // 
            // pnl_recette_container
            // 
            this.pnl_recette_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_recette_container.Location = new System.Drawing.Point(0, 43);
            this.pnl_recette_container.Name = "pnl_recette_container";
            this.pnl_recette_container.Size = new System.Drawing.Size(770, 634);
            this.pnl_recette_container.TabIndex = 1;
            this.pnl_recette_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_recette_container_Paint);
            // 
            // frm_recette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnl_recette_container);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_recette";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_recette";
            this.Load += new System.EventHandler(this.frm_recette_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Recette_remarque;
        private System.Windows.Forms.Button btn_Recette_Document;
        private System.Windows.Forms.Button btn_recette;
        private System.Windows.Forms.Panel pnl_selection;
        private System.Windows.Forms.Panel pnl_recette_container;
    }
}