using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;

using System.Reflection;
using System.IO;
using System.Data.OleDb;

namespace excel_instance
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            path = Path.Combine(path, "SacramentocrimeJanuary2006.xlsx");
            string ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path
                + @";Extended Properties=""Excel 12.0 Macro;Mode=ReadWrite;ReadOnly=False;HDR=Yes;ImportMixedTypes=Text;TypeGuessRows=0""";
            OleDbConnection conn = new OleDbConnection(ConnectionString);
            string strCMD = "select * from [SacramentocrimeJanuary2006$A1:I51]";
            OleDbCommand cmd = new OleDbCommand(strCMD, conn);

            try
            {
                conn.Open();
                ds.Clear();
                adapter.SelectCommand = cmd;
                adapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {

                conn.Close();
            }
        }
    }
}




