using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvancedTask.Pages;
using SpecflowAdvancedTask.Global;
using TechTalk.SpecFlow;
using ExpectedConditions = SeleniumExtras.WaitHelpers.ExpectedConditions;

namespace SpecflowAdvancedTask.StepDefinitons
{
    [Binding]
    class SearchSkillSteps
    {
        Common common = new Common();
        [Given(@"User enters category in search textbox to search")]
        public void GivenUserEntersCategoryInSearchTextboxToSearch()
        {
            common.SearchSkillByCategory();
        }

        [Then(@"Search result should get displayed")]
        public void ThenSearchResultShouldGetDisplayed()
        {
            int result = common.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }
        }

        [Given(@"User enters sub category in search textbox to search")]
        public void GivenUserEntersSubCategoryInSearchTextboxToSearch()
        {
            common.SearchSkillBySubCategory();
        }

        

        [Given(@"User is in search result page")]
        public void GivenUserIsInSearchResultPage()
        {
            common.ClickOnSearchIcon();
            WebDriverWait wait = new WebDriverWait(Base.driver, TimeSpan.FromSeconds(100));
            wait.Until(ExpectedConditions.UrlToBe("http://192.168.99.100:5000/Home/Search?searchString="));
            String actualTitle = Base.driver.Url;
            String expectedTitle = "http://192.168.99.100:5000/Home/Search?searchString=";
            Assert.AreEqual(actualTitle, expectedTitle);
        }

     
        [Given(@"User enters filter in search textbox to search")]
        public void GivenUserEntersFilterInSearchTextboxToSearch()
        {
            common.SearchByFilterType();
        }


    }
}
