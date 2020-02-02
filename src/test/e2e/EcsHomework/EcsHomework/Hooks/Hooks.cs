using EcsHomework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using System.Collections.ObjectModel;


namespace EcsHomework.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

       [BeforeTestRun]
       public static void StartDocker()
        {
            DockerSetup.StartDocker();

        }


        [BeforeScenario]
        public void BeforeScenario()
        {
            new TestDriver().SetDriver();
        }
        
    
        [AfterScenario]
        public void AfterScenario()
        {
          new TestDriver().QuitDriver();
        }

        [AfterTestRun]
        public static void StopDocker()
        {
            DockerSetup.StopDocker();

        }
       
    }
}
