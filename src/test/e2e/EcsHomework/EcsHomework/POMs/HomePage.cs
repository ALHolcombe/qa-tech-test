using EcsHomework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace EcsHomework.POMs
{
    class HomePage : BasePage
    {


        IWebElement RenderTheChallengeButton => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[1]/div/div/button"));
        
        public void WelcomePage()
        {
            Wait.Until(x => RenderTheChallengeButton.Displayed && RenderTheChallengeButton.Enabled);
        }

        public ArraysPage GoToRender()
        {
            RenderTheChallengeButton.Click();
            return new ArraysPage();
        }

    }
}
