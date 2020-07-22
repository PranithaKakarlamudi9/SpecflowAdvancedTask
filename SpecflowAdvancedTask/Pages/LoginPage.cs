using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvancedTask.Global;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SpecflowAdvancedTask.Global;

namespace SeleniumAdvancedTask.Pages
{
    //<Summary>
    //This class logs in user successfully
    //</Summary>
    class LoginPage
    {
        public LoginPage()
        {
            PageFactory.InitElements(Base.driver, this);
        }

        //Login page object factory

        //Finding SignIn
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/a")]
        public IWebElement btnSignIn { get; set; }

        //Finding email textbox
        [FindsBy(How = How.Name, Using = "email")]
        public IWebElement txtEmailAddress { get; set; }

        //Finding password textbox
        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement txtPassword { get; set; }

        //Finding login button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement btnLogin { get; set; }


        // Login method performs login operation with valid credentials 
        public void LogIn()
        {
            //populating data from excel sheet into datacollectiion 
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "LogInSheet");

            //user clicks on SignIn button
            btnSignIn.Click();

            //user enters valid username         
            txtEmailAddress.SendKeys(ExcelLibrary.ReadData(2, "Email"));

            //user enters valid password        
            txtPassword.SendKeys(ExcelLibrary.ReadData(2, "Password"));

            //user clicks on login button
            btnLogin.Click();

        }
    }
}
