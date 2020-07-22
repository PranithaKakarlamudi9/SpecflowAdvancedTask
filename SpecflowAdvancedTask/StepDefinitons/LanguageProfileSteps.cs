using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Pages;
using SpecflowAdvancedTask.Global;
using TechTalk.SpecFlow;

namespace SpecflowAdvancedTask.StepDefinitons
{
    [Binding]
    class LanguageProfileSteps
    {
        ProfilePage profile = new ProfilePage();
        [Given(@"user clicks AddNew in Lnguage tab")]
        public void GivenUserClicksAddNewInLnguageTab()
        {
            profile.ClickAddNewLanguage();
        }

        [When(@"adds language details")]
        public void WhenAddsLanguageDetails()
        {
            profile.AddLanguage();
        }

        [Then(@"language should get added on the profile page")]
        public void ThenLanguageShouldGetAddedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "English has been added to your languages";
            Assert.AreEqual(expextedAddMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Given(@"user clicks edit icon in Lnguage tab")]
        public void GivenUserClicksEditIconInLnguageTab()
        {
            profile.EditLanguageBtn();
        }

        [When(@"updates language details")]
        public void WhenUpdatesLanguageDetails()
        {
            profile.UpdateLanguage();
        }

        [Then(@"language should get updated on the profile page")]
        public void ThenLanguageShouldGetUpdatedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Hindi has been updated to your languages";
            Assert.AreEqual(expextedAddMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Given(@"user clicks  delete icon in Lnguage tab")]
        public void GivenUserClicksDeleteIconInLnguageTab()
        {
            profile.DeleteLanguage();
        }

        [Then(@"language should get deleted on the profile page")]
        public void ThenLanguageShouldGetDeletedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expectedDeleteMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(expectedDeleteMessage.Contains(" has been deleted"));

        }

    }
}
