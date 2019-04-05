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
using Validation;

namespace TP_Final
{
    public partial class Ajouter : Form
    {
        private ValidationProvider ValidationProvider;
        OracleConnection connection = new OracleConnection();
        public Ajouter()
        {
            InitializeComponent();
        }

        private bool Validate_TBX_nom(ref string message)
        {
            BT_Ajouter.Enabled = false;
            message = "Nom d'usager manquant";
            if(TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "")
            {
                BT_Ajouter.Enabled = true;
            }
            return TB_Nom.Text != "";
        }
        private bool Validate_TBX_prix(ref string message)
        {
            BT_Ajouter.Enabled = false;
            message = "prix manquant";
            if (TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "")
            {
                BT_Ajouter.Enabled = true;
            }
            return TB_Prix.Text != "";
        }
        private bool Validate_TBX_duree(ref string message)
        {
            BT_Ajouter.Enabled = false;
            message = "duree manquante";
            if (TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "")
            {
                BT_Ajouter.Enabled = true;
            }
            return TB_Duree.Text != "";
        }
        private bool Validate_TBX_max(ref string message)
        {
            BT_Ajouter.Enabled = false;
            message = "max personne manquante";
            if (TB_Nom.Text != "" && TB_Prix.Text != "" && TB_Duree.Text != "" && TB_maxPersonne.Text != "")
            {
                BT_Ajouter.Enabled = true;
            }
            return TB_maxPersonne.Text != "";
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

        private void Ajouter_Circuit()
        {
            string sqlSeq;
            sqlSeq = "select SequenceFirst.nextval from dual";
            OracleCommand oraseq = new OracleCommand(sqlSeq, connection);
            oraseq.CommandType = CommandType.Text;
            OracleDataReader reader3 = oraseq.ExecuteReader();
            reader3.Read();
            int num = reader3.GetInt32(0);
            reader3.Close();

            string sqlIns = " insert into circuit" +
            "(nom,prix,duree,max_personne,numerosequentiel,dville,fville) values " +
            "(:nom,:prix,:duree,:max_personne,:numerosequentiel,:dville,:fville)";

            OracleParameter oraNom = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
            OracleParameter oraPrix = new OracleParameter(":prix", OracleDbType.Int32, 4);
            OracleParameter oraDuree = new OracleParameter(":duree", OracleDbType.Varchar2, 30);
            OracleParameter oraMaxPersonne = new OracleParameter(":max_personne", OracleDbType.Int32, 4);
            OracleParameter oraNumeroSequentiel = new OracleParameter(":numerosequentiel", OracleDbType.Int32, 4);
            OracleParameter oraDville = new OracleParameter(":dville", OracleDbType.Int32, 4);
            OracleParameter oraFville = new OracleParameter(":fville", OracleDbType.Int32, 4);

            oraNom.Value = TB_Nom.Text;
            oraPrix.Value = TB_Prix.Text;
            oraDuree.Value = TB_Duree.Text;
            oraMaxPersonne.Value = TB_maxPersonne.Text;
            oraNumeroSequentiel.Value = num;

            string Fville ="";
            string Dville = "";
            if (CB_Fin.Text == "MONTREAL")
            {
                Fville = "1";
            }
            if (CB_Fin.Text == "QUEBEC")
            {
                Fville = "2";
            }
            if (CB_Fin.Text == "GRANBY")
            {
                Fville = "3";
            }
            if (CB_Fin.Text == "SHERBROOKE")
            {
                Fville = "4";
            }
            if (CB_Debut.Text == "MONTREAL")
            {
                Dville = "1";
            }
            if (CB_Debut.Text == "QUEBEC")
            {
                Dville = "2";
            }
            if (CB_Debut.Text == "GRANBY")
            {
                Dville = "3";
            }
            if (CB_Debut.Text == "SHERBROOKE")
            {
                Dville = "4";
            }
            oraDville.Value = Dville;
            oraFville.Value = Fville;

            OracleCommand oraAjout = new OracleCommand(sqlIns, connection);
            oraAjout.CommandType = CommandType.Text;

            oraAjout.Parameters.Add(oraNom);
            oraAjout.Parameters.Add(oraPrix);
            oraAjout.Parameters.Add(oraDuree);
            oraAjout.Parameters.Add(oraMaxPersonne);
            oraAjout.Parameters.Add(oraNumeroSequentiel);
            oraAjout.Parameters.Add(oraDville);
            oraAjout.Parameters.Add(oraFville);

            oraAjout.ExecuteNonQuery();
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                Ajouter_Circuit();
            }
            catch (Exception sqlConnex)
            {
                MessageBox.Show("Le Prix doit etre plus haut ou egal a 50");
                //MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {
            SeConnecter();
            string sql1 = " select nom from ville";
            OracleCommand comm = new OracleCommand(sql1, connection);
            OracleDataReader read = comm.ExecuteReader();
            while (read.Read())
            {
                CB_Debut.Items.Add(read.GetString(0));
                CB_Fin.Items.Add(read.GetString(0));
            }
            if (CB_Debut.Items.Count > 0 && CB_Fin.Items.Count > 0)
            {
                CB_Debut.SelectedIndex = 0;
                CB_Fin.SelectedIndex = 0;
            }

            ValidationProvider = new ValidationProvider(this);
            ValidationProvider.AddControlToValidate(TB_maxPersonne, Validate_TBX_max);
            ValidationProvider.AddControlToValidate(TB_Duree, Validate_TBX_duree);
            ValidationProvider.AddControlToValidate(TB_Nom, Validate_TBX_nom);
            ValidationProvider.AddControlToValidate(TB_Prix, Validate_TBX_prix);

        }

        private void CB_Debut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TB_Nom_TextChanged(object sender, EventArgs e)
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

        private void TB_maxPersonne_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TB_Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
