using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class LoginPageObjects
    {

        public LoginPageObjects()
        {
            PageFactory.InitElements(PropertiesCollections._driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUser { get; set; }

        [FindsBy(How = How.Name,Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name,Using = "Login")]
        public IWebElement btnLogin { get; set; }


        public EAPageObjects Login(string userName, string password)
        {
            txtUser.SendKeys(userName);
            txtPassword.SendKeys(password);
            btnLogin.Submit();
            Thread.Sleep(4000);

            return new EAPageObjects();
        }

    }
}
