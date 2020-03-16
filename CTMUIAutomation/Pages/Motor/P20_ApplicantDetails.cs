using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P20_ApplicantDetails : BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "applicant.firstName")]
        IWebElement txtFirstName { set; get; }

        [FindsBy(How = How.Id, Using = "applicant.lastName")]
        IWebElement txtLastName { set; get; }

        [FindsBy(How = How.Id, Using = "applicant.mobile")]
        IWebElement txtMobile { set; get; }

        [FindsBy(How = How.Id, Using = "applicant.email")]
        IWebElement txtEmail { set; get; }

        [FindsBy(How = How.Id, Using = "applicant_details.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P20_ApplicantDetails() : base()
        {
        }

        public P21_CommencementDate EnterApplicantDetails(string firstName, string lastName, string mobile, string email)
        {
            txtFirstName.EnterText(firstName);
            txtLastName.EnterText(lastName);
            txtMobile.EnterText(mobile);
            txtEmail.EnterText(email);

            btnNext.ClickFunction();

            return new P21_CommencementDate();
        }
    }
}
