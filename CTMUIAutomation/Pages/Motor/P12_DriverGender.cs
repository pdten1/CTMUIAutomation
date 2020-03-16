using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P12_DriverGender : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.gender.MALE']/..")]
        IWebElement btnMale { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.gender.FEMALE']/..")]
        IWebElement btnFemale { set; get; }
        #endregion

        public P12_DriverGender() : base()
        {
        }

        public P13_DriverDOB SetDriverGender(string gender)
        {
            if (gender.Trim().ToLower() == "male")
            {
                btnMale.ClickFunction();
            }
            if (gender.Trim().ToLower() == "female")
            {
                btnFemale.ClickFunction();
            }

            return new P13_DriverDOB();
        }
    }
}
