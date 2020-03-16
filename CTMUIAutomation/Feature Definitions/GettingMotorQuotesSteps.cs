using CTMUIAutomation.Context;
using System;
using TechTalk.SpecFlow;

namespace CTMUIAutomation.Feature_Definitions
{
    [Binding]
    public class GettingMotorQuotesSteps
    {
        MotorInsuranceBase motorBase = new MotorInsuranceBase();
        private readonly QuoteContext _quoteContext;

        public GettingMotorQuotesSteps(QuoteContext qContext)
        {
            _quoteContext = qContext;
        }

        [Given(@"I navigate to the Compare the Market website and start a Motor quote")]
        public void GivenINavigateToTheCompareTheMarketWebsiteAndStartAMotorQuote()
        {
            motorBase.StartMotorQuote();
        }
        
        [When(@"I enter the details of the quote inculding (.*), (.*), (.*), (.*) and navigate through the screens")]
        public void WhenIEnterTheDetailsOfTheQuoteInculdingComprehensiveYesBusinessYesAndNavigateThroughTheScreens(
            string CoverType, string FactoryOptions, string HowCarUsed, string HasYoungerDriver)
        {
            _quoteContext._quote.CoverType = CoverType;
            motorBase.CompleteMotorQuotes(CoverType, FactoryOptions, HowCarUsed, HasYoungerDriver);
        }
        
        [Then(@"I can verify that the results page is displayed")]
        public void ThenICanVerifyThatTheResultsPageIsDisplayed()
        {
            motorBase.results.VerifyPageOpened();
        }
        
        [Then(@"I can verify that at least (.*) quote result is displayed")]
        public void ThenICanVerifyThatAtLeastQuoteResultIsDisplayed(int p0)
        {
            motorBase.results.VerifyNumberOfResultsMoreThanOne();
        }
    }
}
