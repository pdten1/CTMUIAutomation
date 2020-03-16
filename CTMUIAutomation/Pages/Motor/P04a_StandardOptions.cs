using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P04a_StandardOptions :BasePage
    {

        #region pageElements
        [FindsBy(How = How.Id, Using = "standard_options.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P04a_StandardOptions() : base()
        {
        }

        public P04b_NonStandardOptions SelectStandardOptions(string [] arr)
        {
            foreach(string s in arr)
            {
                IWebElement elem = FindElementByXpath("//span[contains(text(), '" + s.Trim() + "')]");
                elem.ClickFunction();
            }

            btnNext.ClickFunction();

            return new P04b_NonStandardOptions();

        }
    }
}
