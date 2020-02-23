namespace Syndic
{
    partial class FrmConnexion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConnexion));
            this.dt_grid = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_vider = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_premiere = new System.Windows.Forms.Button();
            this.btn_derniere = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.grp_chercher = new System.Windows.Forms.GroupBox();
            this.rd_date = new System.Windows.Forms.RadioButton();
            this.rd_type = new System.Windows.Forms.RadioButton();
            this.rd_nomPrenom = new System.Windows.Forms.RadioButton();
            this.pnl_nomPrenom = new System.Windows.Forms.Panel();
            this.pnl_date = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dt_de = new System.Windows.Forms.DateTimePicker();
            this.dt_a = new System.Windows.Forms.DateTimePicker();
            this.btn_chercherDate = new System.Windows.Forms.Button();
            this.btn_chercherNom = new System.Windows.Forms.Button();
            this.txt_chercher = new System.Windows.Forms.TextBox();
            this.pnl_type = new System.Windows.Forms.Panel();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_chercherType = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).BeginInit();
            this.grp_chercher.SuspendLayout();
            this.pnl_nomPrenom.SuspendLayout();
            this.pnl_date.SuspendLayout();
            this.pnl_type.SuspendLayout();
            this.SuspendLayout();
            // 
            // dt_grid
            // 
            this.dt_grid.AllowUserToAddRows = false;
            this.dt_grid.AllowUserToDeleteRows = false;
            this.dt_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dt_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dt_grid.ColumnHeadersHeight = 35;
            this.dt_grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prenom,
            this.type,
            this.date});
            this.dt_grid.Location = new System.Drawing.Point(12, 234);
            this.dt_grid.MultiSelect = false;
            this.dt_grid.Name = "dt_grid";
            this.dt_grid.ReadOnly = true;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_grid.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dt_grid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_grid.RowTemplate.Height = 25;
            this.dt_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dt_grid.Size = new System.Drawing.Size(746, 311);
            this.dt_grid.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prenom
            // 
            this.prenom.HeaderText = "Prénom";
            this.prenom.Name = "prenom";
            this.prenom.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "Type D\'Utilisateur";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date Connexion";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // btn_vider
            // 
            this.btn_vider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_vider.FlatAppearance.BorderSize = 0;
            this.btn_vider.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_vider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vider.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vider.ForeColor = System.Drawing.Color.White;
            this.btn_vider.Location = new System.Drawing.Point(624, 551);
            this.btn_vider.Name = "btn_vider";
            this.btn_vider.Size = new System.Drawing.Size(134, 41);
            this.btn_vider.TabIndex = 9;
            this.btn_vider.Text = "Vider";
            this.btn_vider.UseVisualStyleBackColor = false;
            this.btn_vider.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_supprimer.FlatAppearance.BorderSize = 0;
            this.btn_supprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_supprimer.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(484, 551);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(134, 41);
            this.btn_supprimer.TabIndex = 8;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_premiere
            // 
            this.btn_premiere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_premiere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_premiere.BackgroundImage")));
            this.btn_premiere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_premiere.FlatAppearance.BorderSize = 0;
            this.btn_premiere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_premiere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_premiere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_premiere.ForeColor = System.Drawing.Color.White;
            this.btn_premiere.Location = new System.Drawing.Point(12, 551);
            this.btn_premiere.Name = "btn_premiere";
            this.btn_premiere.Size = new System.Drawing.Size(46, 41);
            this.btn_premiere.TabIndex = 4;
            this.btn_premiere.UseVisualStyleBackColor = false;
            this.btn_premiere.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // btn_derniere
            // 
            this.btn_derniere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_derniere.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_derniere.BackgroundImage")));
            this.btn_derniere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_derniere.FlatAppearance.BorderSize = 0;
            this.btn_derniere.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_derniere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_derniere.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_derniere.ForeColor = System.Drawing.Color.White;
            this.btn_derniere.Location = new System.Drawing.Point(201, 551);
            this.btn_derniere.Name = "btn_derniere";
            this.btn_derniere.Size = new System.Drawing.Size(46, 41);
            this.btn_derniere.TabIndex = 7;
            this.btn_derniere.UseVisualStyleBackColor = false;
            this.btn_derniere.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_precedent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_precedent.BackgroundImage")));
            this.btn_precedent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_precedent.FlatAppearance.BorderSize = 0;
            this.btn_precedent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_precedent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precedent.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_precedent.ForeColor = System.Drawing.Color.White;
            this.btn_precedent.Location = new System.Drawing.Point(64, 551);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(46, 41);
            this.btn_precedent.TabIndex = 5;
            this.btn_precedent.UseVisualStyleBackColor = false;
            this.btn_precedent.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_suivant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_suivant.BackgroundImage")));
            this.btn_suivant.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_suivant.FlatAppearance.BorderSize = 0;
            this.btn_suivant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_suivant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suivant.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suivant.ForeColor = System.Drawing.Color.White;
            this.btn_suivant.Location = new System.Drawing.Point(149, 551);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(46, 41);
            this.btn_suivant.TabIndex = 6;
            this.btn_suivant.UseVisualStyleBackColor = false;
            this.btn_suivant.Click += new System.EventHandler(this.btn_premiere_Click);
            // 
            // grp_chercher
            // 
            this.grp_chercher.Controls.Add(this.rd_date);
            this.grp_chercher.Controls.Add(this.rd_type);
            this.grp_chercher.Controls.Add(this.rd_nomPrenom);
            this.grp_chercher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_chercher.Location = new System.Drawing.Point(13, 25);
            this.grp_chercher.Name = "grp_chercher";
            this.grp_chercher.Size = new System.Drawing.Size(746, 89);
            this.grp_chercher.TabIndex = 0;
            this.grp_chercher.TabStop = false;
            this.grp_chercher.Text = "Recherche Par :";
            this.grp_chercher.Enter += new System.EventHandler(this.grp_chercher_Enter);
            // 
            // rd_date
            // 
            this.rd_date.AutoSize = true;
            this.rd_date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_date.Location = new System.Drawing.Point(507, 40);
            this.rd_date.Name = "rd_date";
            this.rd_date.Size = new System.Drawing.Size(163, 22);
            this.rd_date.TabIndex = 2;
            this.rd_date.Text = "Date De Connexion";
            this.rd_date.UseVisualStyleBackColor = true;
            this.rd_date.CheckedChanged += new System.EventHandler(this.rd_nomPrenom_CheckedChanged);
            // 
            // rd_type
            // 
            this.rd_type.AutoSize = true;
            this.rd_type.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_type.Location = new System.Drawing.Point(313, 40);
            this.rd_type.Name = "rd_type";
            this.rd_type.Size = new System.Drawing.Size(147, 22);
            this.rd_type.TabIndex = 1;
            this.rd_type.Text = "Type D\'Utilisateur";
            this.rd_type.UseVisualStyleBackColor = true;
            this.rd_type.CheckedChanged += new System.EventHandler(this.rd_nomPrenom_CheckedChanged);
            // 
            // rd_nomPrenom
            // 
            this.rd_nomPrenom.AutoSize = true;
            this.rd_nomPrenom.Checked = true;
            this.rd_nomPrenom.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_nomPrenom.Location = new System.Drawing.Point(114, 40);
            this.rd_nomPrenom.Name = "rd_nomPrenom";
            this.rd_nomPrenom.Size = new System.Drawing.Size(133, 22);
            this.rd_nomPrenom.TabIndex = 0;
            this.rd_nomPrenom.TabStop = true;
            this.rd_nomPrenom.Text = "Nom && Prenom";
            this.rd_nomPrenom.UseVisualStyleBackColor = true;
            this.rd_nomPrenom.CheckedChanged += new System.EventHandler(this.rd_nomPrenom_CheckedChanged);
            // 
            // pnl_nomPrenom
            // 
            this.pnl_nomPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nomPrenom.Controls.Add(this.pnl_date);
            this.pnl_nomPrenom.Controls.Add(this.btn_chercherNom);
            this.pnl_nomPrenom.Controls.Add(this.txt_chercher);
            this.pnl_nomPrenom.Location = new System.Drawing.Point(13, 134);
            this.pnl_nomPrenom.Name = "pnl_nomPrenom";
            this.pnl_nomPrenom.Size = new System.Drawing.Size(745, 80);
            this.pnl_nomPrenom.TabIndex = 8;
            // 
            // pnl_date
            // 
            this.pnl_date.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_date.Controls.Add(this.label2);
            this.pnl_date.Controls.Add(this.label1);
            this.pnl_date.Controls.Add(this.dt_de);
            this.pnl_date.Controls.Add(this.dt_a);
            this.pnl_date.Controls.Add(this.btn_chercherDate);
            this.pnl_date.Location = new System.Drawing.Point(0, 0);
            this.pnl_date.Name = "pnl_date";
            this.pnl_date.Size = new System.Drawing.Size(745, 80);
            this.pnl_date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "A :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "De :";
            // 
            // dt_de
            // 
            this.dt_de.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dt_de.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_de.Location = new System.Drawing.Point(75, 25);
            this.dt_de.Name = "dt_de";
            this.dt_de.Size = new System.Drawing.Size(159, 29);
            this.dt_de.TabIndex = 14;
            // 
            // dt_a
            // 
            this.dt_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dt_a.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_a.Location = new System.Drawing.Point(339, 25);
            this.dt_a.Name = "dt_a";
            this.dt_a.Size = new System.Drawing.Size(159, 29);
            this.dt_a.TabIndex = 13;
            // 
            // btn_chercherDate
            // 
            this.btn_chercherDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercherDate.FlatAppearance.BorderSize = 0;
            this.btn_chercherDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercherDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercherDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercherDate.ForeColor = System.Drawing.Color.White;
            this.btn_chercherDate.Location = new System.Drawing.Point(563, 22);
            this.btn_chercherDate.Name = "btn_chercherDate";
            this.btn_chercherDate.Size = new System.Drawing.Size(115, 32);
            this.btn_chercherDate.TabIndex = 18;
            this.btn_chercherDate.Text = "Rechercher";
            this.btn_chercherDate.UseVisualStyleBackColor = false;
            this.btn_chercherDate.Click += new System.EventHandler(this.btn_chercherDate_Click);
            // 
            // btn_chercherNom
            // 
            this.btn_chercherNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercherNom.FlatAppearance.BorderSize = 0;
            this.btn_chercherNom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercherNom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercherNom.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercherNom.ForeColor = System.Drawing.Color.White;
            this.btn_chercherNom.Location = new System.Drawing.Point(563, 24);
            this.btn_chercherNom.Name = "btn_chercherNom";
            this.btn_chercherNom.Size = new System.Drawing.Size(115, 32);
            this.btn_chercherNom.TabIndex = 2;
            this.btn_chercherNom.Text = "Rechercher";
            this.btn_chercherNom.UseVisualStyleBackColor = false;
            this.btn_chercherNom.Click += new System.EventHandler(this.btn_chercherDate_Click);
            // 
            // txt_chercher
            // 
            this.txt_chercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chercher.ForeColor = System.Drawing.Color.Gray;
            this.txt_chercher.Location = new System.Drawing.Point(22, 25);
            this.txt_chercher.Name = "txt_chercher";
            this.txt_chercher.Size = new System.Drawing.Size(524, 29);
            this.txt_chercher.TabIndex = 1;
            this.txt_chercher.Text = "Tapez Le Nom & Prenom Pour Rechercher";
            this.txt_chercher.Enter += new System.EventHandler(this.txt_chercher_Enter);
            this.txt_chercher.Leave += new System.EventHandler(this.txt_chercher_Leave);
            // 
            // pnl_type
            // 
            this.pnl_type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_type.Controls.Add(this.cb_type);
            this.pnl_type.Controls.Add(this.btn_chercherType);
            this.pnl_type.Location = new System.Drawing.Point(14, 134);
            this.pnl_type.Name = "pnl_type";
            this.pnl_type.Size = new System.Drawing.Size(745, 80);
            this.pnl_type.TabIndex = 10;
            // 
            // cb_type
            // 
            this.cb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(22, 22);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(524, 32);
            this.cb_type.TabIndex = 12;
            // 
            // btn_chercherType
            // 
            this.btn_chercherType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(109)))), ((int)(((byte)(244)))));
            this.btn_chercherType.FlatAppearance.BorderSize = 0;
            this.btn_chercherType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_chercherType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_chercherType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chercherType.ForeColor = System.Drawing.Color.White;
            this.btn_chercherType.Location = new System.Drawing.Point(563, 22);
            this.btn_chercherType.Name = "btn_chercherType";
            this.btn_chercherType.Size = new System.Drawing.Size(115, 32);
            this.btn_chercherType.TabIndex = 11;
            this.btn_chercherType.Text = "Rechercher";
            this.btn_chercherType.UseVisualStyleBackColor = false;
            this.btn_chercherType.Click += new System.EventHandler(this.btn_chercherDate_Click);
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 634);
            this.Controls.Add(this.pnl_type);
            this.Controls.Add(this.pnl_nomPrenom);
            this.Controls.Add(this.grp_chercher);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_derniere);
            this.Controls.Add(this.btn_premiere);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_vider);
            this.Controls.Add(this.dt_grid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConnexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmConnexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid)).EndInit();
            this.grp_chercher.ResumeLayout(false);
            this.grp_chercher.PerformLayout();
            this.pnl_nomPrenom.ResumeLayout(false);
            this.pnl_nomPrenom.PerformLayout();
            this.pnl_date.ResumeLayout(false);
            this.pnl_date.PerformLayout();
            this.pnl_type.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dt_grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.Button btn_vider;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_premiere;
        private System.Windows.Forms.Button btn_derniere;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.GroupBox grp_chercher;
        private System.Windows.Forms.RadioButton rd_date;
        private System.Windows.Forms.RadioButton rd_type;
        private System.Windows.Forms.RadioButton rd_nomPrenom;
        private System.Windows.Forms.Panel pnl_nomPrenom;
        private System.Windows.Forms.Button btn_chercherNom;
        private System.Windows.Forms.TextBox txt_chercher;
        private System.Windows.Forms.Panel pnl_type;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_chercherType;
        private System.Windows.Forms.Panel pnl_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dt_de;
        private System.Windows.Forms.DateTimePicker dt_a;
        private System.Windows.Forms.Button btn_chercherDate;
    }
}