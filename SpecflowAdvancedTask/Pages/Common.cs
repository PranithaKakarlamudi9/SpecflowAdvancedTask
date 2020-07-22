using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver.Core.Events;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumAdvancedTask.Global;
using SeleniumExtras.PageObjects;
using SpecflowAdvancedTask.Global;

namespace SeleniumAdvancedTask.Pages
{
    //<Summary>
    //This class conatins common methods  to all pages in website
    //change password
    //search skill
    //</Summary>
    class Common
    {
        public Common()
        {
            PageFactory.InitElements(Base.driver, this);
        }

        //page object repository
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::div[5]/span")]
        public IWebElement UserName { get; set; }

        //select change password 
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::div[5]/span/div/a[2]")]
        public IWebElement selectChangePassword { get; set; }

        //old password textbox 
        [FindsBy(How = How.XPath, Using = "//input[@name='oldPassword']")]
        public IWebElement txtOldPassword { get; set; }

        //new password textbox 
        [FindsBy(How = How.XPath, Using = "//input[@name='newPassword']")]
        public IWebElement txtNewPassword { get; set; }

        //confirm password textbox 
        [FindsBy(How = How.XPath, Using = "//input[@name='confirmPassword']")]
        public IWebElement txtConfirmPassword { get; set; }

        //Save button 
        [FindsBy(How = How.XPath, Using = "/html/body/div[4]/div/div[2]/form/div[4]/button")]
        public IWebElement btnSave { get; set; }


        //click on search skill textbox 
        [FindsBy(How = How.XPath, Using = "//div[@class='ui small icon input search-box']/input")]
        public IWebElement txtSearchSkill { get; set; }

        //click on search icon
        [FindsBy(How = How.XPath, Using = "//div[@class='ui small icon input search-box']/i")]
        public IWebElement btnSearchIcon { get; set; }

        //category list 
        [FindsBy(How = How.XPath, Using = "//div[@class='ui link list']/a")]
        public IList<IWebElement> Category { get; set; }

        //subcategory //div[@class='ui link list']/a[11]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui link list']/a[11]")]
        public IWebElement SubCategory { get; set; }

        //Search by Filter
        [FindsBy(How = How.XPath, Using = "//div[@class='ui buttons']/button")]
        public IList<IWebElement> Filter { get; set; }

        //Search result list 
        [FindsBy(How = How.XPath, Using = "//div[@class='ui stackable three cards']/div[@class='ui card']")]
        public IList<IWebElement> SearchResultList { get; set; }


        //populate data for change password
        public void PopulateDataForChangePassword()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "Registration");
        }

        //populate data for SearchSkill
        public void PopulateDataForSearchSkill()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "SearchSkill");
        }



        //This method is used to change user current password
        public void ChangePassword()
        {
            PopulateDataForChangePassword();
            //click on user name
            Base.driver.WaitForClickableElement(By.XPath("//div[@id='account-profile-section']/descendant::div[5]/span"));
            UserName.Click();

            //clcik on change password in the dropdown
            Actions act = new Actions(Base.driver);
            Thread.Sleep(1000);
            act.MoveToElement(selectChangePassword).Build().Perform();
            // Base.driver.WaitForClickableElement(By.XPath("//div[@id='account-profile-section']/descendant::div[5]/span/div/a[2]"));
            selectChangePassword.Click();
        }
        public void ChangePasswordDetails()
        {
            //enter old password
            Base.driver.WaitForElement(By.XPath("//input[@name='oldPassword']"));
            txtOldPassword.SendKeys(ExcelLibrary.ReadData(2, "Password"));

            //enter New password
            Base.driver.WaitForElement(By.XPath("//input[@name='newPassword']"));
            txtNewPassword.SendKeys(ExcelLibrary.ReadData(3, "Password"));

            //confirm password
            Base.driver.WaitForElement(By.XPath("//input[@name='confirmPassword']"));
            txtConfirmPassword.SendKeys(ExcelLibrary.ReadData(3, "ConfirmPassword"));

            //click on save
            Base.driver.WaitForClickableElement(By.XPath("/html/body/div[4]/div/div[2]/form/div[4]/button"));
            btnSave.Click();
        }
        public void ClickOnSearchIcon()
        {
            //click on search icon
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/i"));
            btnSearchIcon.Click();
        }
        //Search result list
        public int SearchResult()
        {
            int resultCount = SearchResultList.Count();
            return resultCount;
        }

        //Search Skill by category entering category directly into textbox
        public void SearchSkillByCategory()
        {

            PopulateDataForSearchSkill();
            ProfilePage profile = new ProfilePage();

            profile.ClickShareSkill();

            // click on SearchSkill textbox
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/input"));
            txtSearchSkill.Click();
            txtSearchSkill.SendKeys(ExcelLibrary.ReadData(2, "Category"));

            //click on search icon
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/i"));
            btnSearchIcon.Click();


        }
        //Selecting category at random in Searchskill result page
        public void SearchSkillBySelectingCategory()
        {
            PopulateDataForSearchSkill();
            SearchSkillByCategory();
            Base.driver.WaitForList(By.XPath("//div[@class='row']/descendant::div[@class='ui stackable three cards']"));
            int listCtegory = Category.Count();
            if (listCtegory > 0)
            {
                for (int i = 0; i < listCtegory; i++)
                {
                    String txtCategory = Category.ElementAt(i).Text;
                    Console.WriteLine(txtCategory);
                    if (txtCategory == ExcelLibrary.ReadData(2, "Category"))
                    {
                        Console.WriteLine(txtCategory);
                        //Base.driver.WaitForList(By.XPath("//div[@class='ui link list']/a"));
                        Category.ElementAt(i).Click();
                    }
                }
            }
        }
        //subcategory
        public void SearchSkillBySubCategory()
        {
            PopulateDataForSearchSkill();
            // click on SearchSkill textbox
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/input"));
            txtSearchSkill.Click();
            txtSearchSkill.SendKeys(ExcelLibrary.ReadData(2, "SubCategory"));

            //click on search icon
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/i"));
            btnSearchIcon.Click();
        }

        //This method searches skill by selecting sub category in search result page
        public void SearchSkillBySelectingSubCategory()
        {
            PopulateDataForSearchSkill();
            SearchSkillBySelectingCategory();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='ui link list']/a[11]"));
            SubCategory.Click();

        }

        //This method is used to search skill by filter type in serch text box and in search result page
        public void SearchByFilterType()
        {
            PopulateDataForSearchSkill();
            ProfilePage profile = new ProfilePage();

            profile.ClickShareSkill();

            // click on SearchSkill textbox
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/input"));
            txtSearchSkill.Click();
            txtSearchSkill.SendKeys(ExcelLibrary.ReadData(2, "Filter"));

            //click on search icon
            Base.driver.WaitForElement(By.XPath("//div[@class='ui small icon input search-box']/i"));
            btnSearchIcon.Click();

            Base.driver.WaitForClickableElement(By.XPath("//div[@class='ui buttons']/button"));

            int listFilter = Filter.Count();


            for (int i = 0; i < listFilter; i++)
            {
                String txtFilter = Filter.ElementAt(i).Text;
                if (txtFilter == ExcelLibrary.ReadData(4, "Filter"))
                {
                    Thread.Sleep(10000);

                    Filter.ElementAt(i).Click();
                }
            }

        }

    }
}
