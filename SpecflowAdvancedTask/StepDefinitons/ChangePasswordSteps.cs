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
    class ChangePasswordSteps
    {
        Common common = new Common();
        [Given(@"user clicks on change password")]
        public void GivenUserClicksOnChangePassword()
        {
            common.ChangePassword();
        }

        [When(@"user enters valid information")]
        public void WhenUserEntersValidInformation()
        {
            common.ChangePasswordDetails();
        }

        [Then(@"password gets changed successfully")]
        public void ThenPasswordGetsChangedSuccessfully()
        {
            Thread.Sleep(1000);
            String expextedMessage = Base.driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Password Changed Successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
        }

    }
}
