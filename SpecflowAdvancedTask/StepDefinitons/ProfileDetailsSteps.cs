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
    class ProfileDetailsSteps
    {
        ProfilePage profile = new ProfilePage();
        [Given(@"user clicks on availability")]
        public void GivenUserClicksOnAvailability()
        {
            profile.ClickAvailability();
        }

        [When(@"user selects availabity from dropdown")]
        public void WhenUserSelectsAvailabityFromDropdown()
        {
            profile.AddAvailability();
        }

        [Then(@"availability is successfully saved")]
        public void ThenAvailabilityIsSuccessfullySaved()
        {
                      
            String AvailabilityText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Availability")), AvailabilityText);
        }

        [When(@"user updates availability")]
        public void WhenUserUpdatesAvailability()
        {
            profile.UpdateAvailability();
        }

        [Then(@"availability is successfully updated")]
        public void ThenAvailabilityIsSuccessfullyUpdated()
        {
            Thread.Sleep(1000);
            String expextedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Availability updated";
            Assert.AreEqual(expextedMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Given(@"user clicks on Hours")]
        public void GivenUserClicksOnHours()
        {
            profile.ClickHours();
        }

        [When(@"user selects hours from dropdown")]
        public void WhenUserSelectsHoursFromDropdown()
        {
            profile.AddHours();
        }

        [Then(@"hours is successfully saved")]
        public void ThenHoursIsSuccessfullySaved()
        {
            profile.PopulateValues();
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span"));
            String HoursText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            if (HoursText == "")
            {
                profile.AddHours();

            }
            String HoursText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Hours")), HoursText2);

        }

        [When(@"user updates Hours")]
        public void WhenUserUpdatesHours()
        {
            profile.UpdateHours();
        }

        [Then(@"hours is successfully updated")]
        public void ThenHoursIsSuccessfullyUpdated()
        {
            profile.PopulateValues();
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span"));
            String HoursText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            if (HoursText == "")
            {
                profile.AddHours();

            }
            String HoursText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Hours")), HoursText2);
        }

        [Given(@"user clicks on Earn Target")]
        public void GivenUserClicksOnEarnTarget()
        {
            profile.ClickEarnTarget();
        }

        [When(@"user selects Earn Target from dropdown")]
        public void WhenUserSelectsEarnTargetFromDropdown()
        {
            profile.AddEarnTarget();
        }

        [Then(@"Earn Target is successfully saved")]
        public void ThenEarnTargetIsSuccessfullySaved()
        {
            profile.PopulateValues();
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span"));
            String EarnTargetText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span")).Text;
            if (EarnTargetText == "")
            {
                profile.AddEarnTarget();

            }
            String EarnTargetText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Earn Target")), EarnTargetText2);
        }

        [When(@"user updates Earn Target")]
        public void WhenUserUpdatesEarnTarget()
        {
            profile.UpdateEarnTarget();
        }

        [Then(@"Earn Target is successfully updated")]
        public void ThenEarnTargetIsSuccessfullyUpdated()
        {
           profile.PopulateValues();            
            Thread.Sleep(1000);
            String expectedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Availability updated";
            Assert.AreEqual(expectedMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Given(@"user clicks on Description")]
        public void GivenUserClicksOnDescription()
        {
            profile.ClickDescription();
        }

        [When(@"user adds Description")]
        public void WhenUserAddsDescription()
        {
            profile.AddDescription();
        }

        [Then(@"user saves Description")]
        public void ThenUserSavesDescription()
        {
            Thread.Sleep(1000);
            String expextedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Description has been saved successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
           Base. driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [When(@"user updates Description")]
        public void WhenUserUpdatesDescription()
        {
            profile.UpdateDescription();
        }

        [Then(@"user updates Description successsfully")]
        public void ThenUserUpdatesDescriptionSuccesssfully()
        {
            Thread.Sleep(1000);
            String expextedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Description has been saved successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

    }
}
