using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Global;
using SeleniumExtras.PageObjects;
using SpecflowAdvancedTask.Global;

namespace SeleniumAdvancedTask.Pages
{
    //<Summary>
    // This class registers user successfully into Skills Swap website
    //<Summary>
    class RegistrationPage
    {
        public RegistrationPage()
        {
            PageFactory.InitElements(Base.driver, this);
        }
        //page objects

        //click on Join
        [FindsBy(How = How.XPath, Using = "//div[@class='first-section']/descendant::div[2]/button")]
        public IWebElement Join { get; set; }

        //FindsFirstName
        [FindsBy(How = How.Name, Using = "firstName")]
        public IWebElement txtFirstName { get; set; }

        //Finds LastName
        [FindsBy(How = How.Name, Using = "lastName")]
        public IWebElement txtLastName { get; set; }

        //Finds Email address
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmailAddress { get; set; }

        //Finds Password
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        //Finds Confirm password
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        public IWebElement txtConfirmPassword { get; set; }

        //check Terms and Conditions
        [FindsBy(How = How.Name, Using = "terms")]
        public IWebElement checkboxTermsConditions { get; set; }

        //Click on Join button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui tiny modal transition visible active']/descendant::div[11]/div")]
        public IWebElement btnJoin { get; set; }

        //this method registers new user into website
        public void Register()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "Registration");

            //click on Join button to register
            Join.Click();

            //enter first name
            txtFirstName.SendKeys(ExcelLibrary.ReadData(2, "FirstName"));

            //enter last name
            txtLastName.SendKeys(ExcelLibrary.ReadData(2, "LastName"));

            //enter email address
            txtEmailAddress.SendKeys(ExcelLibrary.ReadData(2, "Emailaddress"));

            //enter password
            txtPassword.SendKeys(ExcelLibrary.ReadData(2, "Password"));

            //enter confirm password
            txtConfirmPassword.SendKeys(ExcelLibrary.ReadData(2, "ConfirmPassword"));

            //keyword 
            //check terms and conditions
            if (ExcelLibrary.ReadData(2, "I agree to Terms and Conditions") == "check")
                checkboxTermsConditions.Click();

            //click on join button to register
            if (ExcelLibrary.ReadData(2, "Join") == "join")
                btnJoin.Click();




        }
    }
}
