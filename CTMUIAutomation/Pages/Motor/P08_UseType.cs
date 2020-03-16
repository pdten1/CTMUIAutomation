using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P08_UseType :BasePage
    {
        #region pageElements
        
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.useType.PRIVATE_AND_COMMUTING_TO_WORK']/..")]
        IWebElement btnPrivate { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.useType.PRIVATE_OCCASIONAL_BUSINESS']/..")]
        IWebElement btnPrivateAndSomeBusiness { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.useType.PRIVATE_BUSINESS']/..")]
        IWebElement btnPrivateAndBusiness { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.useType.BUSINESS_ONLY']/..")]
        IWebElement btnBusiness { set; get; }
        #endregion

        public P08_UseType() : base()
        {
        }

        public void EnterPageData(string value)
        {
            switch (value.Trim().ToLower())
            {
                case "private":
                    // elem = FindElementByXpath(btnYesFinance_Locator);
                    btnPrivate.ClickFunction();
                    break;
                case "private and occasional business":
                    //elem = FindElementByXpath(btnYesLease_Locator);
                   btnPrivateAndSomeBusiness.ClickFunction();
                    break;
                case "private and business":
                   // elem = FindElementByXpath(btnNo_Locator);
                   btnPrivateAndBusiness.ClickFunction();
                    break;
                case "business":
                   // elem = FindElementByXpath(btnNo_Locator);
                   btnBusiness.ClickFunction();
                    break;
            }

        }

    }
}
