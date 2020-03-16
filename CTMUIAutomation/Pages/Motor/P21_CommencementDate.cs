using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P21_CommencementDate :BasePage
    {
        #region pageElements
        string btnDate_locator = "//td[contains(@class, 'valid')]/button[contains(text(), '";
        IWebElement btnDate { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='applicant.optInPrivacy.Y']/..")]
        IWebElement chkAcceptTerms { set; get; }  

        [FindsBy(How = How.Id, Using = "commencement_date.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P21_CommencementDate() : base()
        {
        }

        public P22_Results SelectCommencementDate(string date)
        {
            
            IWebElement elem;
            string[] args = date.Split(new char[] { '/', '-', ' ' });
            if (!(int.Parse(args[0]) == DateTime.Today.Day))
            {
                elem = FindElementByXpath(btnDate_locator + args[0] +"')]");
                elem.ClickFunction();
            }

            chkAcceptTerms.ClickFunction();

            btnNext.ClickFunction();
            return new P22_Results();
        }
    }
}
