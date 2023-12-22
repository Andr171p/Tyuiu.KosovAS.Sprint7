namespace Tyuiu.KosovAS.Sprint7.Project.V4
{
    partial class FormLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibrary));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxInPut_KAS = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPut_KAS = new System.Windows.Forms.DataGridView();
            this.groupBoxResult_KAS = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KAS = new System.Windows.Forms.DataGridView();
            this.openFileDialogLibrary_KAS = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogLibrary_KAS = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxDone_KAS = new System.Windows.Forms.GroupBox();
            this.buttonSaleSort_KAS = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAS = new System.Windows.Forms.Button();
            this.labelSort_KAS = new System.Windows.Forms.Label();
            this.buttonYearSort_KAS = new System.Windows.Forms.Button();
            this.labelSearch_KAS = new System.Windows.Forms.Label();
            this.textBoxSearch_KAS = new System.Windows.Forms.TextBox();
            this.buttonSearch_KAS = new System.Windows.Forms.Button();
            this.labelStatistics_KAS = new System.Windows.Forms.Label();
            this.labelColumn_KAS = new System.Windows.Forms.Label();
            this.textBoxColumnNum_KAS = new System.Windows.Forms.TextBox();
            this.labelCommand_KAS = new System.Windows.Forms.Label();
            this.textBoxCommand_KAS = new System.Windows.Forms.TextBox();
            this.buttonStat_KAS = new System.Windows.Forms.Button();
            this.textBoxResult_KAS = new System.Windows.Forms.TextBox();
            this.buttonSaveFile_KAS = new System.Windows.Forms.Button();
            this.chartStatistics_KAS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ColumnAvtor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxStatistics_KAS = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTipInfo_KAS = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxInPut_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAS)).BeginInit();
            this.groupBoxResult_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAS)).BeginInit();
            this.groupBoxDone_KAS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_KAS)).BeginInit();
            this.groupBoxStatistics_KAS.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInPut_KAS
            // 
            this.groupBoxInPut_KAS.Controls.Add(this.dataGridViewInPut_KAS);
            this.groupBoxInPut_KAS.Location = new System.Drawing.Point(5, 230);
            this.groupBoxInPut_KAS.Name = "groupBoxInPut_KAS";
            this.groupBoxInPut_KAS.Size = new System.Drawing.Size(517, 267);
            this.groupBoxInPut_KAS.TabIndex = 0;
            this.groupBoxInPut_KAS.TabStop = false;
            this.groupBoxInPut_KAS.Text = "Ввод данных";
            // 
            // dataGridViewInPut_KAS
            // 
            this.dataGridViewInPut_KAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPut_KAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAvtor,
            this.ColumnName,
            this.ColumnYear,
            this.ColumnSale,
            this.ColumnBook});
            this.dataGridViewInPut_KAS.Location = new System.Drawing.Point(7, 25);
            this.dataGridViewInPut_KAS.Name = "dataGridViewInPut_KAS";
            this.dataGridViewInPut_KAS.RowHeadersVisible = false;
            this.dataGridViewInPut_KAS.RowHeadersWidth = 62;
            this.dataGridViewInPut_KAS.RowTemplate.Height = 28;
            this.dataGridViewInPut_KAS.Size = new System.Drawing.Size(504, 236);
            this.dataGridViewInPut_KAS.TabIndex = 2;
            // 
            // groupBoxResult_KAS
            // 
            this.groupBoxResult_KAS.Controls.Add(this.dataGridViewResult_KAS);
            this.groupBoxResult_KAS.Location = new System.Drawing.Point(528, 230);
            this.groupBoxResult_KAS.Name = "groupBoxResult_KAS";
            this.groupBoxResult_KAS.Size = new System.Drawing.Size(510, 267);
            this.groupBoxResult_KAS.TabIndex = 1;
            this.groupBoxResult_KAS.TabStop = false;
            this.groupBoxResult_KAS.Text = "Вывод данных";
            // 
            // dataGridViewResult_KAS
            // 
            this.dataGridViewResult_KAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewResult_KAS.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewResult_KAS.Name = "dataGridViewResult_KAS";
            this.dataGridViewResult_KAS.RowHeadersVisible = false;
            this.dataGridViewResult_KAS.RowHeadersWidth = 62;
            this.dataGridViewResult_KAS.RowTemplate.Height = 28;
            this.dataGridViewResult_KAS.Size = new System.Drawing.Size(504, 236);
            this.dataGridViewResult_KAS.TabIndex = 3;
            // 
            // openFileDialogLibrary_KAS
            // 
            this.openFileDialogLibrary_KAS.FileName = "openFileDialogLibrary_KAS";
            // 
            // groupBoxDone_KAS
            // 
            this.groupBoxDone_KAS.Controls.Add(this.buttonSaveFile_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.textBoxResult_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.buttonOpenFile_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.buttonStat_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.textBoxCommand_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.labelCommand_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.textBoxColumnNum_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.labelColumn_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.labelStatistics_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.buttonSearch_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.textBoxSearch_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.labelSearch_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.buttonYearSort_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.labelSort_KAS);
            this.groupBoxDone_KAS.Controls.Add(this.buttonSaleSort_KAS);
            this.groupBoxDone_KAS.Location = new System.Drawing.Point(5, 12);
            this.groupBoxDone_KAS.Name = "groupBoxDone_KAS";
            this.groupBoxDone_KAS.Size = new System.Drawing.Size(511, 212);
            this.groupBoxDone_KAS.TabIndex = 2;
            this.groupBoxDone_KAS.TabStop = false;
            this.groupBoxDone_KAS.Text = "Работа с библиотекой";
            // 
            // buttonSaleSort_KAS
            // 
            this.buttonSaleSort_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonSaleSort_KAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaleSort_KAS.Location = new System.Drawing.Point(132, 21);
            this.buttonSaleSort_KAS.Name = "buttonSaleSort_KAS";
            this.buttonSaleSort_KAS.Size = new System.Drawing.Size(121, 39);
            this.buttonSaleSort_KAS.TabIndex = 4;
            this.buttonSaleSort_KAS.Text = "по цене";
            this.toolTipInfo_KAS.SetToolTip(this.buttonSaleSort_KAS, "Сортирует строки по цене");
            this.buttonSaleSort_KAS.UseVisualStyleBackColor = false;
            this.buttonSaleSort_KAS.Click += new System.EventHandler(this.buttonSaleSort_KAS_Click);
            this.buttonSaleSort_KAS.MouseEnter += new System.EventHandler(this.buttonSaleSort_KAS_MouseEnter);
            // 
            // buttonOpenFile_KAS
            // 
            this.buttonOpenFile_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_KAS.Image")));
            this.buttonOpenFile_KAS.Location = new System.Drawing.Point(395, 21);
            this.buttonOpenFile_KAS.Name = "buttonOpenFile_KAS";
            this.buttonOpenFile_KAS.Size = new System.Drawing.Size(110, 62);
            this.buttonOpenFile_KAS.TabIndex = 5;
            this.toolTipInfo_KAS.SetToolTip(this.buttonOpenFile_KAS, "Открывает файл");
            this.buttonOpenFile_KAS.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAS.Click += new System.EventHandler(this.buttonOpenFile_KAS_Click);
            this.buttonOpenFile_KAS.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAS_MouseEnter);
            // 
            // labelSort_KAS
            // 
            this.labelSort_KAS.AutoSize = true;
            this.labelSort_KAS.Location = new System.Drawing.Point(12, 30);
            this.labelSort_KAS.Name = "labelSort_KAS";
            this.labelSort_KAS.Size = new System.Drawing.Size(114, 20);
            this.labelSort_KAS.TabIndex = 5;
            this.labelSort_KAS.Text = "Сортировать:";
            // 
            // buttonYearSort_KAS
            // 
            this.buttonYearSort_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonYearSort_KAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonYearSort_KAS.Location = new System.Drawing.Point(259, 21);
            this.buttonYearSort_KAS.Name = "buttonYearSort_KAS";
            this.buttonYearSort_KAS.Size = new System.Drawing.Size(121, 39);
            this.buttonYearSort_KAS.TabIndex = 6;
            this.buttonYearSort_KAS.Text = "по году";
            this.toolTipInfo_KAS.SetToolTip(this.buttonYearSort_KAS, "Сортирует строки по году");
            this.buttonYearSort_KAS.UseVisualStyleBackColor = false;
            this.buttonYearSort_KAS.Click += new System.EventHandler(this.buttonYearSort_KAS_Click);
            this.buttonYearSort_KAS.MouseEnter += new System.EventHandler(this.buttonYearSort_KAS_MouseEnter);
            // 
            // labelSearch_KAS
            // 
            this.labelSearch_KAS.AutoSize = true;
            this.labelSearch_KAS.Location = new System.Drawing.Point(12, 94);
            this.labelSearch_KAS.Name = "labelSearch_KAS";
            this.labelSearch_KAS.Size = new System.Drawing.Size(59, 20);
            this.labelSearch_KAS.TabIndex = 7;
            this.labelSearch_KAS.Text = "Поиск:";
            // 
            // textBoxSearch_KAS
            // 
            this.textBoxSearch_KAS.Location = new System.Drawing.Point(68, 88);
            this.textBoxSearch_KAS.Name = "textBoxSearch_KAS";
            this.textBoxSearch_KAS.Size = new System.Drawing.Size(185, 26);
            this.textBoxSearch_KAS.TabIndex = 8;
            // 
            // buttonSearch_KAS
            // 
            this.buttonSearch_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonSearch_KAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSearch_KAS.Location = new System.Drawing.Point(259, 81);
            this.buttonSearch_KAS.Name = "buttonSearch_KAS";
            this.buttonSearch_KAS.Size = new System.Drawing.Size(121, 40);
            this.buttonSearch_KAS.TabIndex = 9;
            this.buttonSearch_KAS.Text = "найти";
            this.toolTipInfo_KAS.SetToolTip(this.buttonSearch_KAS, "Находит строку с нужным элементом");
            this.buttonSearch_KAS.UseVisualStyleBackColor = false;
            this.buttonSearch_KAS.Click += new System.EventHandler(this.buttonSearch_KAS_Click);
            this.buttonSearch_KAS.MouseEnter += new System.EventHandler(this.buttonSearch_KAS_MouseEnter);
            // 
            // labelStatistics_KAS
            // 
            this.labelStatistics_KAS.AutoSize = true;
            this.labelStatistics_KAS.Location = new System.Drawing.Point(12, 131);
            this.labelStatistics_KAS.Name = "labelStatistics_KAS";
            this.labelStatistics_KAS.Size = new System.Drawing.Size(103, 20);
            this.labelStatistics_KAS.TabIndex = 6;
            this.labelStatistics_KAS.Text = "Статистика:";
            // 
            // labelColumn_KAS
            // 
            this.labelColumn_KAS.AutoSize = true;
            this.labelColumn_KAS.Location = new System.Drawing.Point(7, 172);
            this.labelColumn_KAS.Name = "labelColumn_KAS";
            this.labelColumn_KAS.Size = new System.Drawing.Size(127, 20);
            this.labelColumn_KAS.TabIndex = 10;
            this.labelColumn_KAS.Text = "номер столбца:";
            // 
            // textBoxColumnNum_KAS
            // 
            this.textBoxColumnNum_KAS.Location = new System.Drawing.Point(145, 166);
            this.textBoxColumnNum_KAS.Name = "textBoxColumnNum_KAS";
            this.textBoxColumnNum_KAS.Size = new System.Drawing.Size(43, 26);
            this.textBoxColumnNum_KAS.TabIndex = 11;
            // 
            // labelCommand_KAS
            // 
            this.labelCommand_KAS.AutoSize = true;
            this.labelCommand_KAS.Location = new System.Drawing.Point(194, 172);
            this.labelCommand_KAS.Name = "labelCommand_KAS";
            this.labelCommand_KAS.Size = new System.Drawing.Size(79, 20);
            this.labelCommand_KAS.TabIndex = 12;
            this.labelCommand_KAS.Text = "команда:";
            // 
            // textBoxCommand_KAS
            // 
            this.textBoxCommand_KAS.Location = new System.Drawing.Point(271, 166);
            this.textBoxCommand_KAS.Name = "textBoxCommand_KAS";
            this.textBoxCommand_KAS.Size = new System.Drawing.Size(109, 26);
            this.textBoxCommand_KAS.TabIndex = 13;
            // 
            // buttonStat_KAS
            // 
            this.buttonStat_KAS.BackColor = System.Drawing.Color.Lime;
            this.buttonStat_KAS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStat_KAS.Location = new System.Drawing.Point(132, 120);
            this.buttonStat_KAS.Name = "buttonStat_KAS";
            this.buttonStat_KAS.Size = new System.Drawing.Size(121, 40);
            this.buttonStat_KAS.TabIndex = 14;
            this.buttonStat_KAS.Text = "применить";
            this.toolTipInfo_KAS.SetToolTip(this.buttonStat_KAS, "Считает элементы статиситики");
            this.buttonStat_KAS.UseVisualStyleBackColor = false;
            this.buttonStat_KAS.Click += new System.EventHandler(this.buttonStat_KAS_Click);
            this.buttonStat_KAS.MouseEnter += new System.EventHandler(this.buttonStatistics_KAS_MouseEnter);
            // 
            // textBoxResult_KAS
            // 
            this.textBoxResult_KAS.Location = new System.Drawing.Point(271, 131);
            this.textBoxResult_KAS.Name = "textBoxResult_KAS";
            this.textBoxResult_KAS.Size = new System.Drawing.Size(109, 26);
            this.textBoxResult_KAS.TabIndex = 15;
            // 
            // buttonSaveFile_KAS
            // 
            this.buttonSaveFile_KAS.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile_KAS.Image")));
            this.buttonSaveFile_KAS.Location = new System.Drawing.Point(395, 98);
            this.buttonSaveFile_KAS.Name = "buttonSaveFile_KAS";
            this.buttonSaveFile_KAS.Size = new System.Drawing.Size(110, 62);
            this.buttonSaveFile_KAS.TabIndex = 6;
            this.toolTipInfo_KAS.SetToolTip(this.buttonSaveFile_KAS, "Сохраняет в файл");
            this.buttonSaveFile_KAS.UseVisualStyleBackColor = true;
            this.buttonSaveFile_KAS.Click += new System.EventHandler(this.buttonSaveFile_KAS_Click);
            this.buttonSaveFile_KAS.MouseEnter += new System.EventHandler(this.buttonSaveFile_KAS_MouseEnter);
            // 
            // chartStatistics_KAS
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStatistics_KAS.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStatistics_KAS.Legends.Add(legend1);
            this.chartStatistics_KAS.Location = new System.Drawing.Point(6, 25);
            this.chartStatistics_KAS.Name = "chartStatistics_KAS";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStatistics_KAS.Series.Add(series1);
            this.chartStatistics_KAS.Size = new System.Drawing.Size(498, 181);
            this.chartStatistics_KAS.TabIndex = 16;
            // 
            // ColumnAvtor
            // 
            this.ColumnAvtor.HeaderText = "Автор";
            this.ColumnAvtor.MinimumWidth = 8;
            this.ColumnAvtor.Name = "ColumnAvtor";
            this.ColumnAvtor.Width = 150;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "Название";
            this.ColumnName.MinimumWidth = 8;
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Width = 150;
            // 
            // ColumnYear
            // 
            this.ColumnYear.HeaderText = "Год";
            this.ColumnYear.MinimumWidth = 8;
            this.ColumnYear.Name = "ColumnYear";
            this.ColumnYear.Width = 150;
            // 
            // ColumnSale
            // 
            this.ColumnSale.HeaderText = "Цена";
            this.ColumnSale.MinimumWidth = 8;
            this.ColumnSale.Name = "ColumnSale";
            this.ColumnSale.Width = 150;
            // 
            // ColumnBook
            // 
            this.ColumnBook.HeaderText = "Жанр";
            this.ColumnBook.MinimumWidth = 8;
            this.ColumnBook.Name = "ColumnBook";
            this.ColumnBook.Width = 150;
            // 
            // groupBoxStatistics_KAS
            // 
            this.groupBoxStatistics_KAS.Controls.Add(this.chartStatistics_KAS);
            this.groupBoxStatistics_KAS.Location = new System.Drawing.Point(528, 12);
            this.groupBoxStatistics_KAS.Name = "groupBoxStatistics_KAS";
            this.groupBoxStatistics_KAS.Size = new System.Drawing.Size(510, 212);
            this.groupBoxStatistics_KAS.TabIndex = 17;
            this.groupBoxStatistics_KAS.TabStop = false;
            this.groupBoxStatistics_KAS.Text = "График";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Автор";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Год";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Цена";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Жанр";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // toolTipInfo_KAS
            // 
            this.toolTipInfo_KAS.IsBalloon = true;
            // 
            // FormLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 505);
            this.Controls.Add(this.groupBoxStatistics_KAS);
            this.Controls.Add(this.groupBoxDone_KAS);
            this.Controls.Add(this.groupBoxResult_KAS);
            this.Controls.Add(this.groupBoxInPut_KAS);
            this.Name = "FormLibrary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.groupBoxInPut_KAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPut_KAS)).EndInit();
            this.groupBoxResult_KAS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAS)).EndInit();
            this.groupBoxDone_KAS.ResumeLayout(false);
            this.groupBoxDone_KAS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStatistics_KAS)).EndInit();
            this.groupBoxStatistics_KAS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInPut_KAS;
        private System.Windows.Forms.GroupBox groupBoxResult_KAS;
        private System.Windows.Forms.DataGridView dataGridViewInPut_KAS;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAS;
        private System.Windows.Forms.OpenFileDialog openFileDialogLibrary_KAS;
        private System.Windows.Forms.SaveFileDialog saveFileDialogLibrary_KAS;
        private System.Windows.Forms.GroupBox groupBoxDone_KAS;
        private System.Windows.Forms.Button buttonSaleSort_KAS;
        private System.Windows.Forms.Button buttonOpenFile_KAS;
        private System.Windows.Forms.Label labelSort_KAS;
        private System.Windows.Forms.Button buttonYearSort_KAS;
        private System.Windows.Forms.TextBox textBoxSearch_KAS;
        private System.Windows.Forms.Label labelSearch_KAS;
        private System.Windows.Forms.Button buttonSearch_KAS;
        private System.Windows.Forms.Label labelStatistics_KAS;
        private System.Windows.Forms.TextBox textBoxCommand_KAS;
        private System.Windows.Forms.Label labelCommand_KAS;
        private System.Windows.Forms.TextBox textBoxColumnNum_KAS;
        private System.Windows.Forms.Label labelColumn_KAS;
        private System.Windows.Forms.Button buttonStat_KAS;
        private System.Windows.Forms.TextBox textBoxResult_KAS;
        private System.Windows.Forms.Button buttonSaveFile_KAS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStatistics_KAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAvtor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBook;
        private System.Windows.Forms.GroupBox groupBoxStatistics_KAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolTip toolTipInfo_KAS;
    }
}