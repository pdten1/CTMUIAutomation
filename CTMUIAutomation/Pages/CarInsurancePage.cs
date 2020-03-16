using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class CarInsurancePage : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//a[contains(text(), 'Compare Now')]")]
        IWebElement btnCompare { set; get; }
        #endregion

        public CarInsurancePage() : base()
        {
        }

        public void StartCarQuote()
        {
            btnCompare.ClickFunction();
        }
    }
}
