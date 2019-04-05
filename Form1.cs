using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Globalization;
using Validation;

namespace TP_Final
{
    public partial class Form1 : Form
    {
        private ValidationProvider ValidationProvider;
        OracleConnection connection = new OracleConnection();
        public Form1()
        {
            InitializeComponent();
        }
        private bool Validate_TBX_prix(ref string message)
        {
            int prix = 500;
            if(TB_Prix.Text != "")
            {
                prix = Int32.Parse(TB_Prix.Text);
            }
            BT_Modify.Enabled = false;
            if(prix < 50)
            {
                message = "Prix en bas de 50";
                return prix > 50;
            }
            else {
                message = "prix manquant";
            }
            message = "prix manquant";
            if (TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "" && TB_Debut.Text != "" && TB_Fin.Text != "")
            {
                BT_Modify.Enabled = true;
            }
            return TB_Prix.Text != "";
        }

        private void SeConnecter()
        {
            try
            {
                string dsource = "(DESCRIPTION="
                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string chaineDeconnexion = "Data Source = " + dsource + "; User Id = lanthies; password = ORACLE1";
                connection.ConnectionString = chaineDeconnexion;
                connection.Open();
            }
            catch (Exception sqlConnex)
            {
                MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidationProvider = new ValidationProvider(this);
            SeConnecter();
            Afficher();
            ValidationProvider.AddControlToValidate(TB_Prix, Validate_TBX_prix);

        }

        private void BT_Ajouter_Circuit_Click(object sender, EventArgs e)
        {
            Ajouter dlg = new Ajouter();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Afficher();
                LB_Circuit.Refresh();
            }
        }

        private void Afficher()
        {
            try
            {
                if (LB_Circuit.Items.Count != 0)
                {
                    LB_Circuit.Items.Clear();
                    LB_Circuit.Refresh();
                }
                    string sql5 = "select nom from circuit";
                    OracleCommand oraComm5 = new OracleCommand(sql5, connection);
                    OracleDataReader oraReader5 = oraComm5.ExecuteReader();
                    while (oraReader5.Read())
                    {
                        LB_Circuit.Items.Add(oraReader5.GetString(0));
                        LB_Circuit.Refresh();
                }
                

            }
            catch (Exception sqlConnex)
            {
                MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vider()
        {
            TB_Duree.Text = "";
            TB_maxPersonne.Text = "";
            TB_Nom.Text = "";
            TB_Prix.Text = "";
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            Delete_Monument dlg = new Delete_Monument();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void LB_Circuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql3 = "select prix from Circuit where nom = '" + LB_Circuit.SelectedItem + "'";
                OracleCommand oraComm5 = new OracleCommand(sql3, connection);
                oraComm5.ExecuteNonQuery();
                OracleDataReader reader3 = oraComm5.ExecuteReader();
                reader3.Read();
                int prix = reader3.GetInt32(0);
                reader3.Close();
                TB_Prix.Text = prix.ToString();

                string sql4 = "select Duree from Circuit where nom = '" + LB_Circuit.SelectedItem + "'";
                OracleCommand oraComm6 = new OracleCommand(sql4, connection);
                oraComm6.ExecuteNonQuery();
                OracleDataReader reader4 = oraComm6.ExecuteReader();
                reader4.Read();
                string Durrrreeee = reader4.GetString(0);
                reader4.Close();
                TB_Duree.Text = Durrrreeee;

                sql4 = "select max_personne from Circuit where nom = '" + LB_Circuit.SelectedItem + "'";
                oraComm6 = new OracleCommand(sql4, connection);
                oraComm6.ExecuteNonQuery();
                reader4 = oraComm6.ExecuteReader();
                reader4.Read();
                int Durrrreeeee = reader4.GetInt32(0);
                reader4.Close();
                TB_maxPersonne.Text = Durrrreeeee.ToString();

                sql4 = "select V.nom from Circuit C inner join Ville V on C.dville = V.code where C.nom = '" + LB_Circuit.SelectedItem + "'";
                oraComm6 = new OracleCommand(sql4, connection);
                oraComm6.ExecuteNonQuery();
                reader4 = oraComm6.ExecuteReader();
                reader4.Read();
                string aaa = reader4.GetString(0);
                reader4.Close();
                TB_Debut.Text = aaa.ToString();

                sql4 = "select V.nom from Circuit C inner join Ville V on C.fville = V.code where C.nom = '" + LB_Circuit.SelectedItem + "'";
                oraComm6 = new OracleCommand(sql4, connection);
                oraComm6.ExecuteNonQuery();
                reader4 = oraComm6.ExecuteReader();
                reader4.Read();
                aaa = reader4.GetString(0);
                reader4.Close();
                TB_Fin.Text = aaa.ToString();

                TB_Nom.Text = LB_Circuit.SelectedItem.ToString();
            }
            catch (Exception sqlclick)
            {
                MessageBox.Show(sqlclick.Message.ToString());
            }
            if (TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "" && TB_Debut.Text != "" && TB_Fin.Text != "")
            {
                BT_Modify.Enabled = true;
            }
        }

        private void BT_Modify_Click(object sender, EventArgs e)
        {
            try
            {
                    string sqlModif = "UPDATE Circuit SET Prix = '" + TB_Prix.Text + "' WHERE nom = '" + LB_Circuit.SelectedItem + "'";

                    OracleCommand modifycmd = new OracleCommand(sqlModif, connection);
                    modifycmd.CommandType = CommandType.Text;
                    modifycmd.ExecuteNonQuery();
                    //DGV_Disques.Refresh();

            }
            catch (Exception sqlupdate)
            {
                MessageBox.Show("Le prix doit etre plus haut ou egal a 50");
                //MessageBox.Show(sqlupdate.Message.ToString());

            }
        }

        private void BT_monument_Click(object sender, EventArgs e)
        {
            Ajouter_Monument dlg = new Ajouter_Monument();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BT_recherche_Click(object sender, EventArgs e)
        {
            Recherche dlg = new Recherche();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Afficher();
        }

        private void BT_Refresh(object sender, EventArgs e)
        {

        }

        private void TB_Prix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TB_Prix_TextChanged(object sender, EventArgs e)
        {

        }

        private void BT_RechercheCircuit_Click(object sender, EventArgs e)
        {
            RechercheCircuit dlg = new RechercheCircuit();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
        
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Apropos dlg = new Apropos();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void BT_Rechercher_Liste_Circuit_Click(object sender, EventArgs e)
        {
            Recherche_Liste_Circuit dlg = new Recherche_Liste_Circuit();
            if (dlg.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
