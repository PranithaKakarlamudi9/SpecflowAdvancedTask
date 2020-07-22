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
    class EducationProfileSteps
    {
        ProfilePage profile = new ProfilePage();

        [Given(@"User clicks on Education tab")]
        public void GivenUserClicksOnEducationTab()
        {
            profile.CLickEducationTab();
        }

        [When(@"Adds Education details")]
        public void WhenAddsEducationDetails()
        {
            profile.AddEducation();
        }

        [Then(@"Education should get added on the profile page")]
        public void ThenEducationShouldGetAddedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Education has been added";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }

        [When(@"Updates Education details")]
        public void WhenUpdatesEducationDetails()
        {
            profile.UpdateEducation();
        }

        [Then(@"Education should get updated on the profile page")]
        public void ThenEducationShouldGetUpdatedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Education as been updated";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }

        [When(@"Clicks on delete icon")]
        public void WhenClicksOnDeleteIcon()
        {
            profile.DeleteEducation();
        }

        [Then(@"Education should get deleted on the profile page")]
        public void ThenEducationShouldGetDeletedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expectedDeleteMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Education entry successfully removed";
            Assert.AreEqual(expectedDeleteMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

    }
}
