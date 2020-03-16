using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class BasePage
    {
        public BasePage()
        {
            PageFactory.InitElements(Library.driver, this);
        }

        public IWebElement FindElementByXpath(string xpath)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15)); //Timeout time of 45 secs
            IWebElement elem = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(xpath)));
            return elem;
        }

        public IWebElement FindElementByID(string id)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15)); //Timeout time of 45 secs
            IWebElement elem = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(id)));
            return elem;
        }
    }
}
