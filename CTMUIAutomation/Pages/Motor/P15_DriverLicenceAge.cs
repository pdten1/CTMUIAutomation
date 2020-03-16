using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P15_DriverLicenceAge :BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "coverDetail.driver.licenceAge")]
        IWebElement txtLicenceAge { set; get; }

        [FindsBy(How = How.Id, Using = "regular_driver_licence_age.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P15_DriverLicenceAge() : base()
        {
        }

        public P16_DriverClaims EnterLicenceAge(string age)
        {
            txtLicenceAge.EnterText(age);

            btnNext.ClickFunction();
            return new P16_DriverClaims();
        }
    }
}
