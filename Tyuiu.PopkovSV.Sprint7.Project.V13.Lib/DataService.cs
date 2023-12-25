using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tyuiu.PopkovSV.Sprint7.Project.V13.Lib
{
    public class DataService  
    {
        public string[,] GetMatrix(string path) 
        {
            string[] str = File.ReadAllLines(path);

            int columns = str[0].Split(';').Length;
            int rows = str.Length;

            string[,] matrix = new string[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < strArr.Length; c++)
                {
                    matrix[i, c] = strArr[c];
                }
            }
            return matrix;
        }



        public string[,] SortMin(string[,] matrix, int NumberColumn) // по возрастанию
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => x.CompareTo(y));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }



        public string[,] SortMax(string[,] matrix, int NumberColumn) // по убыванию
        {
            int[] Entrance = new int[matrix.GetLength(0) - 1];
            Entrance[Entrance.Length - 1] = Convert.ToInt32(matrix[matrix.GetLength(0) - 1, NumberColumn]);
            for (int i = 0; i < Entrance.Length - 1; i++)
            {
                Entrance[i] = Convert.ToInt32(matrix[i + 1, NumberColumn]);
            }

            Array.Sort(Entrance, (x, y) => y.CompareTo(x));

            string[,] SortMatrix = new string[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < SortMatrix.GetLength(1); i++)
            {
                SortMatrix[0, i] = matrix[0, i];
            }

            for (int i = 0; i < SortMatrix.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < matrix.GetLength(0); j++)
                {
                    if (Entrance[i] == Convert.ToInt32(matrix[j, NumberColumn]))
                    {
                        for (int c = 0; c < SortMatrix.GetLength(1); c++)
                        {
                            SortMatrix[i + 1, c] = matrix[j, c];
                        }
                        matrix[j, NumberColumn] = "-1";
                        break;
                    }
                }
            }
            return SortMatrix;
        }


        public string[,] Search(string[,] DataTable, string Brand, int Columns)
        {
            int flag = 0;
            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                if (DataTable[i, Columns] == Brand)
                {
                    flag++;
                }
            }

            string[,] res = new string[flag, 7];
            int f = 0;

            for (int i = 0; i < DataTable.GetLength(0); i++)
            {
                if (DataTable[i, Columns] == Brand)
                {
                    for (int r = 0; r < res.GetLength(1); r++)
                    {
                        res[f, r] = DataTable[i, r];
                    }
                    DataTable[i, 1] = "";
                    f++;
                }
            }
            return res;
        }


        public bool CountryExist(string[,] DataTable, string Country)
        {
            bool b = false;
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                if (Country == DataTable[i, 1])
                    b = true;
            }
            return b;
        }



        public string[] ArrayStrWordsElements(string[,] DataTable, int NumColumns)
        {
            int flag = 0;
            string strCountElements = "";
            for (int i = 1; i < DataTable.GetLength(0); i++)
            {
                flag = 0;
                for (int a = 1; a < i; a++)
                {
                    if (DataTable[a, NumColumns] == DataTable[i, NumColumns])
                        flag = 1;
                }
                if (flag == 0)
                    strCountElements += DataTable[i, NumColumns] + " ";
            }
            string[] str = strCountElements.Split(' ');
            string[] res = new string[str.Length - 1];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = str[i];
            }


            return res;
        }



        public int[] ArraySumWords(string[,] DataTable, string[] Entrance, int NumColumns)
        {
            int[] res = new int[Entrance.Length];
            for (int i = 0; i < Entrance.Length; i++)
            {
                for (int j = 1; j < DataTable.GetLength(0); j++)
                {
                    if (Entrance[i] == DataTable[j, NumColumns])
                        res[i] += 1;
                }
            }
            return res;
        }



        public double Average(string[,] DataTable, int NumColumns)
        {
            double average = 0;
            double sum = 0;
            for (int r = 1; r < DataTable.GetLength(0); r++)
            {
                sum += Convert.ToDouble(DataTable[r, NumColumns]);
            }
            average = sum / (DataTable.GetLength(0) - 1);
            return Math.Round(average, 1);
        }
    }
}




