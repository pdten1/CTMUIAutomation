using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    class P01_StartPage : BasePage
    {

        #region pageElements
        [FindsBy(How = How.Id, Using = "helpers.regoLabel")]
        IWebElement txtRego { set; get; }

        [FindsBy(How = How.Id, Using = "start.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P01_StartPage(): base()
        {
        }

        public P02_RegoState EnterPageData(string regoNumber)
        {
            if(!string.IsNullOrEmpty(regoNumber.Trim()))
            {
                txtRego.EnterText(regoNumber.Trim());
            }

            btnNext.ClickFunction();

            return new P02_RegoState();
        }

    }
}
