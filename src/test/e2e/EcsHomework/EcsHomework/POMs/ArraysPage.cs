using EcsHomework.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace EcsHomework.POMs
{
   public class ArraysPage : BasePage
    {
       public IWebElement SubmitAnswersButton => Driver.FindElements(By.TagName("button")).Single(b => b.Text.Equals("SUBMIT ANSWERS"));
        IWebElement PageName => Driver.FindElement(By.Id("challenge")).FindElement(By.TagName("h1"));
        IWebElement ArrayChallengeTable => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div[1]/div/div[2]/table"));
        IWebElement AnswerRowOne => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div[2]/div/div[1]/div[1]/input"));
        IWebElement AnswerRowTwo => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div[2]/div/div[1]/div[2]/input"));
        IWebElement AnswerRowThree => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div[2]/div/div[1]/div[3]/input"));
        IWebElement AnswerRowName => Driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div[2]/div/div[1]/div[4]/input"));
        public IWebElement SubmissionMessage => Driver.FindElement(By.XPath("/html/body/div[2]/div/div[1]/div/div/div[1]"));


        public string GetPageName()
        {
            return PageName.Text;
        }

        //        public List<int> GetRows(int rowItemRequired)

        public List<int> GetAnswers()
        {

            List<int> answers = new List<int>();

            // Fetch all Row of the table
            List<IWebElement> lstTrElem = new List<IWebElement>(ArrayChallengeTable.FindElements(By.TagName("tr")));
            List<int> rowArray = new List<int>();

            // Traverse each row
            foreach (var elemTr in lstTrElem)
            {
              
                // Fetch the columns from a particuler row
                List<IWebElement> lstTdElem = new List<IWebElement>(elemTr.FindElements(By.TagName("td")));
                if (lstTdElem.Count > 0)
                {
                    rowArray.Clear();
                    // Traverse each column
                    foreach (var elemTd in lstTdElem)
                    {
                       
                        
                        rowArray.Add(Convert.ToInt32(elemTd.Text));

                    }

                    answers.Add(new DataTools().PivotIndex(rowArray.ToArray()));



                }

            }

            return answers;

        }

        public void CompleteAnswers(List<int> answers, string userName)
        {

            AnswerRowOne.SendKeys(answers[0].ToString());
            AnswerRowTwo.SendKeys(answers[1].ToString());

            AnswerRowThree.SendKeys(answers[2].ToString());

            AnswerRowName.SendKeys(userName);


        }


    }
    }

