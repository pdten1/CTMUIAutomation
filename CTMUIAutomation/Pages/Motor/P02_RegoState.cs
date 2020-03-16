using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P02_RegoState : BasePage
    {
        #region pageElements
        [FindsBy(How = How.Id, Using = "NSW")]
        IWebElement lblNSW { set; get; }

        [FindsBy(How = How.Id, Using = "VIC")]
        IWebElement lblVIC { set; get; }

        [FindsBy(How = How.Id, Using = "QLD")]
        IWebElement lblQLD { set; get; }

        [FindsBy(How = How.Id, Using = "WA")]
        IWebElement lblWA { set; get; }

        [FindsBy(How = How.Id, Using = "SA")]
        IWebElement lblSA { set; get; }

        [FindsBy(How = How.Id, Using = "NT")]
        IWebElement lblNT { set; get; }

        [FindsBy(How = How.Id, Using = "TAS")]
        IWebElement lblTAS { set; get; }
        #endregion

        public P02_RegoState() : base()
        {
        }

        public P03_CoverType SelectState(string state)
        {
            switch (state)
            {
                case "NSW":
                    lblNSW.ClickFunction();
                    break;
                case "VIC":
                    lblVIC.ClickFunction();
                    break;
                case "QLD":
                    lblQLD.ClickFunction();
                    break;
                case "WA":
                    lblWA.ClickFunction();
                    break;
                case "SA":
                    lblSA.ClickFunction();
                    break;
                case "TAS":
                    lblTAS.ClickFunction();
                    break;
                case "NT":
                    lblNT.ClickFunction();
                    break;
                default:
                    lblNSW.ClickFunction();
                    break;
            }
            return new P03_CoverType();
        }
    }
}
