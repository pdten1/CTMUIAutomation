using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTMUIAutomation.Context
{
    public class QuoteContext
    {

        public Quote _quote;

        public QuoteContext()
        {
            _quote = new Quote();
        }
    }
}
