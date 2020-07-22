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
    class SkillsProfileSteps
    {
        ProfilePage profile = new ProfilePage();
        [Given(@"User clicks on Skills tab")]
        public void GivenUserClicksOnSkillsTab()
        {
            profile.ClickSkillsTab();
        }

        [When(@"Adds skill details")]
        public void WhenAddsSkillDetails()
        {
            profile.AddSkills();
        }

        [Then(@"Language should get added on the profile page")]
        public void ThenLanguageShouldGetAddedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualAddMessage = "Selenium has been added to your skills";
            Assert.AreEqual(expextedAddMessage, actualAddMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [When(@"Updates skill details")]
        public void WhenUpdatesSkillDetails()
        {
            profile.UpdateSkills();
        }

        [Then(@"Skill should get updated on the profile page")]
        public void ThenSkillShouldGetUpdatedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualAddMessage = "Java has been updated to your skills";
            Assert.AreEqual(expextedAddMessage, actualAddMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }
        [When(@"Clicks on skill delete icon")]
        public void WhenClicksOnSkillDeleteIcon()
        {
            profile.DeleteSkills();
        }


        [Then(@"Skill should get deleted on the profile page")]
        public void ThenSkillShouldGetDeletedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expectedDeletedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(expectedDeletedMessage.Contains(" has been deleted"));
        }

    }
}
