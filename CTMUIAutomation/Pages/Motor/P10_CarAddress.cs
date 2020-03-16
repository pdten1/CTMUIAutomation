using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P10_CarAddress : BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "helpers.overnightParkingPostcode")]
        IWebElement txtPostcode { set; get; }

        [FindsBy(How = How.Id, Using = "helpers.overnightParkingAddressLabel")]
        IWebElement txtAddress { set; get; }

        [FindsBy(How = How.Id, Using = "car_address.nextButton")]
        IWebElement btnNext { set; get; }
        #endregion

        public P10_CarAddress() : base()
        {
        }

        public P11_OvernightParking EnterPageData(string postcode, string address)
        {
            txtPostcode.EnterText(postcode.Trim());
            txtAddress.EnterText(address.Trim());
            Thread.Sleep(2000);
            txtAddress.EnterText(Keys.ArrowDown);
            txtAddress.EnterText(Keys.Return);

            btnNext.ClickFunction();

            return new P11_OvernightParking();
        }

    }
}
