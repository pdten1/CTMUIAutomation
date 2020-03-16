using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P13_DriverDOB :BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "coverDetail.driver.dob_day")]
        IWebElement ddlDay { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.driver.dob_month")]
        IWebElement ddlMonth { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.driver.dob_year")]
        IWebElement ddlYear { set; get; }

        [FindsBy(How = How.Id, Using = "regular_driver_dob.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P13_DriverDOB() : base()
        {
        }

        public P14_DriverEmployment EnterDriverDOB(string date)
        {
            string[] args = date.Split(new char[] { '/' , '-', ' '});

            ddlDay.DDLSelectItem(args[0].Trim());
            ddlMonth.DDLSelectItem(args[1].Trim());
            ddlYear.DDLSelectItem(args[2].Trim());

            btnNext.ClickFunction();
            
            return new P14_DriverEmployment();
        }
    }
}
