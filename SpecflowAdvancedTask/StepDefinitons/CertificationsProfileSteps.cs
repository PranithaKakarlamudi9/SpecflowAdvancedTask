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
    class CertificationsProfileSteps
    {
        ProfilePage profile = new ProfilePage();

        [Given(@"User clicks on Certification tab")]
        public void GivenUserClicksOnCertificationTab()
        {
            profile.ClickCertificationsTab();
        }

        [When(@"Adds Certification details")]
        public void WhenAddsCertificationDetails()
        {
            profile.AddCertifications();
        }

        [Then(@"Certification should get added on the profile page")]
        public void ThenCertificationShouldGetAddedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "ISTQB has been added to your certification";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }

        [When(@"Updates Certification details")]
        public void WhenUpdatesCertificationDetails()
        {
            profile.UpdateCeritfications();
        }

        [Then(@"Certification should get updated on the profile page")]
        public void ThenCertificationShouldGetUpdatedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expextedAddMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Foundation level has been updated to your certification";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }
        [When(@"Clicks on Ceritification delete icon")]
        public void WhenClicksOnCeritificationDeleteIcon()
        {
            profile.DeleteCertifications();
        }

        [Then(@"Certification should get deleted on the profile page")]
        public void ThenCertificationShouldGetDeletedOnTheProfilePage()
        {
            Thread.Sleep(1000);
            String expectedDeleteMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Foundation level has been deleted from your certification";
            Assert.AreEqual(expectedDeleteMessage, actualMessage);
            Base.driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

    }
}
