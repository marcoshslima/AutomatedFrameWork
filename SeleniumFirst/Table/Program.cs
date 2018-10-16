using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class Program
    {

        public Program()
        {

            Base._driver = new ChromeDriver();
            Base._driver.Navigate().GoToUrl("https://money.rediff.com/gainers/bse/daily/groupall");
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            TablePage tablePage = new TablePage();

            Utilities.ReadTable(tablePage.tblTable);

        }
    }
}
