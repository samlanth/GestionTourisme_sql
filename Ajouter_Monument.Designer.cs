namespace TP_Final
{
    partial class Ajouter_Monument
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
            this.BT_Ajouter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Etoiles = new System.Windows.Forms.TextBox();
            this.TB_Nom = new System.Windows.Forms.TextBox();
            this.TB_Prix = new System.Windows.Forms.TextBox();
            this.DTP_Date = new System.Windows.Forms.DateTimePicker();
            this.LBX_ImagesGUIDs = new System.Windows.Forms.ListBox();
            this.PBX_SelectedGUID = new System.Windows.Forms.PictureBox();
            this.TB_Histoire = new System.Windows.Forms.RichTextBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.LB_Image = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedGUID)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Ajouter
            // 
            this.BT_Ajouter.Location = new System.Drawing.Point(13, 294);
            this.BT_Ajouter.Name = "BT_Ajouter";
            this.BT_Ajouter.Size = new System.Drawing.Size(135, 23);
            this.BT_Ajouter.TabIndex = 50;
            this.BT_Ajouter.Text = "Ajouter";
            this.BT_Ajouter.UseVisualStyleBackColor = true;
            this.BT_Ajouter.Click += new System.EventHandler(this.BT_Ajouter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Etoiles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Histoire";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nom";
            // 
            // TB_Etoiles
            // 
            this.TB_Etoiles.Location = new System.Drawing.Point(12, 229);
            this.TB_Etoiles.Name = "TB_Etoiles";
            this.TB_Etoiles.Size = new System.Drawing.Size(136, 20);
            this.TB_Etoiles.TabIndex = 41;
            // 
            // TB_Nom
            // 
            this.TB_Nom.Location = new System.Drawing.Point(12, 33);
            this.TB_Nom.Name = "TB_Nom";
            this.TB_Nom.Size = new System.Drawing.Size(136, 20);
            this.TB_Nom.TabIndex = 38;
            // 
            // TB_Prix
            // 
            this.TB_Prix.Location = new System.Drawing.Point(12, 268);
            this.TB_Prix.Name = "TB_Prix";
            this.TB_Prix.Size = new System.Drawing.Size(136, 20);
            this.TB_Prix.TabIndex = 52;
            // 
            // DTP_Date
            // 
            this.DTP_Date.Location = new System.Drawing.Point(13, 72);
            this.DTP_Date.Name = "DTP_Date";
            this.DTP_Date.Size = new System.Drawing.Size(135, 20);
            this.DTP_Date.TabIndex = 56;
            // 
            // LBX_ImagesGUIDs
            // 
            this.LBX_ImagesGUIDs.FormattingEnabled = true;
            this.LBX_ImagesGUIDs.Location = new System.Drawing.Point(167, 17);
            this.LBX_ImagesGUIDs.Name = "LBX_ImagesGUIDs";
            this.LBX_ImagesGUIDs.Size = new System.Drawing.Size(168, 134);
            this.LBX_ImagesGUIDs.TabIndex = 57;
            this.LBX_ImagesGUIDs.SelectedIndexChanged += new System.EventHandler(this.LBX_ImagesGUIDs_SelectedIndexChanged);
            // 
            // PBX_SelectedGUID
            // 
            this.PBX_SelectedGUID.Location = new System.Drawing.Point(167, 170);
            this.PBX_SelectedGUID.Name = "PBX_SelectedGUID";
            this.PBX_SelectedGUID.Size = new System.Drawing.Size(168, 118);
            this.PBX_SelectedGUID.TabIndex = 58;
            this.PBX_SelectedGUID.TabStop = false;
            // 
            // TB_Histoire
            // 
            this.TB_Histoire.Location = new System.Drawing.Point(13, 111);
            this.TB_Histoire.Name = "TB_Histoire";
            this.TB_Histoire.Size = new System.Drawing.Size(135, 90);
            this.TB_Histoire.TabIndex = 60;
            this.TB_Histoire.Text = "";
            // 
            // BT_Close
            // 
            this.BT_Close.Location = new System.Drawing.Point(200, 294);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(135, 23);
            this.BT_Close.TabIndex = 61;
            this.BT_Close.Text = "Close";
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // LB_Image
            // 
            this.LB_Image.AutoSize = true;
            this.LB_Image.Location = new System.Drawing.Point(164, 154);
            this.LB_Image.Name = "LB_Image";
            this.LB_Image.Size = new System.Drawing.Size(41, 13);
            this.LB_Image.TabIndex = 62;
            this.LB_Image.Text = "Images";
            // 
            // Ajouter_Monument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(350, 329);
            this.Controls.Add(this.LB_Image);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.TB_Histoire);
            this.Controls.Add(this.PBX_SelectedGUID);
            this.Controls.Add(this.LBX_ImagesGUIDs);
            this.Controls.Add(this.DTP_Date);
            this.Controls.Add(this.TB_Prix);
            this.Controls.Add(this.BT_Ajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Etoiles);
            this.Controls.Add(this.TB_Nom);
            this.MaximumSize = new System.Drawing.Size(366, 368);
            this.MinimumSize = new System.Drawing.Size(366, 368);
            this.Name = "Ajouter_Monument";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajouter Monument";
            this.Load += new System.EventHandler(this.Ajouter_Monument_Load);
            this.Shown += new System.EventHandler(this.Ajouter_Monument_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_SelectedGUID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Ajouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Etoiles;
        private System.Windows.Forms.TextBox TB_Nom;
        private System.Windows.Forms.TextBox TB_Prix;
        private System.Windows.Forms.DateTimePicker DTP_Date;
        private System.Windows.Forms.ListBox LBX_ImagesGUIDs;
        private System.Windows.Forms.PictureBox PBX_SelectedGUID;
        private System.Windows.Forms.RichTextBox TB_Histoire;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label LB_Image;
    }
}