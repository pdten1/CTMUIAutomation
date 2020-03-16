using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P07_Finance :BasePage
    {

        #region pageElements
        string btnYesFinance_Locator = "//input[@id='coverDetail.financeType.FINANCE_HIRE_PURCHASE']/..";
        string btnYesLease_Locator = "//input[@id='coverDetail.financeType.LEASE']/..";
        string btnNo_Locator = "//input[@id='coverDetail.financeType.NONE']/..";

        IWebElement elem;
        #endregion

        public P07_Finance() : base()
        {
        }

        public P08_UseType EnterPageData(string value)
        {
            if (!string.IsNullOrEmpty(value.Trim()))
            {
                switch (value.Trim().ToLower())
                {
                    case "finance":
                        elem = FindElementByXpath(btnYesFinance_Locator);
                        elem.ClickFunction();
                        break;
                    case "lease":
                        elem = FindElementByXpath(btnYesLease_Locator);
                        elem.ClickFunction();
                        break;
                    case "no":
                        elem = FindElementByXpath(btnNo_Locator);
                        elem.ClickFunction();
                        break;
                }
            }
            return new P08_UseType();
        }
    }
}
