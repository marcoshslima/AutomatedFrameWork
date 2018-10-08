using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        //Enter Text
        public static void EnterText(string element, string value, string elementype)
        {

            if (elementype.ToUpper() == "ID")
                PropertiesCollections._driver.FindElement(By.Id(element)).SendKeys(value);
            if (elementype.ToUpper() == "NAME")
                PropertiesCollections._driver.FindElement(By.Name(element)).SendKeys(value);
        }


        //Click On Element
        public static void Click(string element, PropertyType elementype)
        {
            if (elementype == PropertyType.Id)
                PropertiesCollections._driver.FindElement(By.Id(element)).Click();
            if (elementype == PropertyType.Name)
                PropertiesCollections._driver.FindElement(By.Name(element)).Click();
        }

        //Select a drop down control
        public static void SelectDropDown(string element, PropertyType elementype,string value)
        {
            if (elementype == PropertyType.Id)
                new SelectElement(PropertiesCollections._driver.FindElement(By.Id(element))).SelectByText(value);
            if (elementype == PropertyType.Name)
                new SelectElement(PropertiesCollections._driver.FindElement(By.Name(element))).SelectByText(value);
        }
    }
}
