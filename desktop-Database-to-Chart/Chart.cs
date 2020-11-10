using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace desktop_Database_to_Chart
{
    public partial class Chart : Form
    {
        SqlConnection connection = new SqlConnection(@"Server=(localdb)\mssqllocaldb;Database=Northwind; Trusted_Connection=true");
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select ProductName, UnitPrice, CategoryID,UnitsOnOrder, UnitsInStock From Products", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                chart1.Series["Products"].Points.AddXY(reader[0].ToString(), reader[1].ToString());
            }
            connection.Close();
        }
    }
}
