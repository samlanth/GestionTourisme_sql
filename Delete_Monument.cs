using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DB_Images_Utilities;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace TP_Final
{
    public partial class Delete_Monument : Form
    {
        public Image image;
        private DB_Images DB_Images;
        OracleConnection connection = new OracleConnection();
        public Delete_Monument()
        {
            InitializeComponent();
        }

        private void Delete_Monument_Load(object sender, EventArgs e)
        {
            DB_Images = new DB_Images("lol", "lol");
            try
            {
                string dsource = "(DESCRIPTION="
                     + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                     + "(HOST=mercure.clg.qc.ca)(PORT=1521)))"
                     + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)))";
                string chaineDeconnexion = "Data Source = " + dsource + "; User Id = lanthies; password = ORACLE1";
                connection.ConnectionString = chaineDeconnexion;
                connection.Open();
                string sql2 = "select nom from circuit";
                OracleCommand oraComm5 = new OracleCommand(sql2, connection);
                OracleDataReader oraReader5 = oraComm5.ExecuteReader();
                while (oraReader5.Read())
                {
                    CB_circuit.Items.Add(oraReader5.GetString(0));
                }
                CB_circuit.SelectedIndex = 0;
            }
            catch (Exception sqlConnex)
            {
                MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void CB_circuit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_monument.Rows.Clear();
                 string sql4 = "select M.nom, datem, histoire, etoiles, m.prix, cm.ordre, cm.circuit_numerosequentiel from monument m inner join circuitmonument cm on m.numerosequentiel = cm.monument_numerosequentiel inner join Circuit C on c.numerosequentiel = cm.circuit_numerosequentiel where c.nom = '" + CB_circuit.Text + "'";
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    DGV_monument.Rows.Add(reader3.GetString(0), reader3.GetString(1), reader3.GetString(2), reader3.GetInt32(3), reader3.GetInt32(4), reader3.GetInt32(5), reader3.GetInt32(6));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void BT_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedRow = DGV_monument.CurrentCell.RowIndex;
                if (selectedRow >= 0)
                {
                    string sqldel = "delete from circuitmonument where ordre=" + DGV_monument.CurrentRow.Cells[5].Value.ToString() + " AND circuit_numerosequentiel =" + DGV_monument.CurrentRow.Cells[6].Value.ToString();
                    //string sqldel2 = "delete from monument where nom ='" + DGV_monument.CurrentRow.Cells[0].Value + "'";

                    DataGridViewRow row = DGV_monument.Rows[selectedRow];
                    DGV_monument.Rows.RemoveAt(selectedRow);

                    OracleCommand delcmd2 = new OracleCommand(sqldel, connection);
                    delcmd2.CommandType = CommandType.Text;
                    delcmd2.ExecuteNonQuery();

                    //OracleCommand delcmd = new OracleCommand(sqldel2, connection);
                    //delcmd.CommandType = CommandType.Text;
                    //delcmd.ExecuteNonQuery();

                    

                    DGV_monument.Refresh();
                }
            }
            catch (Exception sqldel)
            {
                MessageBox.Show(sqldel.Message.ToString());
            }
            DGV_monument.Refresh();
        }

        private void DGV_monument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PBX_SelectedGUID_Click(object sender, EventArgs e)
        {

        }

        private void DGV_monument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql4 = "select image from monument where nom = '"+DGV_monument.CurrentRow.Cells[0].Value +"'";
            OracleCommand cmd4 = new OracleCommand(sql4, connection);
            cmd4.CommandType = CommandType.Text;
            OracleDataReader reader3 = cmd4.ExecuteReader();
            reader3.Read();
            string GUID = reader3.GetString(0);
            reader3.Close();
            if (GUID != null)
            {
               // string GUID = LBX_ImagesGUIDs.SelectedItem.ToString();
                PBX_SelectedGUID.Image = DB_Images.Find(GUID);
            }
            else
            {
                PBX_SelectedGUID.BackgroundImage = null;
            }
        }
    }
}
