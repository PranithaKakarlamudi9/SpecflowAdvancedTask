using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    class ShareSkillSteps
    {
        ProfilePage profile = new ProfilePage();
        ShareSkillPage shareSkill = new ShareSkillPage();

        [Given(@"User navigates to ShareSkill page")]
        public void GivenUserNavigatesToShareSkillPage()
        {
            
            profile.ClickShareSkill();
        }

        [When(@"User adds ShareSkill details on the ShareSkill page")]
        public void WhenUserAddsShareSkillDetailsOnTheShareSkillPage()
        {
            shareSkill.ReadExcelAddShareSkill();
            shareSkill.AddShareSkill();
        }

        [Then(@"ShareSkill should get added")]
        public void ThenShareSkillShouldGetAdded()
        {
           Base. driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
            String expextedTitle = "Seleinium with Csharp";
            String actualTitle = Base.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(expextedTitle, actualTitle);
        }

    }
}
