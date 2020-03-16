using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation
{
    public static class ElementExtensions
    {
        public static void EnterText(this IWebElement element, string value)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            if (!string.IsNullOrEmpty(value))
            {
                element.Clear();
                element.SendKeys(value);
            }
        }


        /// <summary>
        /// This function  gets the Text value from an control
        /// </summary>
        /// <param name="element"></param>
        /// <returns>Returns the text value from the element</returns>
        public static string GetText(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            return element.Text;
        }

        /*
         * This function is to select a value from drop down list
        **/
        public static void DDLSelectItem(this IWebElement element, string value)
        {
            //WebDriverWait wait = new WebDriverWait(UnitTest1.driver, TimeSpan.FromSeconds(15));
            //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(element));

            if (!string.IsNullOrEmpty(value))
            {
                new SelectElement(element).SelectByText(value);
            }
        }


        /*
         * This function is to get the selected value from a drop down list
        **/
        public static string DDLGetSelectedValue(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(element));
            return new SelectElement(element).SelectedOption.GetAttribute("value");
        }

        /*
         * This function is to click on the element being passed.
         * Before the element is clicked it will wait for the element to be clickable.
         * If  not clickable an exception will be thrown
        **/
        public static void ClickFunction(this IWebElement element)
        {
            WebDriverWait wait = new WebDriverWait(Library.driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
            element.Click();
        }
    }
}
