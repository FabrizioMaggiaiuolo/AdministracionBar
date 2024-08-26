using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace FormsBar
{
    public partial class FrmData : Form
    {
        DataTable table = new DataTable();
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;

        public FrmData()
        {
            InitializeComponent();
            this.sqlConnection = new SqlConnection("Server=.;Database=Prueba;Trusted_Connection=True;");
        }

        private void FrmData_Load(object sender, EventArgs e)
        {
            dgvMeses.DataSource = table;

            table.Columns.Add("Mes", typeof(string));
            table.Columns.Add("Money", typeof(decimal));

            try
            {
                this.sqlConnection.Open();


                this.sqlCommand = new SqlCommand("SELECT * FROM dbo.DatosMensuales;");

                this.sqlCommand.Connection = this.sqlConnection;

                using (SqlDataReader reader = this.sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        table.Rows.Add(reader.GetString(reader.GetOrdinal("Mes")), reader.GetDouble(reader.GetOrdinal("Plata")));
                    }
                }


                this.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
