﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Global;
using SeleniumExtras.PageObjects;
using SpecflowAdvancedTask.Global;

namespace SeleniumAdvancedTask.Pages
{
    //<Summary>
    //This class performs edit and delete on Manage listings items
    //</Summary>
    class ManageListingsPage
    {
        public ManageListingsPage()
        {
            PageFactory.InitElements(Base.driver, this);
        }


        //Delete button
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/descendant::button[3]")]
        public IWebElement btnDelete { get; set; }

        //Edit button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui small icon buttons basic vertical']/button[2]")]
        public IWebElement btnEdit { get; set; }


        //This method Edits ManageListing from ManageListings table
        public void EditManageListings()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "ManageListingsSheet");
            if ((ExcelLibrary.ReadData(2, "Edit Action")) == "Yes")
            {
                Base.driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
                String titleManageListing = Base.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
                if (titleManageListing == "Seleinium with Csharp")
                {
                    btnEdit.Click();
                    ShareSkillPage skillPage = new ShareSkillPage();
                    skillPage.ReadExcelEditShareSkill();
                    skillPage.AddShareSkill();
                }
            }
        }
        //This method deletes ManageLIsting fom ManageListings table

        public void DeleteManageListing()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "ManageListingsSheet");
            Base.driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
            String titleManageListing = Base.driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
            if ((ExcelLibrary.ReadData(2, "Delete Action")) == "Yes")
            {
                if ((titleManageListing == "Seleinium with Csharp") || (titleManageListing == "Seleinium with Java"))
                // if (titleManageListing == "Java")
                {
                    btnDelete.Click();
                    Thread.Sleep(1000);
                    String deleteText = Base.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/p[1]")).Text;
                    String deleteByTitle = Base.driver.FindElement(By.XPath("/html/body/div[2]/div/div[2]/p[2]")).Text;
                    if ((deleteText == "Are you sure you want to delete this service?") && (deleteByTitle == titleManageListing))
                    {
                        //click on 'Yes' to delete ManageListing
                        Base.driver.FindElement(By.XPath("//div[@class='actions']/button[2]")).Click();
                    }
                    else
                    {
                        //click on 'No' to cancel delete ManageListing
                        Base.driver.FindElement(By.XPath("//div[@class='actions']/button[1]")).Click();
                    }
                }
            }
        }
    }
}
