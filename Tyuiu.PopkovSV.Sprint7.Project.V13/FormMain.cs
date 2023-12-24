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
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        private void buttonInfo_PSV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonHelp_PSV_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        private void buttonOpen_PSV_Click(object sender, EventArgs e)
        {
            try
            {
                // задаем столбцы
                dataGridViewMain_PSV.ColumnCount = 7;

                // выгружаем данные из цсв файла
                using (var reader = new StreamReader("DataBase.csv"))
                {
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';'); // празделитель это точка с запятой

                        dataGridViewMain_PSV.Rows.Add(values);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonSave_PSV_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialogMain_PSV.FileName = ".csv";
                saveFileDialogMain_PSV.InitialDirectory = @":L";
                if (saveFileDialogMain_PSV.ShowDialog() == DialogResult.OK)
                {
                    string savepath = saveFileDialogMain_PSV.FileName;

                    if (File.Exists(savepath)) File.Delete(savepath);

                    int rows = dataGridViewMain_PSV.RowCount;
                    int columns = dataGridViewMain_PSV.ColumnCount;

                    StringBuilder strBuilder = new StringBuilder();

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            strBuilder.Append(dataGridViewMain_PSV.Rows[i].Cells[j].Value);

                            if (j != columns - 1) strBuilder.Append(";"); // ???
                        }
                        strBuilder.AppendLine();
                    }
                    File.WriteAllText(savepath, strBuilder.ToString(), Encoding.GetEncoding(1251));
                    MessageBox.Show("Файл успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Файл не сохранен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_PSV_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewMain_PSV.Rows.Add();
            }
            catch
            {
                MessageBox.Show("Невозможно добавить данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_PSV_Click(object sender, EventArgs e)
        {
            if (dataGridViewMain_PSV.RowCount != 0)
            {
                int del = 0;
                var result = MessageBox.Show($"{"Удалить данную строку?\rЕё невозможно будет восстановить"}", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    del = 1;
                }
                if (del == 1)
                {
                    int a = dataGridViewMain_PSV.CurrentCell.RowIndex;
                    dataGridViewMain_PSV.Rows.RemoveAt(a);
                }
            }
            else
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReturn_PSV_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewMain_PSV.Rows)
            {
                row.Visible = true;
            }
        }
        
        private void textBoxSearch_PSV_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_PSV.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewMain_PSV.Rows)
            {
                if (row.Cells["Номер"].Value != null && row.Cells["Страна"].Value != null)
                {
                    string column1Text = row.Cells["Номер"].Value.ToString().ToLower();
                    string column2Text = row.Cells["Страна"].Value.ToString().ToLower();
                    string column3Text = row.Cells["Столица"].Value.ToString().ToLower();

                    if (column1Text.Contains(searchText) || column2Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBoxFilt_PSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли сортировка по алфавиту
            if (comboBoxFilt_PSV.SelectedItem != null && comboBoxFilt_PSV.SelectedItem.ToString() == "По алфавиту")
            {
                // Проводим сортировку по алфавиту
                //SortDataTableAlphabetically();
            }
            // Проверяем, выбрана ли сортировка по окладу
            else if (comboBoxFilt_PSV.SelectedItem != null && comboBoxFilt_PSV.SelectedItem.ToString() == "По площади")
            {
                // Проводим сортировку по окладу
                //SortDataTableBySalary();
            }
            // Проверяем, выбрана ли сортировка по возрасту
            else if (comboBoxFilt_PSV.SelectedItem != null && comboBoxFilt_PSV.SelectedItem.ToString() == "По кол-во населения")
            {
                // Проводим сортировку по возрасту
                //SortDataTableByAge();
            }
            else
            {
                // Другие варианты фильтрации, если необходимо
            }
        }

    }
}
