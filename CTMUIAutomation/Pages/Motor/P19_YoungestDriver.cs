using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P19_YoungestDriver : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.hasYoungerDriver.Y']/..")]
        IWebElement lblYes { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.hasYoungerDriver.N']/..")]
        IWebElement lblNo { set; get; }
        #endregion

        public P19_YoungestDriver() : base()
        {
        }

        public void SetyoungestDriver(string value)
        {
            if (value.Trim().ToLower() == "yes")
            {
                lblYes.ClickFunction();
            }

            if (value.Trim().ToLower() == "no")
            {
                lblNo.ClickFunction();
            }
        }
    }
}
