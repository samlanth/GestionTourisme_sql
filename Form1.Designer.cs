namespace TP_Final
{
    partial class Form1
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
            this.BT_Ajouter_Circuit = new System.Windows.Forms.Button();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prix = new System.Windows.Forms.TextBox();
            this.TB_Duree = new System.Windows.Forms.TextBox();
            this.TB_maxPersonne = new System.Windows.Forms.TextBox();
            this.LB_Circuit = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.BT_Modify = new System.Windows.Forms.Button();
            this.TB_Debut = new System.Windows.Forms.TextBox();
            this.TB_Fin = new System.Windows.Forms.TextBox();
            this.BT_monument = new System.Windows.Forms.Button();
            this.BT_recherche = new System.Windows.Forms.Button();
            this.BT_RechercheCircuit = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BT_Rechercher_Liste_Circuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_Ajouter_Circuit
            // 
            this.BT_Ajouter_Circuit.Location = new System.Drawing.Point(139, 89);
            this.BT_Ajouter_Circuit.Name = "BT_Ajouter_Circuit";
            this.BT_Ajouter_Circuit.Size = new System.Drawing.Size(120, 20);
            this.BT_Ajouter_Circuit.TabIndex = 0;
            this.BT_Ajouter_Circuit.Text = "Ajouter Circuit";
            this.BT_Ajouter_Circuit.UseVisualStyleBackColor = true;
            this.BT_Ajouter_Circuit.Click += new System.EventHandler(this.BT_Ajouter_Circuit_Click);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(12, 90);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.ReadOnly = true;
            this.TB_Nom.Size = new System.Drawing.Size(112, 20);
            this.TB_Nom.TabIndex = 1;
            // 
            // TB_Prix
            // 
            this.TB_Prix.Location = new System.Drawing.Point(12, 168);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(112, 20);
            this.TB_Prix.TabIndex = 2;
            this.TB_Prix.TextChanged += new System.EventHandler(this.TB_Prix_TextChanged);
            this.TB_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Prix_KeyPress);
            // 
            // TB_Duree
            // 
            this.TB_Duree.Location = new System.Drawing.Point(12, 129);
            this.TB_Duree.Name = "TB_Duree";
            this.TB_Duree.ReadOnly = true;
            this.TB_Duree.Size = new System.Drawing.Size(112, 20);
            this.TB_Duree.TabIndex = 3;
            // 
            // TB_maxPersonne
            // 
            this.TB_maxPersonne.Location = new System.Drawing.Point(12, 211);
            this.TB_maxPersonne.Name = "TB_maxPersonne";
            this.TB_maxPersonne.ReadOnly = true;
            this.TB_maxPersonne.Size = new System.Drawing.Size(112, 20);
            this.TB_maxPersonne.TabIndex = 4;
            // 
            // LB_Circuit
            // 
            this.LB_Circuit.FormattingEnabled = true;
            this.LB_Circuit.Location = new System.Drawing.Point(12, 2);
            this.LB_Circuit.Name = "LB_Circuit";
            this.LB_Circuit.Size = new System.Drawing.Size(247, 69);
            this.LB_Circuit.TabIndex = 10;
            this.LB_Circuit.SelectedIndexChanged += new System.EventHandler(this.LB_Circuit_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Durée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Max Personne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ville Départ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Ville Fin";
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(136, 317);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(123, 26);
            this.BT_Cancel.TabIndex = 18;
            this.BT_Cancel.Text = "Close";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(139, 129);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(120, 20);
            this.BT_Delete.TabIndex = 19;
            this.BT_Delete.Text = "Supprimer Monument";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // BT_Modify
            // 
            this.BT_Modify.Location = new System.Drawing.Point(12, 317);
            this.BT_Modify.Name = "BT_Modify";
            this.BT_Modify.Size = new System.Drawing.Size(112, 26);
            this.BT_Modify.TabIndex = 22;
            this.BT_Modify.Text = "Modifier";
            this.BT_Modify.UseVisualStyleBackColor = true;
            this.BT_Modify.Click += new System.EventHandler(this.BT_Modify_Click);
            // 
            // TB_Debut
            // 
            this.TB_Debut.Location = new System.Drawing.Point(12, 252);
            this.TB_Debut.Name = "TB_Debut";
            this.TB_Debut.ReadOnly = true;
            this.TB_Debut.Size = new System.Drawing.Size(112, 20);
            this.TB_Debut.TabIndex = 23;
            // 
            // TB_Fin
            // 
            this.TB_Fin.Location = new System.Drawing.Point(12, 291);
            this.TB_Fin.Name = "TB_Fin";
            this.TB_Fin.ReadOnly = true;
            this.TB_Fin.Size = new System.Drawing.Size(112, 20);
            this.TB_Fin.TabIndex = 24;
            // 
            // BT_monument
            // 
            this.BT_monument.Location = new System.Drawing.Point(136, 168);
            this.BT_monument.Name = "BT_monument";
            this.BT_monument.Size = new System.Drawing.Size(123, 20);
            this.BT_monument.TabIndex = 25;
            this.BT_monument.Text = "Ajouter Monument";
            this.BT_monument.UseVisualStyleBackColor = true;
            this.BT_monument.Click += new System.EventHandler(this.BT_monument_Click);
            // 
            // BT_recherche
            // 
            this.BT_recherche.Location = new System.Drawing.Point(136, 211);
            this.BT_recherche.Name = "BT_recherche";
            this.BT_recherche.Size = new System.Drawing.Size(123, 20);
            this.BT_recherche.TabIndex = 26;
            this.BT_recherche.Text = "Recherche";
            this.BT_recherche.UseVisualStyleBackColor = true;
            this.BT_recherche.Click += new System.EventHandler(this.BT_recherche_Click);
            // 
            // BT_RechercheCircuit
            // 
            this.BT_RechercheCircuit.Location = new System.Drawing.Point(136, 252);
            this.BT_RechercheCircuit.Name = "BT_RechercheCircuit";
            this.BT_RechercheCircuit.Size = new System.Drawing.Size(123, 20);
            this.BT_RechercheCircuit.TabIndex = 27;
            this.BT_RechercheCircuit.Text = "Recherche Circuit";
            this.BT_RechercheCircuit.UseVisualStyleBackColor = true;
            this.BT_RechercheCircuit.Click += new System.EventHandler(this.BT_RechercheCircuit_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(104, 195);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 28;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "A Propos";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BT_Rechercher_Liste_Circuit
            // 
            this.BT_Rechercher_Liste_Circuit.Location = new System.Drawing.Point(136, 291);
            this.BT_Rechercher_Liste_Circuit.Name = "BT_Rechercher_Liste_Circuit";
            this.BT_Rechercher_Liste_Circuit.Size = new System.Drawing.Size(123, 20);
            this.BT_Rechercher_Liste_Circuit.TabIndex = 29;
            this.BT_Rechercher_Liste_Circuit.Text = "Rechercher Liste";
            this.BT_Rechercher_Liste_Circuit.UseVisualStyleBackColor = true;
            this.BT_Rechercher_Liste_Circuit.Click += new System.EventHandler(this.BT_Rechercher_Liste_Circuit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(263, 344);
            this.Controls.Add(this.BT_Rechercher_Liste_Circuit);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BT_RechercheCircuit);
            this.Controls.Add(this.BT_recherche);
            this.Controls.Add(this.BT_monument);
            this.Controls.Add(this.TB_Fin);
            this.Controls.Add(this.TB_Debut);
            this.Controls.Add(this.BT_Modify);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_Circuit);
            this.Controls.Add(this.TB_maxPersonne);
            this.Controls.Add(this.TB_Duree);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.TB_Nom);
            this.Controls.Add(this.BT_Ajouter_Circuit);
            this.MaximumSize = new System.Drawing.Size(279, 383);
            this.MinimumSize = new System.Drawing.Size(279, 383);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier le Prix";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Ajouter_Circuit;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prix;
        private System.Windows.Forms.TextBox TB_Duree;
        private System.Windows.Forms.TextBox TB_maxPersonne;
        private System.Windows.Forms.ListBox LB_Circuit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Modify;
        private System.Windows.Forms.TextBox TB_Debut;
        private System.Windows.Forms.TextBox TB_Fin;
        private System.Windows.Forms.Button BT_monument;
        private System.Windows.Forms.Button BT_recherche;
        private System.Windows.Forms.Button BT_RechercheCircuit;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BT_Rechercher_Liste_Circuit;
    }
}

