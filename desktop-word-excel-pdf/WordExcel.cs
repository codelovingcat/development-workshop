using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using word = Microsoft.Office.Interop.Word;
using excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace desktop_word_excel_pdf
{
    public partial class WordExcel : Form
    {
        public WordExcel()
        {
            InitializeComponent();
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            word.Application application = new word.Application();

            application.Visible = true;
            word.Document document;
            object wordObject = System.Reflection.Missing.Value;
            document = application.Documents.Add(ref wordObject);
            application.Selection.TypeText(textTitle.Text);
            application.Selection.TypeText(richTextBox1.Text);

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = application.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range range = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[2, 5];
            range.Value2= richTextBox1.Text;
            Microsoft.Office.Interop.Excel.Range title = (Microsoft.Office.Interop.Excel.Range)worksheet.Cells[1, 3];
            title.Value2 = textTitle.Text;
        }

    }
}
