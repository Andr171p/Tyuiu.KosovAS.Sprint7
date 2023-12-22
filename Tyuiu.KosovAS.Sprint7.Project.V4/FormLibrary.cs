using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Tyuiu.KosovAS.Sprint7.Project.V4.Lib;

namespace Tyuiu.KosovAS.Sprint7.Project.V4
{
    public partial class FormLibrary : Form
    {
        public FormLibrary()
        {
            InitializeComponent();

            openFileDialogLibrary_KAS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogLibrary_KAS.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string OpenFilePath;

        DataService ds = new DataService();

        public static object[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251));

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            object[,] arrayValues = new object[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonSaleSort_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.SaleSort(LoadFromFileData(filePath: OpenFilePath));


                this.chartStatistics_KAS.ChartAreas[0].AxisX.Title = "Цена";
                this.chartStatistics_KAS.ChartAreas[0].AxisY.Title = "Книги";

                chartStatistics_KAS.Series[0].Points.Clear();

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewResult_KAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }

                    chartStatistics_KAS.Series[0].Points.AddXY(r, arrayValues[r, 3]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOpenFile_KAS_Click(Object sender, EventArgs e)
        {
            openFileDialogLibrary_KAS.ShowDialog();
            OpenFilePath = openFileDialogLibrary_KAS.FileName;

            object[,] arrayValues = new object[rows, columns];

            arrayValues = LoadFromFileData(OpenFilePath);

            dataGridViewInPut_KAS.ColumnCount = columns;
            dataGridViewInPut_KAS.RowCount = rows;

            dataGridViewResult_KAS.ColumnCount = columns;
            dataGridViewResult_KAS.RowCount = rows;

            for (int i = 0;  i < columns; i++)
            {
                dataGridViewInPut_KAS.Columns[i].Width = 100;
                dataGridViewResult_KAS.Columns[i].Width = 100;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPut_KAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }


        }

        private void buttonYearSort_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                this.chartStatistics_KAS.ChartAreas[0].AxisX.Title = "Год";
                this.chartStatistics_KAS.ChartAreas[0].AxisY.Title = "Книги";

                chartStatistics_KAS.Series[0].Points.Clear();

                object[,] arrayValues = new object[rows, columns];
                arrayValues = ds.YearSort(LoadFromFileData(filePath: OpenFilePath));

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewResult_KAS.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                    chartStatistics_KAS.Series[0].Points.AddXY(r, arrayValues[r, 2]);

                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSearch_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                string targetElement = Convert.ToString(textBoxSearch_KAS.Text);

                string[] arrayValues = new string[columns];
                arrayValues = ds.Search(LoadFromFileData(filePath: OpenFilePath), targetElement);

                for (int c = 0; c < columns; c++)
                {
                    dataGridViewResult_KAS.Rows[0].Cells[c].Value = arrayValues[c];
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonStat_KAS_Click(object sender, EventArgs e)
        {
            try
            {
                string commandStat = Convert.ToString(textBoxCommand_KAS.Text);
                int columnIndex = Convert.ToInt32(textBoxColumnNum_KAS.Text) - 1;

                object[,] dataBase = new object[rows, columns];
                dataBase = LoadFromFileData(filePath: OpenFilePath);

                textBoxResult_KAS.Text = Convert.ToString(ds.DataStatistics(dataBase, commandStat, columnIndex));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSaveFile_KAS_Click(object sender, EventArgs e)
        {
            saveFileDialogLibrary_KAS.FileName = "OutPutFileProjectV4.csv";
            saveFileDialogLibrary_KAS.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogLibrary_KAS.ShowDialog();

            string path = saveFileDialogLibrary_KAS.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewResult_KAS.RowCount;
            int columns = dataGridViewResult_KAS.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0;  j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewResult_KAS.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewResult_KAS.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonSaleSort_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }

        private void buttonYearSort_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }

        private void buttonSearch_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }

        private void buttonStatistics_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }

        private void buttonOpenFile_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }

        private void buttonSaveFile_KAS_MouseEnter(object sender, EventArgs e)
        {
            toolTipInfo_KAS.ToolTipTitle = "Подсказка";
        }
    }
}
