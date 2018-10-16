using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public static class SeleniumGetMethods
    {

        public static string GetText(this IWebElement element)
        {

            return element.GetAttribute("value");

            //if (elementype == propertytype.id)
            //    return propertiescollections._driver.findelement(by.id(element)).getattribute("value");
            //if (elementype == propertytype.name)
            //    return propertiescollections._driver.findelement(by.name(element)).getattribute("value");
            //else return string.empty;
        }

        public static string GetTextDDL(this IWebElement element)
        {
            return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;
                
            //if (elementype == PropertyType.Id)
            //    return new SelectElement(PropertiesCollections._driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            //if (elementype == PropertyType.Name)
            //    return new SelectElement(PropertiesCollections._driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            //else return String.Empty;

        }
    }
}
