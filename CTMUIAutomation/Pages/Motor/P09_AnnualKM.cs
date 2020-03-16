using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P09_AnnualKM :BasePage
    {

        #region pageElements
        [FindsBy(How = How.Id, Using = "coverDetail.annualKilometres")]
        IWebElement txtOptions { set; get; }


        [FindsBy(How = How.Id, Using = "annual_kms.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P09_AnnualKM() : base()
        {
        }

        public P10_CarAddress EnterPageData(string kms)
        {
            txtOptions.EnterText(kms.Trim());
            btnNext.ClickFunction();

            return new P10_CarAddress();
        }

    }
}
