namespace MyExcelApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pnlFileHeader = new System.Windows.Forms.Panel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tblLytAddMem = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBeat = new System.Windows.Forms.TextBox();
            this.textDistrict = new System.Windows.Forms.TextBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.textCDateTime = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txtSearchExpr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridExcelList = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textGrid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textCrimedescr = new System.Windows.Forms.TextBox();
            this.textUcr_ncic_code = new System.Windows.Forms.TextBox();
            this.textLatitude = new System.Windows.Forms.TextBox();
            this.textLongitude = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.empConstantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlFileHeader.SuspendLayout();
            this.tblLytAddMem.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcelList)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(727, 363);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pnlFileHeader);
            this.tabPage1.Controls.Add(this.tblLytAddMem);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(719, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add New Member";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pnlFileHeader
            // 
            this.pnlFileHeader.Controls.Add(this.btnLoad);
            this.pnlFileHeader.Controls.Add(this.txtFileName);
            this.pnlFileHeader.Controls.Add(this.label13);
            this.pnlFileHeader.Location = new System.Drawing.Point(8, 6);
            this.pnlFileHeader.Name = "pnlFileHeader";
            this.pnlFileHeader.Size = new System.Drawing.Size(512, 44);
            this.pnlFileHeader.TabIndex = 3;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(414, 9);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(185, 10);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(222, 23);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Provide team excel : ";
            // 
            // tblLytAddMem
            // 
            this.tblLytAddMem.ColumnCount = 2;
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.91954F));
            this.tblLytAddMem.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.08046F));
            this.tblLytAddMem.Controls.Add(this.panel1, 0, 0);
            this.tblLytAddMem.Controls.Add(this.panel2, 1, 0);
            this.tblLytAddMem.Controls.Add(this.panel3, 1, 1);
            this.tblLytAddMem.Location = new System.Drawing.Point(6, 53);
            this.tblLytAddMem.Name = "tblLytAddMem";
            this.tblLytAddMem.RowCount = 2;
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.55133F));
            this.tblLytAddMem.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.44867F));
            this.tblLytAddMem.Size = new System.Drawing.Size(515, 263);
            this.tblLytAddMem.TabIndex = 2;
            this.tblLytAddMem.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 215);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Beat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "District";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CDateTime";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textLongitude);
            this.panel2.Controls.Add(this.textLatitude);
            this.panel2.Controls.Add(this.textUcr_ncic_code);
            this.panel2.Controls.Add(this.textCrimedescr);
            this.panel2.Controls.Add(this.textGrid);
            this.panel2.Controls.Add(this.textBeat);
            this.panel2.Controls.Add(this.textDistrict);
            this.panel2.Controls.Add(this.textAddress);
            this.panel2.Controls.Add(this.textCDateTime);
            this.panel2.Location = new System.Drawing.Point(187, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 215);
            this.panel2.TabIndex = 1;
            // 
            // textBeat
            // 
            this.textBeat.Location = new System.Drawing.Point(14, 74);
            this.textBeat.Name = "textBeat";
            this.textBeat.Size = new System.Drawing.Size(261, 23);
            this.textBeat.TabIndex = 5;
            // 
            // textDistrict
            // 
            this.textDistrict.Location = new System.Drawing.Point(14, 50);
            this.textDistrict.Name = "textDistrict";
            this.textDistrict.Size = new System.Drawing.Size(261, 23);
            this.textDistrict.TabIndex = 2;
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(14, 25);
            this.textAddress.Name = "textAddress";
            this.textAddress.Size = new System.Drawing.Size(261, 23);
            this.textAddress.TabIndex = 1;
            // 
            // textCDateTime
            // 
            this.textCDateTime.Location = new System.Drawing.Point(14, 3);
            this.textCDateTime.Name = "textCDateTime";
            this.textCDateTime.Size = new System.Drawing.Size(261, 23);
            this.textCDateTime.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(187, 227);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 33);
            this.panel3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Member";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonAdd);
            this.tabPage2.Controls.Add(this.txtSearchExpr);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.cmbSearch);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridExcelList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(719, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(28, 63);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "+ Add New";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txtSearchExpr
            // 
            this.txtSearchExpr.Location = new System.Drawing.Point(87, 27);
            this.txtSearchExpr.Name = "txtSearchExpr";
            this.txtSearchExpr.ReadOnly = true;
            this.txtSearchExpr.Size = new System.Drawing.Size(242, 20);
            this.txtSearchExpr.TabIndex = 4;
            this.txtSearchExpr.TextChanged += new System.EventHandler(this.txtSearchExpr_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(491, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Search In : ";
            // 
            // cmbSearch
            // 
            this.cmbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Items.AddRange(new object[] {
            "address",
            "beat",
            "cdatetime",
            "crimedescr",
            "district",
            "grid",
            "latitude",
            "longitude",
            "ucr_ncic_code"});
            this.cmbSearch.Location = new System.Drawing.Point(582, 26);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(121, 21);
            this.cmbSearch.Sorted = true;
            this.cmbSearch.TabIndex = 2;
            this.cmbSearch.SelectedIndexChanged += new System.EventHandler(this.cmbSearch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Search : ";
            // 
            // dataGridExcelList
            // 
            this.dataGridExcelList.AllowUserToOrderColumns = true;
            this.dataGridExcelList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridExcelList.Location = new System.Drawing.Point(3, 92);
            this.dataGridExcelList.Name = "dataGridExcelList";
            this.dataGridExcelList.RowHeadersWidth = 50;
            this.dataGridExcelList.Size = new System.Drawing.Size(710, 239);
            this.dataGridExcelList.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(596, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "About";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(149, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 17);
            this.label9.TabIndex = 5;
            this.label9.Text = "chnandakumarreddy@gmail.com";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Malgun Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(35, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Contact Details : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(211, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nanda Kumar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Design and Development : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(374, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "This application is intended for managing the team information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Grid";
            // 
            // textGrid
            // 
            this.textGrid.Location = new System.Drawing.Point(14, 98);
            this.textGrid.Name = "textGrid";
            this.textGrid.Size = new System.Drawing.Size(261, 23);
            this.textGrid.TabIndex = 6;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 17);
            this.label15.TabIndex = 5;
            this.label15.Text = "Crimedescr";
            // 
            // textCrimedescr
            // 
            this.textCrimedescr.Location = new System.Drawing.Point(14, 122);
            this.textCrimedescr.Name = "textCrimedescr";
            this.textCrimedescr.Size = new System.Drawing.Size(261, 23);
            this.textCrimedescr.TabIndex = 7;
            // 
            // textUcr_ncic_code
            // 
            this.textUcr_ncic_code.Location = new System.Drawing.Point(14, 142);
            this.textUcr_ncic_code.Name = "textUcr_ncic_code";
            this.textUcr_ncic_code.Size = new System.Drawing.Size(261, 23);
            this.textUcr_ncic_code.TabIndex = 8;
            // 
            // textLatitude
            // 
            this.textLatitude.Location = new System.Drawing.Point(14, 166);
            this.textLatitude.Name = "textLatitude";
            this.textLatitude.Size = new System.Drawing.Size(261, 23);
            this.textLatitude.TabIndex = 9;
            // 
            // textLongitude
            // 
            this.textLongitude.Location = new System.Drawing.Point(14, 189);
            this.textLongitude.Name = "textLongitude";
            this.textLongitude.Size = new System.Drawing.Size(261, 23);
            this.textLongitude.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 145);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "Ucr_ncic_code";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 17);
            this.label17.TabIndex = 7;
            this.label17.Text = "Latitude";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(80, 17);
            this.label18.TabIndex = 8;
            this.label18.Text = "Longitude";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(109, 63);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "- Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // empConstantsBindingSource
            // 
            this.empConstantsBindingSource.DataSource = typeof(MyExcelApp.RecConstants);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "TeamApp - Nanda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.pnlFileHeader.ResumeLayout(false);
            this.pnlFileHeader.PerformLayout();
            this.tblLytAddMem.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExcelList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.empConstantsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tblLytAddMem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBeat;
        private System.Windows.Forms.TextBox textDistrict;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.TextBox textCDateTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridExcelList;
        private System.Windows.Forms.TextBox txtSearchExpr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource empConstantsBindingSource;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel pnlFileHeader;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textCrimedescr;
        private System.Windows.Forms.TextBox textGrid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textLongitude;
        private System.Windows.Forms.TextBox textLatitude;
        private System.Windows.Forms.TextBox textUcr_ncic_code;
        private System.Windows.Forms.Button buttonDelete;

    }
}

