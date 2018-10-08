using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {

        public static string GetText( string element, PropertyType elementype)
        {
            if (elementype == PropertyType.Id)
                return PropertiesCollections._driver.FindElement(By.Id(element)).GetAttribute("value");
            if (elementype == PropertyType.Name)
                return PropertiesCollections._driver.FindElement(By.Name(element)).GetAttribute("value");
            else return String.Empty;
        }

        public static string GetTextDDL(string element, PropertyType elementype)
        {
            if (elementype == PropertyType.Id)
                return new SelectElement(PropertiesCollections._driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementype == PropertyType.Name)
                return new SelectElement(PropertiesCollections._driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else return String.Empty;
        }
    }
}
