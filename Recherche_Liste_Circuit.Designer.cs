namespace TP_Final
{
    partial class Recherche_Liste_Circuit
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
            this.CB_Debut = new System.Windows.Forms.ComboBox();
            this.TB_Prix = new System.Windows.Forms.TextBox();
            this.CB_Monument = new System.Windows.Forms.ComboBox();
            this.DGV_Circuit = new System.Windows.Forms.DataGridView();
            this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Recherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_Debut
            // 
            this.CB_Debut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Debut.FormattingEnabled = true;
            this.CB_Debut.Location = new System.Drawing.Point(147, 180);
            this.CB_Debut.Name = "CB_Debut";
            this.CB_Debut.Size = new System.Drawing.Size(121, 21);
            this.CB_Debut.TabIndex = 0;
            this.CB_Debut.SelectedIndexChanged += new System.EventHandler(this.CB_Debut_SelectedIndexChanged);
            // 
            // TB_Prix
            // 
            this.TB_Prix.Location = new System.Drawing.Point(12, 181);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(121, 20);
            this.TB_Prix.TabIndex = 1;
            this.TB_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Prix_KeyPress);
            // 
            // CB_Monument
            // 
            this.CB_Monument.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Monument.FormattingEnabled = true;
            this.CB_Monument.Location = new System.Drawing.Point(147, 217);
            this.CB_Monument.Name = "CB_Monument";
            this.CB_Monument.Size = new System.Drawing.Size(121, 21);
            this.CB_Monument.TabIndex = 2;
            this.CB_Monument.SelectedIndexChanged += new System.EventHandler(this.CB_Monument_SelectedIndexChanged);
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
            this.Debut,
            this.Fin,
            this.Prix});
            this.DGV_Circuit.Location = new System.Drawing.Point(12, 12);
            this.DGV_Circuit.Name = "DGV_Circuit";
            this.DGV_Circuit.ReadOnly = true;
            this.DGV_Circuit.Size = new System.Drawing.Size(386, 150);
            this.DGV_Circuit.TabIndex = 3;
            // 
            // nom
            // 
            this.nom.HeaderText = "Nom";
            this.nom.Name = "nom";
            this.nom.ReadOnly = true;
            // 
            // Debut
            // 
            this.Debut.HeaderText = "Debut";
            this.Debut.Name = "Debut";
            this.Debut.ReadOnly = true;
            // 
            // Fin
            // 
            this.Fin.HeaderText = "Fin";
            this.Fin.Name = "Fin";
            this.Fin.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // BT_Recherche
            // 
            this.BT_Recherche.Location = new System.Drawing.Point(12, 215);
            this.BT_Recherche.Name = "BT_Recherche";
            this.BT_Recherche.Size = new System.Drawing.Size(120, 23);
            this.BT_Recherche.TabIndex = 4;
            this.BT_Recherche.Text = "Rechercher";
            this.BT_Recherche.UseVisualStyleBackColor = true;
            this.BT_Recherche.Click += new System.EventHandler(this.BT_Recherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Monument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prix Maximum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville de Depart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recherche_Liste_Circuit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(404, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_Recherche);
            this.Controls.Add(this.DGV_Circuit);
            this.Controls.Add(this.CB_Monument);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.CB_Debut);
            this.MaximumSize = new System.Drawing.Size(420, 287);
            this.MinimumSize = new System.Drawing.Size(420, 287);
            this.Name = "Recherche_Liste_Circuit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recherche Liste Circuit";
            this.Load += new System.EventHandler(this.Recherche_Liste_Circuit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Circuit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_Debut;
        private System.Windows.Forms.TextBox TB_Prix;
        private System.Windows.Forms.ComboBox CB_Monument;
        private System.Windows.Forms.DataGridView DGV_Circuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.Button BT_Recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}