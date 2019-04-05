namespace TP_Final
{
    partial class RechercheCircuit
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
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monument3Etoiles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Circuit
            // 
            this.DGV_Circuit.AllowUserToAddRows = false;
            this.DGV_Circuit.AllowUserToDeleteRows = false;
            this.DGV_Circuit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV_Circuit.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DGV_Circuit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Circuit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nom,
            this.prix,
            this.Monument3Etoiles});
            this.DGV_Circuit.Location = new System.Drawing.Point(12, 12);
            this.DGV_Circuit.Name = "DGV_Circuit";
            this.DGV_Circuit.ReadOnly = true;
            this.DGV_Circuit.Size = new System.Drawing.Size(339, 150);
            this.DGV_Circuit.TabIndex = 0;
            // 
            // nom
            // 
            this.nom.HeaderText = "nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // prix
            // 
            this.prix.HeaderText = "prix";
            this.prix.Name = "prix";
            this.prix.ReadOnly = true;
            // 
            // Monument3Etoiles
            // 
            this.Monument3Etoiles.HeaderText = "Monument3Etoiles";
            this.Monument3Etoiles.Name = "Monument3Etoiles";
            this.Monument3Etoiles.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RechercheCircuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(363, 202);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGV_Circuit);
            this.MaximumSize = new System.Drawing.Size(379, 241);
            this.MinimumSize = new System.Drawing.Size(379, 241);
            this.Name = "RechercheCircuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RechercheCircuit";
            this.Load += new System.EventHandler(this.RechercheCircuit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monument3Etoiles;
        private System.Windows.Forms.Button button1;
    }
}