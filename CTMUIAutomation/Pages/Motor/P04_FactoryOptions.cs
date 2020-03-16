using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P04_FactoryOptions : BasePage
    {

        #region pageElements
        string btnYES_Locator = "//input[@id='coverDetail.vehicle.hasOtherAccessories.YES']/..";
        string btnNo_Locator = "//input[@id='coverDetail.vehicle.hasOtherAccessories.NO']/..";
        string btnUnsure_Locator = "//input[@id='coverDetail.vehicle.hasOtherAccessories.UNSURE']/..";

        IWebElement elem;
        #endregion

        public P04_FactoryOptions() : base()
        {
        }

        public void EnterPageData(string value)
        {
            if(!string.IsNullOrEmpty(value.Trim()))
            {
                switch (value.Trim().ToLower())
                {
                    case "yes":
                        // elem = UnitTest1.driver.FindElement(By.XPath(btnYES_Locator));
                        elem = FindElementByXpath(btnYES_Locator);
                        elem.ClickFunction();
                        break;
                    case "no":
                        elem = FindElementByXpath(btnNo_Locator);
                        elem.ClickFunction();
                        break;
                    case "unsure":
                        elem = FindElementByXpath(btnUnsure_Locator);
                        elem.ClickFunction();
                        break;
                }
            }
        }
    }
}
