using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Pages
{
    public class P08b_GoodsPayment : BasePage
    {
        #region pageElements
        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.goodsPayment.Y']/..")]
        IWebElement btnYes { set; get; }

        [FindsBy(How = How.XPath, Using = "//input[@id='coverDetail.goodsPayment.N']/..")]
        IWebElement btnNo { set; get; }
        #endregion

        public P08b_GoodsPayment() : base()
        {
        }

        public P09_AnnualKM UsedForCarryGoods(string value)
        {
            if (value.Trim().ToLower() == "yes")
            {
                btnYes.ClickFunction();
            }

            if (value.Trim().ToLower() == "no")
            {
                btnNo.ClickFunction();
            }

            return new P09_AnnualKM();
        }
    }
}
