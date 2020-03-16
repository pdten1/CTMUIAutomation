using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace CTMUIAutomation
{
    public class Library
    {
        public static IWebDriver driver { get; set; }

        public static string GetAppSettingValue(string key)
        {
            string appSettingVal = "";
            try
            {
                appSettingVal = ConfigurationManager.AppSettings.Get(key);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occurred at GetAppSettingValue function: " + e.Message);
            }
            return appSettingVal;
        }

    }
}
