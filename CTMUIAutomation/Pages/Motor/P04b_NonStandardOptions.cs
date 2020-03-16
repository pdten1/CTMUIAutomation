using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P04b_NonStandardOptions :BasePage
    {

        #region pageElements
        [FindsBy(How = How.XPath, Using = "//div[@role='combobox']/input")]
        IWebElement txtOptions { set; get; }


        [FindsBy(How = How.Id, Using = "non_standard_accessories.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P04b_NonStandardOptions() : base()
        {
        }

        public P05_Modifications EnterNonStandardOptions(string[] arr)
        {
            IWebElement elem1,elem2;

            if (arr.Length != 0)
            {
                foreach (string s in arr)
                {
                    txtOptions.EnterText(s.Trim());

                    elem2 = FindElementByXpath("//ul[@role='listbox']/li/div[contains(text(), '" + s.Trim() + "')] ");
                    elem2.ClickFunction();
                }
            }
            btnNext.ClickFunction();

            return new P05_Modifications();
        }

    }
}
