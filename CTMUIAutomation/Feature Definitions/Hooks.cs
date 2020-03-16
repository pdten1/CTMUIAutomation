using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CTMUIAutomation.Feature_Definitions
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeScenario]
        public void BeforeTestRun()
        {
            //TODO: implement logic that has to run before executing each scenario
            Console.WriteLine("\t Navigating to url");
            Library.driver = new ChromeDriver();
            Library.driver.Manage().Window.Maximize();
            Library.driver.Navigate().GoToUrl(Library.GetAppSettingValue("URL"));
        }

        //[AfterTestRun]
        //public static void AfterTestRun()
        //{
        //    //TODO: implement logic that has to run after executing each scenario
        //    Library.driver.Close();
        //}

        [AfterScenario]
        public void AfterScenario()
        {
            Library.driver.Dispose();
        }
    }
}
