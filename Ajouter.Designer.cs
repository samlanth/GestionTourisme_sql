namespace TP_Final
{
    partial class Ajouter
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_maxPersonne = new System.Windows.Forms.TextBox();
            this.TB_Duree = new System.Windows.Forms.TextBox();
            this.TB_Prix = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.CB_Fin = new System.Windows.Forms.ComboBox();
            this.CB_Debut = new System.Windows.Forms.ComboBox();
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Fin";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Départ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Max";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Durée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Prix";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nom";
            // 
            // TB_maxPersonne
            // 
            this.TB_maxPersonne.Location = new System.Drawing.Point(65, 131);
            this.TB_maxPersonne.Name = "TB_maxPersonne";
            this.TB_maxPersonne.Size = new System.Drawing.Size(121, 20);
            this.TB_maxPersonne.TabIndex = 28;
            this.TB_maxPersonne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_maxPersonne_KeyPress);
            // 
            // TB_Duree
            // 
            this.TB_Duree.Location = new System.Drawing.Point(65, 52);
            this.TB_Duree.Name = "TB_Duree";
            this.TB_Duree.Size = new System.Drawing.Size(121, 20);
            this.TB_Duree.TabIndex = 27;
            // 
            // TB_Prix
            // 
            this.TB_Prix.Location = new System.Drawing.Point(65, 92);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(121, 20);
            this.TB_Prix.TabIndex = 26;
            this.TB_Prix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Prix_KeyPress);
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(65, 15);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(121, 20);
            this.TB_Nom.TabIndex = 25;
            this.TB_Nom.TextChanged += new System.EventHandler(this.TB_Nom_TextChanged);
            this.TB_Nom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_Nom_KeyPress);
            // 
            // CB_Fin
            // 
            this.CB_Fin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Fin.FormattingEnabled = true;
            this.CB_Fin.Location = new System.Drawing.Point(65, 205);
            this.CB_Fin.Name = "CB_Fin";
            this.CB_Fin.Size = new System.Drawing.Size(121, 21);
            this.CB_Fin.TabIndex = 35;
            // 
            // CB_Debut
            // 
            this.CB_Debut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Debut.FormattingEnabled = true;
            this.CB_Debut.Location = new System.Drawing.Point(65, 168);
            this.CB_Debut.Name = "CB_Debut";
            this.CB_Debut.Size = new System.Drawing.Size(121, 21);
            this.CB_Debut.TabIndex = 36;
            this.CB_Debut.SelectedIndexChanged += new System.EventHandler(this.CB_Debut_SelectedIndexChanged);
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BT_Ajouter.Location = new System.Drawing.Point(2, 252);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(100, 21);
            this.BT_Ajouter.TabIndex = 37;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            this.BT_Ajouter.Click += new System.EventHandler(this.BT_Ajouter_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Close.Location = new System.Drawing.Point(108, 252);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(100, 21);
            this.BT_Close.TabIndex = 38;
            this.BT_Close.Text = "Close";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // Ajouter
            // 
            this.AcceptButton = this.BT_Ajouter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(214, 285);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.CB_Debut);
            this.Controls.Add(this.CB_Fin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_maxPersonne);
            this.Controls.Add(this.TB_Duree);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.TB_Nom);
            this.MaximumSize = new System.Drawing.Size(230, 324);
            this.MinimumSize = new System.Drawing.Size(230, 324);
            this.Name = "Ajouter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter";
            this.Load += new System.EventHandler(this.Ajouter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_maxPersonne;
        private System.Windows.Forms.TextBox TB_Duree;
        private System.Windows.Forms.TextBox TB_Prix;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.ComboBox CB_Fin;
        private System.Windows.Forms.ComboBox CB_Debut;
        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Button BT_Close;
    }
}