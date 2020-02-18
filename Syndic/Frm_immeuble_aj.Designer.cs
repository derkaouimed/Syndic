namespace Syndic
{
    partial class Frm_immeuble_aj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_immeuble_aj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_res = new System.Windows.Forms.ComboBox();
            this.txt_tit = new System.Windows.Forms.TextBox();
            this.txt_nm = new System.Windows.Forms.TextBox();
            this.btn_immeuble_Annuler = new System.Windows.Forms.Button();
            this.btn_immeuble_valider = new System.Windows.Forms.Button();
            this.btn_res = new System.Windows.Forms.Button();
            this.txt_pai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 23);
            this.panel1.TabIndex = 26;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(330, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(22, 24);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(362, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 24);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_close.BackgroundImage")));
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Location = new System.Drawing.Point(380, -1);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(22, 24);
            this.btn_close.TabIndex = 19;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Residence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 57;
            this.label2.Text = "Titre Foncier :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nom immeuble :";
            // 
            // cmb_res
            // 
            this.cmb_res.FormattingEnabled = true;
            this.cmb_res.Location = new System.Drawing.Point(176, 142);
            this.cmb_res.Name = "cmb_res";
            this.cmb_res.Size = new System.Drawing.Size(100, 21);
            this.cmb_res.TabIndex = 56;
            // 
            // txt_tit
            // 
            this.txt_tit.Location = new System.Drawing.Point(176, 194);
            this.txt_tit.Name = "txt_tit";
            this.txt_tit.Size = new System.Drawing.Size(100, 20);
            this.txt_tit.TabIndex = 55;
            // 
            // txt_nm
            // 
            this.txt_nm.Location = new System.Drawing.Point(176, 98);
            this.txt_nm.Name = "txt_nm";
            this.txt_nm.Size = new System.Drawing.Size(100, 20);
            this.txt_nm.TabIndex = 54;
            // 
            // btn_immeuble_Annuler
            // 
            this.btn_immeuble_Annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_Annuler.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_Annuler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_Annuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_Annuler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_Annuler.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_Annuler.Location = new System.Drawing.Point(176, 370);
            this.btn_immeuble_Annuler.Name = "btn_immeuble_Annuler";
            this.btn_immeuble_Annuler.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_Annuler.TabIndex = 60;
            this.btn_immeuble_Annuler.Text = "Annuler";
            this.btn_immeuble_Annuler.UseVisualStyleBackColor = false;
            this.btn_immeuble_Annuler.Click += new System.EventHandler(this.btn_immeuble_Annuler_Click);
            // 
            // btn_immeuble_valider
            // 
            this.btn_immeuble_valider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_immeuble_valider.FlatAppearance.BorderSize = 0;
            this.btn_immeuble_valider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_immeuble_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_immeuble_valider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_immeuble_valider.ForeColor = System.Drawing.Color.White;
            this.btn_immeuble_valider.Location = new System.Drawing.Point(28, 370);
            this.btn_immeuble_valider.Name = "btn_immeuble_valider";
            this.btn_immeuble_valider.Size = new System.Drawing.Size(116, 43);
            this.btn_immeuble_valider.TabIndex = 59;
            this.btn_immeuble_valider.Text = "Valider";
            this.btn_immeuble_valider.UseVisualStyleBackColor = false;
            this.btn_immeuble_valider.Click += new System.EventHandler(this.btn_immeuble_valider_Click);
            // 
            // btn_res
            // 
            this.btn_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_res.FlatAppearance.BorderSize = 0;
            this.btn_res.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btn_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_res.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_res.ForeColor = System.Drawing.Color.White;
            this.btn_res.Location = new System.Drawing.Point(299, 142);
            this.btn_res.Name = "btn_res";
            this.btn_res.Size = new System.Drawing.Size(41, 21);
            this.btn_res.TabIndex = 79;
            this.btn_res.Text = "...";
            this.btn_res.UseVisualStyleBackColor = false;
            this.btn_res.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_pai
            // 
            this.txt_pai.Location = new System.Drawing.Point(176, 245);
            this.txt_pai.Name = "txt_pai";
            this.txt_pai.Size = new System.Drawing.Size(100, 20);
            this.txt_pai.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(25, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 57;
            this.label3.Text = "Paiment :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 57;
            // 
            // Frm_immeuble_aj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.txt_pai);
            this.Controls.Add(this.btn_res);
            this.Controls.Add(this.btn_immeuble_Annuler);
            this.Controls.Add(this.btn_immeuble_valider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nm);
            this.Controls.Add(this.cmb_res);
            this.Controls.Add(this.txt_tit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_immeuble_aj";
            this.Text = "Frm_immeuble_aj";
            this.Load += new System.EventHandler(this.Frm_immeuble_aj_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_res;
        private System.Windows.Forms.TextBox txt_tit;
        private System.Windows.Forms.TextBox txt_nm;
        private System.Windows.Forms.Button btn_immeuble_Annuler;
        private System.Windows.Forms.Button btn_immeuble_valider;
        private System.Windows.Forms.Button btn_res;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_pai;
        private System.Windows.Forms.Label label3;
    }
}