using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class CTMLandingPage :BasePage
    {

        #region pageElements
        [FindsBy(How = How.XPath, Using = "//select[@name='vertical_selection']")]
        IWebElement ddlSelection { set; get; }

        #endregion
        public CTMLandingPage() : base()
        {
        }

        public void SelectProductToCompare(string value)
        {
            ddlSelection.DDLSelectItem(value);
        }

    }
}
