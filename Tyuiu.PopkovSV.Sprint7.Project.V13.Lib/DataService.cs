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
        public string[,] LoadFromDataFile(string path)
        {
            string[] str = File.ReadAllLines(path);

            //определение количества столбцов и строк 
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
    }
}




