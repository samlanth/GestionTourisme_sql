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
    public partial class RechercheCircuit : Form
    {
        OracleConnection connection = new OracleConnection();
        public RechercheCircuit()
        {
            InitializeComponent();
        }

        private void RechercheCircuit_Load(object sender, EventArgs e)
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
            try
            {
                DGV_Circuit.Rows.Clear();
                string sql4 = "select c.nom,c.prix,count(c.nom) as nb_monument3etoiles from circuit c INNER JOIN circuitmonument cm ON c.numerosequentiel = cm.circuit_numerosequentiel INNER JOIN monument m on cm.monument_numerosequentiel = m.numerosequentiel where m.etoiles > 2 group by c.nom,c.prix";
                
                OracleCommand cmd4 = new OracleCommand(sql4, connection);
                cmd4.CommandType = CommandType.Text;
                OracleDataReader reader3 = cmd4.ExecuteReader();
                while (reader3.Read())
                {
                    DGV_Circuit.Rows.Add(reader3.GetString(0), reader3.GetInt32(1), reader3.GetInt32(2));
                }
                reader3.Close();

            }
            catch (Exception sqlConnex2)
            {
                MessageBox.Show(sqlConnex2.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
