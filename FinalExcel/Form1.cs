using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyExcelApp;

namespace MyExcelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Selecting += new TabControlCancelEventHandler(tabControl1_Selecting);

            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;


        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs args)
        {
            TabPage current = (sender as TabControl).SelectedTab;

            if (string.IsNullOrEmpty(MyExcel.DB_PATH))
            {
                MessageBox.Show(" Please provide excel file ..", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                args.Cancel = true;
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (tc.SelectedIndex == 1)
            {
                dataGridExcelList.DataSource = (BindingList<ExcelRecord>)MyExcel.ExcelList;
                dataGridExcelList.AutoResizeColumns();

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ExcelRecord rec = new ExcelRecord {  cdatetime = textCDateTime.Text.ToString(),
                                           address = textAddress.Text.ToString(),
                                           district = textDistrict.Text.ToString(),
                                           beat = textBeat.Text.ToString(),
                                                 grid = textGrid.Text.ToString(),
                                                 crimedescr = textCrimedescr.Text.ToString(),
                                                 ucr_ncic_code = textUcr_ncic_code.Text.ToString(),
                                                 latitude = textLatitude.Text.ToString(),
                                                 longitude = textLongitude.Text.ToString()
                                        };
            MyExcel.WriteToExcel(rec);
            clearAllFields();
            MessageBox.Show("Details were successfully added to the excel !!", "Success..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textCDateTime.Focus();

            tabControl1.SelectedTab = tabPage2 ;
        }

        public void clearAllFields()
        { 
            textCDateTime.Text = "";
            textDistrict.Text = "";
            textAddress.Text = "";
            textBeat.Text = "";
            textGrid.Text = "";
            textCrimedescr.Text = "";
            textUcr_ncic_code.Text = "";
            textLatitude.Text = "";
            textLongitude.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected  override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if(!string.IsNullOrEmpty(MyExcel.DB_PATH))
            MyExcel.CloseExcel();
        }

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchExpr.ReadOnly = false;
        }

        private void txtSearchExpr_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearchExpr.Text))
            {
                dataGridExcelList.DataSource = MyExcel.FilterExcelList(cmbSearch.Text.ToString(), txtSearchExpr.Text.ToLower());
            }
            else
            {
                dataGridExcelList.DataSource = MyExcel.ExcelList;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ExcelDialog = new OpenFileDialog();
            ExcelDialog.Filter = "Excel Files (*.xlsx) | *.xlsx";
            ExcelDialog.InitialDirectory = @"C:\";
            ExcelDialog.Title = "Select your team excel";
            if (ExcelDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MyExcel.DB_PATH = ExcelDialog.FileName;
                txtFileName.Text = ExcelDialog.FileName;
                txtFileName.ReadOnly = true;
                txtFileName.Click -= btnLoad_Click;
                tabControl1.Selecting -= tabControl1_Selecting;
                btnLoad.Enabled = false;
                MyExcel.InitializeExcel();
                dataGridExcelList.DataSource = MyExcel.ReadMyExcel();
                tblLytAddMem.Visible = true;

                // add check box
                DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
                dataGridExcelList.Columns.Add(chk);
                chk.HeaderText = "Check Data";
                chk.Name = "chk";
                
                // end add check box

                tabControl1.SelectedTab = tabPage2;

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //dataGridExcelList.Rows[2].Cells[10].Value = true;
            //bool a = Convert.ToBoolean(dataGridExcelList.Rows[1].Cells[10].Value);
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void buttonBrowseData_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void textCrimedescr_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(MyExcel.DB_PATH))
                MyExcel.CloseExcel();
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Yemeni/excel_instance/issues");
        }

    }
}
