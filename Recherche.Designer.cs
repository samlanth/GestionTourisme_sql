namespace TP_Final
{
    partial class Recherche
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
            this.CB_etoile = new System.Windows.Forms.ComboBox();
            this.DGV_monument = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_circuit = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monument)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_circuit)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_etoile
            // 
            this.CB_etoile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_etoile.FormattingEnabled = true;
            this.CB_etoile.Location = new System.Drawing.Point(12, 12);
            this.CB_etoile.Name = "CB_etoile";
            this.CB_etoile.Size = new System.Drawing.Size(121, 21);
            this.CB_etoile.TabIndex = 0;
            this.CB_etoile.SelectedIndexChanged += new System.EventHandler(this.CB_etoile_SelectedIndexChanged);
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
            this.etoiles,
            this.prix});
            this.DGV_monument.Location = new System.Drawing.Point(12, 45);
            this.DGV_monument.Name = "DGV_monument";
            this.DGV_monument.ReadOnly = true;
            this.DGV_monument.Size = new System.Drawing.Size(365, 150);
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
            // DGV_circuit
            // 
            this.DGV_circuit.AllowUserToAddRows = false;
            this.DGV_circuit.AllowUserToDeleteRows = false;
            this.DGV_circuit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_circuit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.price,
            this.ordre});
            this.DGV_circuit.Location = new System.Drawing.Point(12, 201);
            this.DGV_circuit.Name = "DGV_circuit";
            this.DGV_circuit.ReadOnly = true;
            this.DGV_circuit.Size = new System.Drawing.Size(365, 134);
            this.DGV_circuit.TabIndex = 2;
            this.DGV_circuit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_circuit_CellContentClick);
            // 
            // name
            // 
            this.name.HeaderText = "name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // ordre
            // 
            this.ordre.HeaderText = "ordre";
            this.ordre.Name = "ordre";
            this.ordre.ReadOnly = true;
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(133, 341);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 21);
            this.BT_Close.TabIndex = 3;
            this.BT_Close.Text = "Close";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // Recherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(410, 372);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.DGV_circuit);
            this.Controls.Add(this.DGV_monument);
            this.Controls.Add(this.CB_etoile);
            this.MaximumSize = new System.Drawing.Size(426, 411);
            this.MinimumSize = new System.Drawing.Size(426, 411);
            this.Name = "Recherche";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche";
            this.Load += new System.EventHandler(this.Recherche_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_monument)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_circuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_etoile;
        private System.Windows.Forms.DataGridView DGV_monument;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn etoiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridView DGV_circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordre;
        private System.Windows.Forms.Button BT_Close;
    }
}