using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P16_DriverClaims : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.anyPreviousClaims.YES']/..")]
        IWebElement lblYes { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.anyPreviousClaims.NO']/..")]
        IWebElement lblNo { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.anyPreviousClaims.UNSURE']/..")]
        IWebElement lblUnsure { set; get; }
        #endregion

        public P16_DriverClaims() : base()
        {
        }

        public P17_DriverNCD HasClaims(string value)
        {
            switch (value.Trim().ToLower())
            {
                case "yes":
                    lblYes.ClickFunction();
                    break;
                case "no":
                    lblNo.ClickFunction();
                    break;
                case "unsure":
                    lblUnsure.ClickFunction();
                    break;
            }

            return new P17_DriverNCD();
        }
    }
}
