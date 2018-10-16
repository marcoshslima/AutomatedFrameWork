using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
   public  class TablePage
    {

        public TablePage()
        {
            PageFactory.InitElements(Base._driver, this);

        }

        [FindsBy(How=How.ClassName , Using = "dataTable")]
        public IWebElement tblTable { get; set; }
    }
}
