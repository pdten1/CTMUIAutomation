using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P08a_PassengerPayment :BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.passengersPayment.Y']/..")]
        IWebElement btnYes { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.passengersPayment.N']/..")]
        IWebElement btnNo { set; get; }
        #endregion

        public P08a_PassengerPayment() : base()
        {
        }

        public P08b_GoodsPayment UsedForCarryPassengers(string value)
        {
            if (value.Trim().ToLower() == "yes")
            {
                btnYes.ClickFunction();
            }

            if (value.Trim().ToLower() == "no")
            {
                btnNo.ClickFunction();
            }

            return new P08b_GoodsPayment();
        }
    }
}
