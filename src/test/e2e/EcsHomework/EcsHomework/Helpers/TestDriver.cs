using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsHomework.Helpers
{
    class TestDriver
    {

        public static IWebDriver Driver = null;

        public void SetDriver()
        {
            // Add if running headless
            // var chromeOptions = new ChromeOptions();
            // chromeOptions.AddArguments("headless");

            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(3000);
        }


        public void QuitDriver()
        {

                Driver.Quit();
                Driver.Dispose();
            }


        }
    }

