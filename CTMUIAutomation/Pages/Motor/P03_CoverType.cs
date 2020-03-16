using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public  class P03_CoverType :BasePage
    {

        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.coverType.COMPREHENSIVE']/..")]
        IWebElement btnComprehensive { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.coverType.TPFT")]
        IWebElement btnTPFT { set; get; }

        [FindsBy(How = How.Id, Using = "coverDetail.coverType.TPPD")]
        IWebElement btnTPPD { set; get; }
        #endregion

        public P03_CoverType() : base()
        {
        }

        public P04_FactoryOptions SelectCoverType(string coverType)
        {
            switch (coverType.Trim().ToLower())
            {
                case "comprehensive":
                    btnComprehensive.ClickFunction();
                    break;
                case "tppd":
                    btnTPPD.ClickFunction();
                    break;
                case "tpft":
                    btnTPFT.ClickFunction();
                    break;
                default:
                    btnComprehensive.ClickFunction();
                    break;
            }
            return new P04_FactoryOptions();
        }
    }
}
