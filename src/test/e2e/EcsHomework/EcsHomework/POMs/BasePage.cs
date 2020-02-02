using EcsHomework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsHomework.POMs
{
    public class BasePage
    {

        public IWebDriver Driver = TestDriver.Driver;
        public WebDriverWait Wait = new WebDriverWait(TestDriver.Driver, TimeSpan.FromSeconds(30));

        public BasePage()
        {
            Wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException), typeof(StaleElementReferenceException));
        }
    }
}
