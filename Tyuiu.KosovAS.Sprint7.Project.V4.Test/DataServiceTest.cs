using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KosovAS.Sprint7.Project.V4.Lib;

namespace Tyuiu.KosovAS.Sprint7.Project.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaleSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 4] {{ "Avtor1", "Book1", 2023, 500},
                                                    {"Avtor2", "Book2", 2022, 350}};

            object[,] dataWait = new object[2, 4] { { "Avtor2", "Book2", 2022, 350 },
                                                    { "Avtor1", "Book1", 2023, 500} };

            CollectionAssert.AreEqual(dataWait, ds.SaleSort(dataTest));
        }

        [TestMethod]
        public void ValidYearSort()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 4] {{ "Avtor1", "Book1", "2023", "100"},
                                                    {"Avtor2", "Book2", "2022", "350"}};

            object[,] dataWait = new object[2, 4] { { "Avtor2", "Book2", "2022", "350" },
                                                    { "Avtor1", "Book1", "2023", "100"} };

            CollectionAssert.AreEqual(dataWait, ds.YearSort(dataTest));
        }

        [TestMethod]
        public void ValidSearch()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[2, 3] {{"Avtor1", "Book1", "2023"},
                                                   {"Avtor2", "Book2", "2022"}};

            string[] dataWait = new string[3] { "Avtor2", "Book2", "2022" };

            CollectionAssert.AreEqual(dataWait, ds.Search(dataTest, "Avtor2"));
        }

        [TestMethod]
        public void ValidDataStatisticsSum()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtor1", "100"},
                                                   {"Avtor2", "200"},
                                                   {"Avtor3", "50"}};

            double dataWait = 350;

            string command = "sum";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMin()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtor1", "100"},
                                                   {"Avtor2", "200"},
                                                   {"Avtor3", "50"}};

            double dataWait = 50;

            string command = "min";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsMax()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtor1", "100"},
                                                   {"Avtor2", "200"},
                                                   {"Avtor3", "50"}};

            double dataWait = 200;

            string command = "max";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }

        [TestMethod]
        public void ValidDataStatisticsAvarage()
        {
            DataService ds = new DataService();

            object[,] dataTest = new object[3, 2] {{"Avtor1", "100"},
                                                   {"Avtor2", "200"},
                                                   {"Avtor3", "50"}};

            double dataWait = 116.67;

            string command = "avarage";
            int column = 1;

            Assert.AreEqual(dataWait, ds.DataStatistics(dataTest, command, column));
        }
    }
}
