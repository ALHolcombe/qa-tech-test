using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsHomework.Helpers
{
    class BasicNav
    {

        private IWebDriver driver = TestDriver.Driver;

        private readonly string _baseUrl = "http://localhost:3000/"; // I would defintely swithc this out to config manager in real life. 

        public void NavigateToHomePage()
        {
            driver.Navigate().GoToUrl(_baseUrl);
        }

    }
}
