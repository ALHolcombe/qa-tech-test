using EcsHomework.Helpers;
using EcsHomework.POMs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace EcsHomework.StepDefinitions
{
    [Binding]
    public sealed class RenderTheChallenge
    {
        private readonly ScenarioContext context;
        List<int> answers;

        public RenderTheChallenge(ScenarioContext injectedContext)
        {
            context = injectedContext;
        }

        [Given(@"I have the ECSDigital Engineer in Test tech test open")]
        public void GivenIHaveTheECSDigitalEngineerInTestTechTestOpen()
        {
            new BasicNav().NavigateToHomePage();
        }

        [When(@"I click the render challenge button")]
        public void WhenIClickTheRenderChallengeButton()
        {
            var homePage = new HomePage();

            homePage.GoToRender();
        }

        [Then(@"I'm taken to the Arrays Challenge page")]
        public void ThenIMTakenToTheArraysChallengePage()
        {
            var welcomePageTitle = new ArraysPage().GetPageName();

            Assert.AreEqual("Arrays Challenge", welcomePageTitle, "Cannot find Arrays Challenge page title");

        }

        [Given(@"I'm on the Arrays Challenge page")]
        public void GivenIMOnTheArraysChallengePage()
        {

            new BasicNav().NavigateToHomePage();
            var homePage = new HomePage();
            homePage.GoToRender();
            var homePageTitle = new ArraysPage().GetPageName();




        }

        [When(@"I calculate the pivot index for all rows")]
        public void WhenICalculateThePivotIndexForAllRows()
        {

            answers =  new ArraysPage().GetAnswers();

            //new ArraysPage().CompleteAnswers();
        }



        [Then(@"I can submit the answers under the name '(.*)'")]
        public void ThenICanSubmitTheAnswersUnderTheName(string userName)
        {
            var arraysPage = new ArraysPage();

            arraysPage.CompleteAnswers(answers, userName);

            arraysPage.SubmitAnswersButton.Click();

            Assert.AreEqual("Congratulations you have succeeded. Please submit your challenge ✅", arraysPage.SubmissionMessage.Text.ToString());

        }




    }
}

