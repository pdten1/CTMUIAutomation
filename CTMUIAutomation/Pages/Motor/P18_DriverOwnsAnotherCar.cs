using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
   public class P18_DriverOwnsAnotherCar :BasePage
    {

        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.ownsAnotherCar.Y']/..")]
        IWebElement lblYes { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.ownsAnotherCar.N']/..")]
        IWebElement lblNo { set; get; }
        #endregion

        public P18_DriverOwnsAnotherCar() : base()
        {
        }

        public P19_YoungestDriver HasAnotherCar(string value)
        {
            if(value.Trim().ToLower() == "yes")
            {
                lblYes.ClickFunction();
            }

            if (value.Trim().ToLower() == "no")
            {
                lblNo.ClickFunction();
            }


            return new P19_YoungestDriver();
        }
    }
}
