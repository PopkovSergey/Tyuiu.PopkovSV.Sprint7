using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PopkovSV.Sprint7.Project.V13.Lib;

namespace Tyuiu.PopkovSV.Sprint7.Project.V13
{
    public partial class FormStats : Form
    {
        DataService ds = new DataService();
        public static string path = @"C:\Project_PSV\География.csv";

        public FormStats()
        {
            InitializeComponent();
        }

        private void buttonDevelop_PSV_Click(object sender, EventArgs e)
        {
            chartStats_PSV.Series[0].Points.Clear();

            this.chartStats_PSV.ChartAreas[0].AxisX.Title = "Является ли страна развитой";
            this.chartStats_PSV.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 4);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 4);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartStats_PSV.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonNational_PSV_Click(object sender, EventArgs e)
        {
            chartStats_PSV.Series[0].Points.Clear();

            this.chartStats_PSV.ChartAreas[0].AxisX.Title = "Преобладающая национальность";
            this.chartStats_PSV.ChartAreas[0].AxisY.Title = "Количество стран";

            string[,] DataTable = ds.GetMatrix(path);

            string[] ArrayWords = ds.ArrayStrWordsElements(DataTable, 6);

            int[] ArraySumWords = ds.ArraySumWords(DataTable, ArrayWords, 6);

            for (int i = 0; i < ArrayWords.Length; i++)
            {
                chartStats_PSV.Series[0].Points.AddXY(ArrayWords[i], ArraySumWords[i]);
            }
        }

        private void buttonViewStats_PSV_Click(object sender, EventArgs e)
        {
            string[,] DataTable = ds.GetMatrix(path);
            double AverageArea = ds.Average(DataTable, 3);
            double AveragePopulation = ds.Average(DataTable, 5);

            textBoxAverageArea_PSV.Text = Convert.ToString(AverageArea);
            textBoxAveragePopulation_PSV.Text = Convert.ToString(AveragePopulation);
        }
    }
}
