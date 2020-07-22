using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Global;
using SeleniumAdvancedTask.Pages;
using SpecflowAdvancedTask.Global;
using TechTalk.SpecFlow;

namespace SpecflowAdvancedTask.StepDefinitons
{
    [Binding]
    class ManageListingsSteps
    {
        ProfilePage profile = new ProfilePage();
        ManageListingsPage listings = new ManageListingsPage();
        [Given(@"user navigates to Manage Listings page")]
        public void GivenUserNavigatesToManageListingsPage()
        {
            profile.ClickManageListings();
        }

        [When(@"user clicks on edit icon in Manage listings table")]
        public void WhenUserClicksOnEditIconInManageListingsTable()
        {
            listings.EditManageListings();
        }

        [Then(@"manage listing should get updated")]
        public void ThenManageListingShouldGetUpdated()
        {
            Base.driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
            String expextedTitle = "Seleinium with Java";
            String actualTitle =Base. driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(expextedTitle, actualTitle);
        }

        [When(@"user clicks on delete icon in Manage listings table")]
        public void WhenUserClicksOnDeleteIconInManageListingsTable()
        {
            listings.DeleteManageListing();
        }

        [Then(@"manage listing should get deleted")]
        public void ThenManageListingShouldGetDeleted()
        {
            Thread.Sleep(1000);
            String ExpectedDeleteConfirmation = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(ExpectedDeleteConfirmation.Contains(" has been deleted"));
        }

    }
}
