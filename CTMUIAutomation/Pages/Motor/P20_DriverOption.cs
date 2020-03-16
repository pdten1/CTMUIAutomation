using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages.Motor
{
    public class P20_DriverOption : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driverOption.DRIVERS_21_AND_OVER']/..")]
        IWebElement lblOver21 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driverOption.DRIVERS_25_AND_OVER']/..")]
        IWebElement lblOver25 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driverOption.DRIVERS_30_AND_OVER']/..")]
        IWebElement lblOver30 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driverOption.NO_RESTRICTION']/..")]
        IWebElement lblNoRestrictions{ set; get; }
        #endregion

        public P20_DriverOption() : base()
        {
        }

        public P20_ApplicantDetails SelectDriverOption(string value)
        {
            switch (value.Trim().ToLower())
            {
                case "over 21":
                    lblOver21.ClickFunction();
                    break;
                case "over 25":
                    lblOver25.ClickFunction();
                    break;
                case "over 30":
                    lblOver30.ClickFunction();
                    break;
                case "no restrictions":
                    lblNoRestrictions.ClickFunction();
                    break;
            }
            return new P20_ApplicantDetails();
        }
    }
}
