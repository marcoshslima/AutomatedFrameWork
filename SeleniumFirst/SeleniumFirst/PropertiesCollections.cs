using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{

    enum PropertyType
    {
       
        Id,
        Name,
        ClassName,
        CssName


    }
    class PropertiesCollections
    {

        // Auto Implemented Properties

        public static IWebDriver _driver { get; set; }
    }
}
