﻿namespace Syndic
{
    partial class FrmOublie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOublie));
            this.lbl_connecter = new System.Windows.Forms.Label();
            this.btn_envoye = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_minimaze = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_connecter
            // 
            this.lbl_connecter.AutoSize = true;
            this.lbl_connecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_connecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_connecter.Location = new System.Drawing.Point(179, 337);
            this.lbl_connecter.Name = "lbl_connecter";
            this.lbl_connecter.Size = new System.Drawing.Size(69, 16);
            this.lbl_connecter.TabIndex = 2;
            this.lbl_connecter.Text = "Connecter";
            this.lbl_connecter.Click += new System.EventHandler(this.lbl_connecter_Click);
            // 
            // btn_envoye
            // 
            this.btn_envoye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_envoye.FlatAppearance.BorderSize = 0;
            this.btn_envoye.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_envoye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_envoye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_envoye.ForeColor = System.Drawing.Color.White;
            this.btn_envoye.Location = new System.Drawing.Point(96, 287);
            this.btn_envoye.Name = "btn_envoye";
            this.btn_envoye.Size = new System.Drawing.Size(242, 43);
            this.btn_envoye.TabIndex = 1;
            this.btn_envoye.Text = "Envoye";
            this.btn_envoye.UseVisualStyleBackColor = false;
            this.btn_envoye.Click += new System.EventHandler(this.btn_envoye_Click);
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Gray;
            this.txt_username.Location = new System.Drawing.Point(96, 239);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(242, 26);
            this.txt_username.TabIndex = 0;
            this.txt_username.Text = "Tapez Votre Email";
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_minimaze);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 23);
            this.panel1.TabIndex = 11;
            // 
            // btn_minimaze
            // 
            this.btn_minimaze.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_minimaze.BackgroundImage")));
            this.btn_minimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_minimaze.FlatAppearance.BorderSize = 0;
            this.btn_minimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimaze.Location = new System.Drawing.Point(369, -1);
            this.btn_minimaze.Name = "btn_minimaze";
            this.btn_minimaze.Size = new System.Drawing.Size(22, 24);
            this.btn_minimaze.TabIndex = 3;
            this.btn_minimaze.UseVisualStyleBackColor = true;
            this.btn_minimaze.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(397, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(22, 24);
            this.btn_close.TabIndex = 4;
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // FrmOublie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 452);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_connecter);
            this.Controls.Add(this.btn_envoye);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOublie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOublie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_connecter;
        private System.Windows.Forms.Button btn_envoye;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_minimaze;
        private System.Windows.Forms.Button btn_close;
    }
}