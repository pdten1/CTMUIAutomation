using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P11_OvernightParking :BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.GARAGED']/..")]
        IWebElement lblGarage { set; get; }
        
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.CAR_PARK']/..")]
        IWebElement lblCarPark { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.STREET']/..")]
        IWebElement lblStreet { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.PARKING_LOT']/..")]
        IWebElement lblParkingLot { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.DRIVEWAY']/..")]
        IWebElement lblDriveway { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.LOCKED_COMPOUND']/..")]
        IWebElement lblLockedCompound { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.ON_PRIVATE_PROPERTY']/..")]
        IWebElement lblPrivateProperty { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.overnightParking.parkingType.CAR_PORT']/..")]
        IWebElement lblCarport { set; get; }
        #endregion

        public P11_OvernightParking() : base()
        {
        }

        public P12_DriverGender SelectCarParked(string carParked)
        {
            switch (carParked.Trim().ToLower())
            {
                case "garage":
                    lblGarage.ClickFunction();
                    break;
                case "car park":
                    lblCarPark.ClickFunction();
                    break;
                case "street":
                    lblStreet.ClickFunction();
                    break;
                case "parking lot":
                    lblParkingLot.ClickFunction();
                    break;
                case "driveway":
                    lblDriveway.ClickFunction();
                    break;
                case "locked compound":
                    lblLockedCompound.ClickFunction();
                    break;
                case "private property":
                    lblPrivateProperty.ClickFunction();
                    break;
                case "carport":
                    lblCarport.ClickFunction();
                    break;
            }
            return new P12_DriverGender();
        }
    }
}
