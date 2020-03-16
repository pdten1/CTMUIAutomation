using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P19c_YoungestDriverLicenceAge :BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "coverDetail.youngestDriver.licenceAge")]
        IWebElement txtLicenceAge { set; get; }

        [FindsBy(How = How.Id, Using = "youngest_driver_licence_age.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P19c_YoungestDriverLicenceAge() : base()
        {
        }

        public P20_ApplicantDetails EnterLicenceAge(string age)
        {
            txtLicenceAge.EnterText(age);

            btnNext.ClickFunction();
            return new P20_ApplicantDetails();
        }

    }
}
