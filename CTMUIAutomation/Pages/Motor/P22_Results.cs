using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P22_Results : BasePage
    {

        #region pageElements
        [FindsBy(How = How.XPath, Using = "//div[contains(@id, 'result-row')]")]
        IList <IWebElement> Quotes { set; get; }

        #endregion

        public P22_Results() : base()
        {
        }

        public void VerifyNumberOfResultsMoreThanOne()
        {
            Thread.Sleep(10000);
            int i = Quotes.Count;
            Assert.Greater(i, 0, "There were no results returned.");
            Console.WriteLine("The number of results displayed " + i.ToString());
        }

        public void VerifyPageOpened()
        {
            Assert.That(Library.driver.Url.Contains("results"), "The results page is not displayed. Something went wrong");
            Console.WriteLine("URL is " + Library.driver.Url.ToString());
        }

        public void VerifyCoverType()
        {
            
        }

    }
}
