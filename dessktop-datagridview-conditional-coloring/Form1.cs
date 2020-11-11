using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dessktop_datagridview_conditional_coloring
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwindDataSet.Products);
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                //DataGridViewCellStyle color = new DataGridViewCellStyle();
                //if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[5].Value)==true)
                //{
                //    color.BackColor = Color.Red;
                //    color.ForeColor = Color.Aqua;
                //}
                //else
                //{
                //    color.BackColor = Color.Red;
                //    color.ForeColor = Color.Green;
                //}

                DataGridViewCellStyle color = new DataGridViewCellStyle();
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value) <=10)
                {
                    color.BackColor = Color.LightBlue;
                    color.ForeColor = Color.White;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[7].Value) >= 10)
                {
                    color.BackColor = Color.Red;
                    color.ForeColor = Color.White;
                }
                if (Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value) == 1)
                {
                    color.BackColor = Color.White;
                    color.ForeColor = Color.Black;
                }
                else
                {
                    color.BackColor = Color.DarkSeaGreen;
                    color.ForeColor = Color.White;
                }
                dataGridView1.Rows[i].DefaultCellStyle = color;
            }
        }
    }
}
