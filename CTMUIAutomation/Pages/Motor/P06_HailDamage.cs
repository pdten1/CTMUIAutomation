using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P06_HailDamage : BasePage
    {
        #region pageElements
        string btnYES_Locator = "//input[@id='coverDetail.vehicle.damaged.Y']/..";
        string btnNo_Locator = "//input[@id='coverDetail.vehicle.damaged.N']/..";

        #endregion

        public P06_HailDamage() : base()
        {
        }

        public P07_Finance HasHailDamage(string value)
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

            return new P07_Finance();
        }
    }
}
