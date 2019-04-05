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
using System.IO;
using DB_Images_Utilities;

namespace TP_Final
{
    public partial class Ajouter_Monument : Form
    {
        public Image image;
        private DB_Images DB_Images;
        public string GUID = "";
        OracleConnection connection = new OracleConnection();
        private DataSet monDataSet = new DataSet();
        string nomFichier;
        string sql2 = "select nom,prix,image,datem,histoire,etoiles from monument";
        public Ajouter_Monument()
        {
            InitializeComponent();
        }

        private void BT_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlSeq;
                sqlSeq = "select SeqMonument.nextval from dual";
                OracleCommand oraseq = new OracleCommand(sqlSeq, connection);
                oraseq.CommandType = CommandType.Text;
                OracleDataReader reader3 = oraseq.ExecuteReader();
                reader3.Read();
                int num = reader3.GetInt32(0);
                reader3.Close();

                string sqlIns = " insert into monument" +
                "(nom,datem,histoire,image,etoiles,prix,numerosequentiel) values " +
                "(:nom,:datem,:histoire,:image,:etoiles,:prix,:SeqMonument)";

                OracleParameter oraNom = new OracleParameter(":nom", OracleDbType.Varchar2, 30);
                OracleParameter oradatem = new OracleParameter(":datem", OracleDbType.Varchar2, 30);
                OracleParameter orahistoire = new OracleParameter(":histoire", OracleDbType.Varchar2, 200);
                OracleParameter oraimage = new OracleParameter(":image", OracleDbType.Varchar2,200);
                OracleParameter oraetoiles = new OracleParameter(":etoiles", OracleDbType.Int32, 4);
                OracleParameter oraprix = new OracleParameter(":prix", OracleDbType.Int32, 4);
                OracleParameter oranumerosequentiel = new OracleParameter(":SeqMonument", OracleDbType.Int32, 4);

                oraNom.Value = TB_Nom.Text;
                oradatem.Value = DTP_Date.Value.ToShortDateString();
                orahistoire.Value = TB_Histoire.Text;
                oraimage.Value = LBX_ImagesGUIDs.SelectedItem;
                oraetoiles.Value = TB_Etoiles.Text;
                oraprix.Value = TB_Prix.Text;
                oranumerosequentiel.Value = num;

                OracleCommand oraAjout = new OracleCommand(sqlIns, connection);
                oraAjout.CommandType = CommandType.Text;
                oraAjout.Parameters.Add(oraNom);
                oraAjout.Parameters.Add(oradatem);
                oraAjout.Parameters.Add(orahistoire);
                oraAjout.Parameters.Add(oraimage);
                oraAjout.Parameters.Add(oraetoiles);
                oraAjout.Parameters.Add(oraprix);
                oraAjout.Parameters.Add(oranumerosequentiel);
                oraAjout.ExecuteNonQuery();
                dissocier();
            }
            catch(Exception sql)
            {
                MessageBox.Show(sql.Message.ToString());
            }
        }

        private string RechercherFichier()
        {
            OpenFileDialog fImage = new OpenFileDialog();
            fImage.Title = "Selectionner une image";
            fImage.CheckFileExists = true;
            fImage.InitialDirectory = @":C/";
            // Fimage.InitialDirectory = Application.StartupPath;
            fImage.Filter = "Fichiers images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            fImage.FilterIndex = 1;
            fImage.RestoreDirectory = true;

            if (fImage.ShowDialog() == DialogResult.OK)
            {
                nomFichier = fImage.FileName;
                Bitmap bitmap1 = new Bitmap(nomFichier);
            }
            else
            {
                nomFichier = null;
            }
            return nomFichier;
        }

        private void Ajouter_Monument_Load(object sender, EventArgs e)
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

        private void afficherTxt()
        {
            try
            {
                OracleDataAdapter Adapter2 = new OracleDataAdapter(sql2, connection);
                if (monDataSet.Tables.Contains("resMonument"))
                {
                    monDataSet.Tables["resMonument"].Clear();
                }
                Adapter2.Fill(monDataSet, "resMonument");
                Adapter2.Dispose();
            }
            catch(Exception sql234)
            {
                MessageBox.Show(sql234.Message.ToString());
            }
        }

        private void dissocier()
        {
            TB_Etoiles.DataBindings.Clear();
            TB_Histoire.DataBindings.Clear();
            TB_Prix.DataBindings.Clear();
            TB_Nom.DataBindings.Clear();
            DTP_Date.DataBindings.Clear();

            TB_Etoiles.Clear();
            TB_Histoire.Clear();
            TB_Prix.Clear();
            TB_Nom.Clear();
            DTP_Date.Value = DateTime.Now;
        }
        
        private void Load_ImageGUIDs()
        {
            foreach(string GUID in DB_Images.GetImageGUIDList())
            {
                LBX_ImagesGUIDs.Items.Add(GUID);
            }
        }
        
        private void Ajouter_Monument_Shown(object sender, EventArgs e)
        {
            DB_Images = new DB_Images("lol", "lol");
            Load_ImageGUIDs();
        }

        private void LBX_ImagesGUIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LBX_ImagesGUIDs.SelectedItem != null)
            {
                string GUID = LBX_ImagesGUIDs.SelectedItem.ToString();
                PBX_SelectedGUID.Image = DB_Images.Find(GUID);
            }
            else
            {
                PBX_SelectedGUID.BackgroundImage = null;
            }
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
