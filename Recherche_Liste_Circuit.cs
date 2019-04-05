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
    public partial class Recherche_Liste_Circuit : Form
    {
        OracleConnection connection = new OracleConnection();
        public Recherche_Liste_Circuit()
        {
            InitializeComponent();
        }

        private void Recherche_Liste_Circuit_Load(object sender, EventArgs e)
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
                string sql1 = " select nom from ville";
                string sql2 = "select nom from monument";
                OracleCommand comm = new OracleCommand(sql1, connection);
                OracleDataReader read = comm.ExecuteReader();
                while (read.Read())
                {
                    CB_Debut.Items.Add(read.GetString(0));
                    
                }

                OracleCommand comm2 = new OracleCommand(sql2, connection);
                OracleDataReader read2 = comm2.ExecuteReader();
                while (read2.Read())
                {
                    CB_Monument.Items.Add(read2.GetString(0));

                }

            }

            catch (Exception sqlConnex)
            {
                MessageBox.Show(sqlConnex.Message.ToString());
            }
        }

        private void CB_Debut_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_Circuit.Rows.Clear();
                string sql4 = "select c.nom, c.Dville, c.Fville, prix from circuit c inner join Ville v on c.dville = v.code where v.nom = '" + CB_Debut.Text + "'";
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    string Fville = "";
                    string Dville = "";
                    if (reader3.GetInt32(1) == 1)
                    {
                        Dville = "MONTREAL";
                    }
                    if (reader3.GetInt32(1) == 2)
                    {
                        Dville = "QUEBEC";
                    }
                    if (reader3.GetInt32(1) == 3)
                    {
                        Dville = "GRANBY";
                    }
                    if (reader3.GetInt32(1) == 4)
                    {
                        Dville = "SHERBROOKE";
                    }
                    if (reader3.GetInt32(2) == 1)
                    {
                        Fville = "MONTREAL";
                    }
                    if (reader3.GetInt32(2) == 2)
                    {
                        Fville = "QUEBEC";
                    }
                    if (reader3.GetInt32(2) == 3)
                    {
                        Fville = "GRANBY";
                    }
                    if (reader3.GetInt32(2) == 4)
                    {
                        Fville = "SHERBROOKE";
                    }
                    DGV_Circuit.Rows.Add(reader3.GetString(0), Dville, Fville, reader3.GetInt32(3));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void CB_Monument_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DGV_Circuit.Rows.Clear();
                string sql4 = "select c.nom, c.Dville, c.Fville, c.prix from circuit c inner join Ville v on c.dville = v.code inner join circuitmonument cm on cm.circuit_numerosequentiel = c.numerosequentiel inner join monument m on m.numerosequentiel = cm.monument_numerosequentiel where m.nom = '" + CB_Monument.Text + "'";
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    string Fville = "";
                    string Dville = "";
                    if (reader3.GetInt32(1) == 1)
                    {
                        Dville = "MONTREAL";
                    }
                    if (reader3.GetInt32(1) == 2)
                    {
                        Dville = "QUEBEC";
                    }
                    if (reader3.GetInt32(1) == 3)
                    {
                        Dville = "GRANBY";
                    }
                    if (reader3.GetInt32(1) == 4)
                    {
                        Dville = "SHERBROOKE";
                    }
                    if (reader3.GetInt32(2) == 1)
                    {
                        Fville = "MONTREAL";
                    }
                    if (reader3.GetInt32(2) == 2)
                    {
                        Fville = "QUEBEC";
                    }
                    if (reader3.GetInt32(2) == 3)
                    {
                        Fville = "GRANBY";
                    }
                    if (reader3.GetInt32(2) == 4)
                    {
                        Fville = "SHERBROOKE";
                    }
                    DGV_Circuit.Rows.Add(reader3.GetString(0), Dville, Fville, reader3.GetInt32(3));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void BT_Recherche_Click(object sender, EventArgs e)
        {
            try
            {
                DGV_Circuit.Rows.Clear();
                string sql4 = "select c.nom, c.Dville, c.Fville, c.prix from circuit c inner join Ville v on c.dville = v.code where c.prix <= " + TB_Prix.Text + "";
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    string Fville = "";
                    string Dville = "";
                    if (reader3.GetInt32(1) == 1)
                    {
                        Dville = "MONTREAL";
                    }
                    if (reader3.GetInt32(1) == 2)
                    {
                        Dville = "QUEBEC";
                    }
                    if (reader3.GetInt32(1) == 3)
                    {
                        Dville = "GRANBY";
                    }
                    if (reader3.GetInt32(1) == 4)
                    {
                        Dville = "SHERBROOKE";
                    }
                    if (reader3.GetInt32(2) == 1)
                    {
                        Fville = "MONTREAL";
                    }
                    if (reader3.GetInt32(2) == 2)
                    {
                        Fville = "QUEBEC";
                    }
                    if (reader3.GetInt32(2) == 3)
                    {
                        Fville = "GRANBY";
                    }
                    if (reader3.GetInt32(2) == 4)
                    {
                        Fville = "SHERBROOKE";
                    }
                    DGV_Circuit.Rows.Add(reader3.GetString(0), Dville, Fville, reader3.GetInt32(3));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
