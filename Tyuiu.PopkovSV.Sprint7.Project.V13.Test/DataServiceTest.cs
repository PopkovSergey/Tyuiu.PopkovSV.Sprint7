using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PopkovSV.Sprint7.Project.V13.Lib;

namespace Tyuiu.PopkovSV.Sprint7.Project.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();

        [TestMethod]
        public void TestSortMin()
        {
            string[,] Matrix =
            {
                {"efre","freferref","feferffer"},
                {"7","freferref","feferffer"},
                {"6","freferref","feferffer"},
                {"12","freferref","feferffer"},
            };



            string[,] res = ds.SortMin(Matrix, 0);
            string[,] wait =
            {
                {"efre","freferref","feferffer"},
                {"6","freferref","feferffer"},
                {"7","freferref","feferffer"},
                
                {"12","freferref","feferffer"},
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSortMax()
        {
            string[,] Matrix =
               {
                {"efre","freferref","feferffer"},
                {"7","freferref","feferffer"},
                {"6","freferref","feferffer"},
                {"12","freferref","feferffer"},
            };



            string[,] res = ds.SortMax(Matrix, 0);
            string[,] wait =
            {
                {"efre","freferref","feferffer"},
                {"12","freferref","feferffer"},
                {"7","freferref","feferffer"},
                {"6","freferref","feferffer"},
                
            };
            CollectionAssert.AreEqual(wait, res);
        }


        [TestMethod]
        public void TestSearch()
        {
            string[,] Matrix =
               {
                {"efre","rgrtg","feferffer","feferffer","feferffer","feferffer","feferffer"},
                {"7","freferref","feferffer","feferffer","feferffer","feferffer","feferffer"},
                {"6","Bro","feferffer","feferffer","feferffer","feferffer","feferffer"},
                {"12","Bro","feferffer","feferffer","feferffer","feferffer","feferffer"},
            };



            string[,] res = ds.Search(Matrix,"Bro", 1);
            string[,] wait =
            {
                //{"efre","rgrtg","feferffer","feferffer","feferffer","feferffer","feferffer"},
                //{"7","freferref","feferffer","feferffer","feferffer","feferffer","feferffer"},
                {"6","Bro","feferffer","feferffer","feferffer","feferffer","feferffer"},
                {"12","Bro","feferffer","feferffer","feferffer","feferffer","feferffer"},

            };
            CollectionAssert.AreEqual(wait, res);
        }



        [TestMethod]
        public void TestCountryExist()
        {
            string[,] Matrix =
               {
                {"efre","freferref","feferffer"},
                {"7","Москва","feferffer"},
                {"6","freferref","feferffer"},
                {"12","freferref","feferffer"},
            };



            bool res = ds.CountryExist(Matrix, "Москва");
            bool wait = true;

            Assert.AreEqual(wait, res);

        }



        [TestMethod]
        public void TestArrayStrWordsElements()
        {
            string[,] DataTabl =
            {
                {"ID","ФИО","Стаж","Номер авто","Марка авто","Расзод топлива","Пробег" },
                {"1","пкупу п упу пук","10","н589рп","мерс","15","10000" },
                {"2","ппекь пьзекь ппкепк","12","е758ав","мерс","16","12000" },
                {"3","пккеп пкепке епке","11","й456ек","лада","24","120000" },
                {"4","пекпекп кеп кепекп","5","Ф432АК","тоета","9","0" },
            };



            string[] res = ds.ArrayStrWordsElements(DataTabl, 4);
            string[] wait = { "мерс", "лада", "тоета" };
            CollectionAssert.AreEqual(wait, res);
        }




        [TestMethod]
        public void TestArraySumWords()
        {
            string[,] DataTabl =
            {
                {"ID","ФИО","Стаж","Номер авто","Марка авто","Расзод топлива","Пробег" },
                {"1","пкупу п упу пук","10","н589рп","мерс","15","10000" },
                {"2","ппекь пьзекь ппкепк","12","е758ав","мерс","16","12000" },
                {"3","пккеп пкепке епке","11","й456ек","лада","24","120000" },
                {"4","пекпекп кеп кепекп","5","Ф432АК","тоета","9","0" },
            };



            int[] res = ds.ArraySumWords(DataTabl, ds.ArrayStrWordsElements(DataTabl, 4), 4);
            int[] wait = { 2, 1, 1 };
            CollectionAssert.AreEqual(wait, res);
        }




        [TestMethod]
        public void TestAverage()
        {
            string[,] DataTabl =
           {
                {"ID","ФИО","Стаж","Номер авто","Марка авто","Расзод топлива","Пробег" },
                {"1","пкупу п упу пук","10","н589рп","мерс","15","10000" },
                {"2","ппекь пьзекь ппкепк","12","е758ав","мерс","16","12000" },
                {"3","пккеп пкепке епке","11","й456ек","лада","24","120000" },
                {"4","пекпекп кеп кепекп","5","Ф432АК","тоета","9","0" },
            };


            double res = ds.Average(DataTabl, 5);
            double wait = 16;
            Assert.AreEqual(res, wait);
        }
    }
}




