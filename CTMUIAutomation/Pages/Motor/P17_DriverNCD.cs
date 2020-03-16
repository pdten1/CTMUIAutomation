using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P17_DriverNCD : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_1']/..")]
        IWebElement lblRating1 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_2']/..")]
        IWebElement lblRating2 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_3']/..")]
        IWebElement lblRating3 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_4']/..")]
        IWebElement lblRating4 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_5']/..")]
        IWebElement lblRating5 { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.driver.noClaimRating.RATING_6']/..")]
        IWebElement lblRating6 { set; get; }

        #endregion

        public P17_DriverNCD() : base()
        {
        }

        public P18_DriverOwnsAnotherCar SelectNCD(string employment)
        {
            switch (employment.Trim().ToLower())
            {
                case "rating 1":
                    lblRating1.ClickFunction();
                    break;
                case "rating 2":
                    lblRating2.ClickFunction();
                    break;
                case "rating 3":
                    lblRating3.ClickFunction();
                    break;
                case "rating 4":
                    lblRating4.ClickFunction();
                    break;
                case "rating 5":
                    lblRating5.ClickFunction();
                    break;
                case "rating 6":
                    lblRating6.ClickFunction();
                    break;
            }
            return new P18_DriverOwnsAnotherCar();
        }
    }
}
