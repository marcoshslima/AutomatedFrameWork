using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
   public static class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);

            //if (elementype.ToUpper() == "ID")
            //    PropertiesCollections._driver.FindElement(By.Id(element)).SendKeys(value);
            //if (elementype.ToUpper() == "NAME")
            //    PropertiesCollections._driver.FindElement(By.Name(element)).SendKeys(value);
        }


        //Click On Element
        public static void Clicks(this IWebElement element)
        {
            element.Click();
            //if (elementype == PropertyType.Id)
            //    PropertiesCollections._driver.FindElement(By.Id(element)).Click();
            //if (elementype == PropertyType.Name)
            //    PropertiesCollections._driver.FindElement(By.Name(element)).Click();
        }

        //Select a drop down control
        public static void SelectDropDown(this IWebElement element,string value)
        {
            new SelectElement(element).SelectByText(value);
            //if (elementype == PropertyType.Id)
            //    new SelectElement(PropertiesCollections._driver.FindElement(By.Id(element))).SelectByText(value);
            //if (elementype == PropertyType.Name)
            //    new SelectElement(PropertiesCollections._driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
