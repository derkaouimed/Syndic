namespace Syndic
{
    partial class Frm_Bien
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
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl_selection = new System.Windows.Forms.Panel();
            this.btn_bien_document = new System.Windows.Forms.Button();
            this.btn_bien = new System.Windows.Forms.Button();
            this.btn_bien_remarque = new System.Windows.Forms.Button();
            this.pnl_Bien_container = new System.Windows.Forms.Panel();
            this.pnl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.pnl_selection);
            this.pnl1.Controls.Add(this.btn_bien_document);
            this.pnl1.Controls.Add(this.btn_bien);
            this.pnl1.Controls.Add(this.btn_bien_remarque);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(770, 42);
            this.pnl1.TabIndex = 1;
            // 
            // pnl_selection
            // 
            this.pnl_selection.BackColor = System.Drawing.Color.Orange;
            this.pnl_selection.Location = new System.Drawing.Point(0, 37);
            this.pnl_selection.Name = "pnl_selection";
            this.pnl_selection.Size = new System.Drawing.Size(257, 5);
            this.pnl_selection.TabIndex = 2;
            // 
            // btn_bien_document
            // 
            this.btn_bien_document.BackColor = System.Drawing.Color.Black;
            this.btn_bien_document.FlatAppearance.BorderSize = 0;
            this.btn_bien_document.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_bien_document.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bien_document.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bien_document.ForeColor = System.Drawing.Color.White;
            this.btn_bien_document.Location = new System.Drawing.Point(257, -1);
            this.btn_bien_document.Name = "btn_bien_document";
            this.btn_bien_document.Size = new System.Drawing.Size(257, 43);
            this.btn_bien_document.TabIndex = 3;
            this.btn_bien_document.Text = "Document";
            this.btn_bien_document.UseVisualStyleBackColor = false;
            this.btn_bien_document.Click += new System.EventHandler(this.btn_document_Click);
            // 
            // btn_bien
            // 
            this.btn_bien.BackColor = System.Drawing.Color.Black;
            this.btn_bien.FlatAppearance.BorderSize = 0;
            this.btn_bien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_bien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bien.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bien.ForeColor = System.Drawing.Color.White;
            this.btn_bien.Location = new System.Drawing.Point(0, 0);
            this.btn_bien.Name = "btn_bien";
            this.btn_bien.Size = new System.Drawing.Size(257, 43);
            this.btn_bien.TabIndex = 1;
            this.btn_bien.Text = "Bien";
            this.btn_bien.UseVisualStyleBackColor = false;
            this.btn_bien.Click += new System.EventHandler(this.btn_document_Click);
            // 
            // btn_bien_remarque
            // 
            this.btn_bien_remarque.BackColor = System.Drawing.Color.Black;
            this.btn_bien_remarque.FlatAppearance.BorderSize = 0;
            this.btn_bien_remarque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_bien_remarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bien_remarque.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bien_remarque.ForeColor = System.Drawing.Color.White;
            this.btn_bien_remarque.Location = new System.Drawing.Point(514, 0);
            this.btn_bien_remarque.Name = "btn_bien_remarque";
            this.btn_bien_remarque.Size = new System.Drawing.Size(257, 43);
            this.btn_bien_remarque.TabIndex = 2;
            this.btn_bien_remarque.Text = "Remarque";
            this.btn_bien_remarque.UseVisualStyleBackColor = false;
            this.btn_bien_remarque.Click += new System.EventHandler(this.btn_document_Click);
            // 
            // pnl_Bien_container
            // 
            this.pnl_Bien_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Bien_container.Location = new System.Drawing.Point(0, 42);
            this.pnl_Bien_container.Name = "pnl_Bien_container";
            this.pnl_Bien_container.Size = new System.Drawing.Size(770, 635);
            this.pnl_Bien_container.TabIndex = 2;
            this.pnl_Bien_container.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Bien_container_Paint);
            // 
            // Frm_Bien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 677);
            this.Controls.Add(this.pnl_Bien_container);
            this.Controls.Add(this.pnl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Bien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Bien";
            this.pnl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl_selection;
        private System.Windows.Forms.Button btn_bien_document;
        private System.Windows.Forms.Button btn_bien;
        private System.Windows.Forms.Button btn_bien_remarque;
        private System.Windows.Forms.Panel pnl_Bien_container;
    }
}