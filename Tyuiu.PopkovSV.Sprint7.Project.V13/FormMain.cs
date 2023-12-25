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

using Tyuiu.PopkovSV.Sprint7.Project.V13.Lib;
namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            dataGridViewMain_PSV.RowCount = 100;
            dataGridViewMain_PSV.ColumnCount = 100;
            for (int i = 0; i < 100; i++)
            {
                dataGridViewMain_PSV.Columns[i].Width = 150;
            }
        }
        DataService ds = new DataService();
        public static string path = @"C:\Project_PSV\География.csv";

        private void buttonStats_PSV_Click(object sender, EventArgs e)
        {
            FormStats formStats = new FormStats();
            formStats.Show();
        }

        private void buttonOpen_PSV_Click(object sender, EventArgs e)
        {
            openFileDialogMain_PSV.ShowDialog();
            string FileName = openFileDialogMain_PSV.FileName;

            string[,] DataMatrix = ds.GetMatrix(FileName); 

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
            //ToolStripMenuItemSortMax_PSV.Enabled = true;
            //ToolStripMenuItemSortMin_PSV.Enabled = true;
        }

        private void buttonReturn_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);

            int rows = DataMatrix.GetLength(0);
            int columns = DataMatrix.GetLength(1);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                }
            }
        }

        private void ToolStripMenuItemAreaMax_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_PSV.Enabled = true;
        }

        private void ToolStripMenuItemAreaMin_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 3);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_PSV.Enabled = true;
        }

        private void ToolStripMenuItemPopulationMax_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMin(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_PSV.Enabled = true;
        }

        private void ToolStripMenuItemPopulationMin_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataMatrix = ds.GetMatrix(path);
            string[,] SortMinDataMatrix = ds.SortMax(DataMatrix, 5);

            for (int r = 0; r < SortMinDataMatrix.GetLength(0); r++)
            {
                for (int c = 0; c < SortMinDataMatrix.GetLength(1); c++)
                {
                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = SortMinDataMatrix[r, c];
                }
            }
            buttonReturn_PSV.Enabled = true;
        }

        private void buttonSearch_PSV_Click(object sender, EventArgs e)
        {
            if ((textBoxWhatSearch_PSV.Text == "") || (textBoxColumns_PSV.Text == ""))
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string[,] DataMatrix = ds.GetMatrix(path);


                if ((Convert.ToInt32(textBoxColumns_PSV.Text) > 7) || (Convert.ToInt32(textBoxColumns_PSV.Text) < 1))
                {
                    MessageBox.Show("Нет такого столбца!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxWhatSearch_PSV.Text = "";
                    textBoxColumns_PSV.Text = "";
                }
                else
                {
                    string[,] str = ds.Search(DataMatrix, textBoxWhatSearch_PSV.Text, Convert.ToInt32(textBoxColumns_PSV.Text) - 1);
                    try
                    {
                        if (str[0, 0] == null)
                            MessageBox.Show("Не нашлось совпадений!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            for (int r = 1; r < DataMatrix.GetLength(0); r++)
                            {
                                for (int c = 0; c < DataMatrix.GetLength(1); c++)
                                {
                                    dataGridViewMain_PSV.Rows[r].Cells[c].Value = "";
                                }
                            }
                            for (int i = 0; i < DataMatrix.GetLength(1); i++)
                            {
                                dataGridViewMain_PSV.Rows[0].Cells[i].Value = DataMatrix[0, i];
                            }
                            for (int r = 0; r < str.GetLength(0); r++)
                            {
                                for (int c = 0; c < str.GetLength(1); c++)
                                {
                                    dataGridViewMain_PSV.Rows[r + 1].Cells[c].Value = str[r, c];
                                }
                            }

                            buttonReturn_PSV.Enabled = true;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Не нашлось совпадений", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxWhatSearch_PSV.Text = "";
                        textBoxColumns_PSV.Text = "";
                    }
                }
   
                    




            }
        }

        private void buttonAdd_PSV_Click(object sender, EventArgs e)
        {
            if ((textBoxAddArea_PSV.Text == "") || (textBoxAddCapital_PSV.Text == "") || (textBoxAddCountry_PSV.Text == "") || (textBoxAddNational_PSV.Text == "") || (textBoxAddPopulation_PSV.Text == "") || ((radioButtonNo_PSV.Checked == false) && (radioButtonYes_PSV.Checked == false)))
                MessageBox.Show("Не все поля заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string str = "";

                string[,] DataTable = ds.GetMatrix(path);

                bool CountryBusy = ds.CountryExist(DataTable, textBoxAddCountry_PSV.Text);

                if (CountryBusy)
                    MessageBox.Show("Данная Страна уже есть в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    for (int i = 0; i < 7; i++)
                    {
                        if (radioButtonYes_PSV.Checked == true)
                            str = $"{DataTable.GetLength(0)};{textBoxAddCountry_PSV.Text};{textBoxAddCapital_PSV.Text};{textBoxAddArea_PSV.Text};да;{textBoxAddPopulation_PSV.Text};{textBoxAddNational_PSV.Text}";
                        else
                            str = $"{DataTable.GetLength(0)};{textBoxAddCountry_PSV.Text};{textBoxAddCapital_PSV.Text};{textBoxAddArea_PSV.Text};нет;{textBoxAddPopulation_PSV.Text};{textBoxAddNational_PSV.Text}";
                    }
                    File.AppendAllText(path, str + "\n");


                    textBoxAddArea_PSV.Text = "";
                    textBoxAddCapital_PSV.Text = "";
                    textBoxAddCountry_PSV.Text = "";
                    textBoxAddNational_PSV.Text = "";
                    textBoxAddPopulation_PSV.Text = "";
                    radioButtonNo_PSV.Checked = false;
                    radioButtonYes_PSV.Checked = false;

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_PSV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_PSV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }


                    MessageBox.Show("Страна занесена в базу данных", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonDelete_PSV_Click(object sender, EventArgs e)
        {
            if (textBoxDelete_PSV.Text == "")
            {
                MessageBox.Show("Поле пустое!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string[,] DataTable = ds.GetMatrix(path);
                bool CountryBusy = ds.CountryExist(DataTable, textBoxDelete_PSV.Text);

                if (CountryBusy == false)
                    MessageBox.Show("Такой страны нет в базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                    for (int i = 0; i < DataTable.GetLength(0); i++)
                    {
                        if (DataTable[i, 1] == textBoxDelete_PSV.Text)
                            for (int j = 0; j < DataTable.GetLength(1); j++)
                            {
                                DataTable[i, j] = "";
                            }
                    }
                    bool b = false;
                    string[,] NewDataTable = new string[DataTable.GetLength(0) - 1, DataTable.GetLength(1)];
                    for (int i = 0; i < NewDataTable.GetLength(0); i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (DataTable[i, j] == "")
                            {
                                b = true;
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            }
                            if (b)
                                NewDataTable[i, j] = DataTable[i + 1, j];
                            else
                                NewDataTable[i, j] = DataTable[i, j];
                        }
                    }
                    for (int i = 1; i < NewDataTable.GetLength(0); i++)
                    {
                        NewDataTable[i, 0] = Convert.ToString(i);
                    }
                    string[] strRows = new string[NewDataTable.GetLength(0)];
                    for (int i = 0; i < strRows.Length; i++)
                    {
                        for (int j = 0; j < NewDataTable.GetLength(1); j++)
                        {
                            if (j == NewDataTable.GetLength(1) - 1)
                                strRows[i] += NewDataTable[i, j];
                            else
                                strRows[i] += NewDataTable[i, j] + ";";

                        }
                    }


                    File.Delete("Геогрфия.csv");

                    saveFileDialogMain_PSV.FileName = "География.csv";
                    saveFileDialogMain_PSV.ShowDialog();

                    path = saveFileDialogMain_PSV.FileName;

                    File.WriteAllLines(path, strRows, Encoding.UTF8);

                    string[,] DataMatrix = ds.GetMatrix(path);

                    int rows = DataMatrix.GetLength(0);
                    int columns = DataMatrix.GetLength(1);

                    for (int r = 0; r <= rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_PSV.Rows[r].Cells[c].Value = "";
                        }
                    }

                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < columns; c++)
                        {
                            dataGridViewMain_PSV.Rows[r].Cells[c].Value = DataMatrix[r, c];
                        }
                    }
                    MessageBox.Show("Страна удалена из базы", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            textBoxDelete_PSV.Text = "";
        }

        private void buttonHelp_PSV_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.Show();
        }

        private void buttonInfo_PSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }


    }
}
