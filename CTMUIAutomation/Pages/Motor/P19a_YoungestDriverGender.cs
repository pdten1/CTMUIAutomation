using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P19a_YoungestDriverGender :BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.youngestDriver.gender.MALE']/..")]
        IWebElement btnMale { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.youngestDriver.gender.FEMALE']/..")]
        IWebElement btnFemale { set; get; }
        #endregion

        public P19a_YoungestDriverGender() : base()
        {
        }

        public P19b_YoungestDriverAge SetYoungestDriverGender(string gender)
        {
            if (gender.Trim().ToLower() == "male")
            {
                btnMale.ClickFunction();
            }
            if (gender.Trim().ToLower() == "female")
            {
                btnFemale.ClickFunction();
            }

            return new P19b_YoungestDriverAge();
        }
    }
}
