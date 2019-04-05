namespace TP_Final
{
    partial class Delete_Monument
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
            this.CB_circuit = new System.Windows.Forms.ComboBox();
            this.DGV_monument = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.histoire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Supprimer = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            this.LB_Image = new System.Windows.Forms.Label();
            this.PBX_SelectedGUID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedGUID)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_circuit
            // 
            this.CB_circuit.BackColor = System.Drawing.SystemColors.Control;
            this.CB_circuit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_circuit.FormattingEnabled = true;
            this.CB_circuit.Location = new System.Drawing.Point(12, 12);
            this.CB_circuit.Name = "CB_circuit";
            this.CB_circuit.Size = new System.Drawing.Size(121, 21);
            this.CB_circuit.TabIndex = 0;
            this.CB_circuit.SelectedIndexChanged += new System.EventHandler(this.CB_circuit_SelectedIndexChanged);
            // 
            // DGV_monument
            // 
            this.DGV_monument.AllowUserToAddRows = false;
            this.DGV_monument.AllowUserToDeleteRows = false;
            this.DGV_monument.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_monument.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_monument.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_monument.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.date,
            this.histoire,
            this.etoiles,
            this.prix,
            this.ordre,
            this.num});
            this.DGV_monument.Location = new System.Drawing.Point(12, 57);
            this.DGV_monument.Name = "DGV_monument";
            this.DGV_monument.ReadOnly = true;
            this.DGV_monument.Size = new System.Drawing.Size(448, 150);
            this.DGV_monument.TabIndex = 1;
            this.DGV_monument.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_monument_CellClick);
            this.DGV_monument.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_monument_CellContentClick);
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // histoire
            // 
            this.histoire.HeaderText = "histoire";
            this.histoire.Name = "histoire";
            this.histoire.ReadOnly = true;
            // 
            // etoiles
            // 
            this.etoiles.HeaderText = "etoiles";
            this.etoiles.Name = "etoiles";
            this.etoiles.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // ordre
            // 
            this.ordre.HeaderText = "ordre";
            this.ordre.Name = "ordre";
            this.ordre.ReadOnly = true;
            // 
            // num
            // 
            this.num.HeaderText = "num";
            this.num.Name = "num";
            this.num.ReadOnly = true;
            // 
            // BT_Supprimer
            // 
            this.BT_Supprimer.Location = new System.Drawing.Point(77, 226);
            this.BT_Supprimer.Name = "BT_Supprimer";
            this.BT_Supprimer.Size = new System.Drawing.Size(121, 23);
            this.BT_Supprimer.TabIndex = 2;
            this.BT_Supprimer.Text = "Supprimer Monument";
            this.BT_Supprimer.UseVisualStyleBackColor = true;
            this.BT_Supprimer.Click += new System.EventHandler(this.BT_Supprimer_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(262, 226);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 23);
            this.BT_Close.TabIndex = 3;
            this.BT_Close.Text = "Close";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // LB_Image
            // 
            this.LB_Image.AutoSize = true;
            this.LB_Image.Location = new System.Drawing.Point(473, 57);
            this.LB_Image.Name = "LB_Image";
            this.LB_Image.Size = new System.Drawing.Size(41, 13);
            this.LB_Image.TabIndex = 64;
            this.LB_Image.Text = "Images";
            // 
            // PBX_SelectedGUID
            // 
            this.PBX_SelectedGUID.Location = new System.Drawing.Point(476, 73);
            this.PBX_SelectedGUID.Name = "PBX_SelectedGUID";
            this.PBX_SelectedGUID.Size = new System.Drawing.Size(168, 134);
            this.PBX_SelectedGUID.TabIndex = 63;
            this.PBX_SelectedGUID.TabStop = false;
            this.PBX_SelectedGUID.Click += new System.EventHandler(this.PBX_SelectedGUID_Click);
            // 
            // Delete_Monument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.LB_Image);
            this.Controls.Add(this.PBX_SelectedGUID);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_Supprimer);
            this.Controls.Add(this.DGV_monument);
            this.Controls.Add(this.CB_circuit);
            this.MaximumSize = new System.Drawing.Size(672, 300);
            this.MinimumSize = new System.Drawing.Size(672, 300);
            this.Name = "Delete_Monument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete Monument";
            this.Load += new System.EventHandler(this.Delete_Monument_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedGUID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_circuit;
        private System.Windows.Forms.DataGridView DGV_monument;
        private System.Windows.Forms.Button BT_Supprimer;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn histoire;
        private System.Windows.Forms.DataGridViewTextBoxColumn etoiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordre;
        private System.Windows.Forms.DataGridViewTextBoxColumn num;
        private System.Windows.Forms.Label LB_Image;
        private System.Windows.Forms.PictureBox PBX_SelectedGUID;
    }
}