using CTMUIAutomation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace CTMUIAutomation.Feature_Definitions
{
    [Binding]
    public sealed class ExtendedSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly QuoteContext _quoteContext;

        public ExtendedSteps(QuoteContext qContext)
        {
            _quoteContext = qContext;
        }

        [Then(@"the cover type selected is printed to the output")]
        public void ThenTheCoverTypeSelectedIsPrintedToTheOutput()
        {
            Console.WriteLine(_quoteContext._quote.CoverType);
        }


    }
}
