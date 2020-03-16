using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P14_DriverEmployment : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.EMPLOYED_FULL_TIME']/..")]
        IWebElement lblEmployedFullTime { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.EMPLOYED_PART_TIME']/..")]
        IWebElement lblEmployedPartTime { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.SELF_EMPLOYED']/..")]
        IWebElement lblSelfEmployed { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.RETIRED']/..")]
        IWebElement lblRetired { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.STUDENT']/..")]
        IWebElement lblStudent { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.UNEMPLOYED']/..")]
        IWebElement lblUnemployed { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.employmentStatus.HOUSE_WIFE_OR_HUSBAND']/..")]
        IWebElement lblHomeDuties { set; get; }

        #endregion

        public P14_DriverEmployment() : base()
        {
        }

        public P15_DriverLicenceAge SelectEmployment(string employment)
        {
            switch (employment.Trim().ToLower())
            {
                case "employed full time":
                    lblEmployedFullTime.ClickFunction();
                    break;
                case "employed part time":
                    lblEmployedPartTime.ClickFunction();
                    break;
                case "self employed":
                    lblSelfEmployed.ClickFunction();
                    break;
                case "retired":
                    lblRetired.ClickFunction();
                    break;
                case "student":
                    lblStudent.ClickFunction();
                    break;
                case "unemployed":
                    lblUnemployed.ClickFunction();
                    break;
                case "home duties":
                    lblHomeDuties.ClickFunction();
                    break;
            }
            return new P15_DriverLicenceAge();
        }

    }
}
