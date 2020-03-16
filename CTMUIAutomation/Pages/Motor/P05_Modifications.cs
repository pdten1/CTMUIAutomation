using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P05_Modifications : BasePage
    {
        #region pageElements
        string btnYES_Locator = "//input[@id='coverDetail.vehicle.modified.Y']/..";
        string btnNo_Locator = "//input[@id='coverDetail.vehicle.modified.N']/..";

        #endregion

        public P05_Modifications() : base()
        {
        }

        public P06_HailDamage HasModifications(string value)
        {
            IWebElement elem;
            if (!string.IsNullOrEmpty(value))
            {
                if (value.Trim().ToLower() == "yes")
                {
                    elem = FindElementByXpath(btnYES_Locator);
                    elem.ClickFunction();
                }

                if (value.Trim().ToLower() == "no")
                {
                    elem = FindElementByXpath(btnNo_Locator);
                    elem.ClickFunction();
                }
            }

            return new P06_HailDamage();
        }


    }
}
