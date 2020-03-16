using CTMUIAutomation.Extensions;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P19b_YoungestDriverAge : BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "coverDetail.youngestDriver.dob_day")]
        IWebElement ddlDay { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.youngestDriver.dob_month")]
        IWebElement ddlMonth { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.youngestDriver.dob_year")]
        IWebElement ddlYear { set; get; }

        [FindsBy(How = How.Id, Using = "youngest_driver_dob.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P19b_YoungestDriverAge() :base()
        {
        }

        public P19c_YoungestDriverLicenceAge EnterYoungestDriverDOB(string date)
        {
            string[] args = date.Split(new char[] { '/', '-', ' ' });

            ddlDay.DDLSelectItem(args[0].Trim());
            ddlMonth.DDLSelectItem(args[1].FirstCharToUpper());
            ddlYear.DDLSelectItem(args[2].Trim());
            
            btnNext.ClickFunction();

            return new P19c_YoungestDriverLicenceAge();
        }
    }
}
