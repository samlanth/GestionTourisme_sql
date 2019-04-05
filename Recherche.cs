using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace TP_Final
{
    public partial class Recherche : Form
    {
        OracleConnection connection = new OracleConnection();
        public Recherche()
        {
            InitializeComponent();
        }

        private void CB_etoile_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_monument.Rows.Clear();
                DGV_circuit.Rows.Clear();
                if(CB_etoile.Text == "Tout Choisir")
                {
                    string sql4 = "select nom, datem, etoiles, prix from monument";
                    OracleCommand cmd4 = new OracleCommand(sql4, connection);
                    cmd4.CommandType = CommandType.Text;
                    OracleDataReader reader3 = cmd4.ExecuteReader();
                    while (reader3.Read())
                    {
                        DGV_monument.Rows.Add(reader3.GetString(0), reader3.GetString(1), reader3.GetInt32(2), reader3.GetInt32(3));
                    }
                    reader3.Close();
                }
                else
                {
                    string sql4 = "select nom, datem, etoiles, prix from monument where etoiles = '" + CB_etoile.Text + "'";
                    OracleCommand cmd4 = new OracleCommand(sql4, connection);
                    cmd4.CommandType = CommandType.Text;
                    OracleDataReader reader3 = cmd4.ExecuteReader();
                    while (reader3.Read())
                    {
                        DGV_monument.Rows.Add(reader3.GetString(0), reader3.GetString(1), reader3.GetInt32(2), reader3.GetInt32(3));
                    }
                    reader3.Close();
                }
                

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void Recherche_Load(object sender, EventArgs e)
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
                CB_etoile.Items.Add("Tout Choisir");
                CB_etoile.Items.Add("1");
                CB_etoile.Items.Add("2");
                CB_etoile.Items.Add("3");
                CB_etoile.Items.Add("4");
                CB_etoile.Items.Add("5");
                
                //string sql1 = " select etoiles from monument";
                //OracleCommand comm = new OracleCommand(sql1, connection);
                //OracleDataReader read = comm.ExecuteReader();
                //while (read.Read())
                //{
                //    CB_etoile.Items.Add(read.GetInt32(0));
                //}
                //if (CB_etoile.Items.Count > 0)
                //{
                    CB_etoile.SelectedIndex = 0;
                //}
            }

            catch (Exception sqlConnex)
            {
                MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void DGV_circuit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_monument_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DGV_circuit.Rows.Clear();
                string sql4 = "select c.nom,c.prix,cm.ordre from circuit c inner join circuitmonument cm on c.numerosequentiel = cm.circuit_numerosequentiel inner join monument m on m.numerosequentiel = cm.monument_numerosequentiel where m.nom ='" + DGV_monument.CurrentRow.Cells[0].Value + "'";
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    DGV_circuit.Rows.Add(reader3.GetString(0), reader3.GetInt32(1), reader3.GetInt32(2));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void DGV_monument_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
