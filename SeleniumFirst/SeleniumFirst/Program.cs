using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {

        public static void Main() { }

        [SetUp]
        public void Initialize()
        {
            PropertiesCollections._driver = new ChromeDriver();
            PropertiesCollections._driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            LoginPageObjects pageLogin = new LoginPageObjects();
            EAPageObjects eaPage = pageLogin.Login("admin", "1234");
            eaPage.FillFormUser("Teste", "Marcos", "Lima");


            ////select
            //seleniumsetmethods.selectdropdown( "titleid", propertytype.id,"mr.");
            //console.writeline("the value from my title is " + seleniumgetmethods.gettextddl("titleid", propertytype.id));

            //thread.sleep(1000);

            ////enter text
            //seleniumsetmethods.entertext("initial", "execution", "name");
            //console.writeline("the value from my title is " + seleniumgetmethods.gettext("initial",propertytype.name));
            //thread.sleep(1000);

            ////click
            //seleniumsetmethods.click( "save", propertytype.name);
            //thread.sleep(5000);

        }


        [TearDown]
        public void CleanUp()
        {
            PropertiesCollections._driver.Close();
            Console.WriteLine("Closed Browser");
        }
    }
}
