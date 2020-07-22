using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumAdvancedTask.Global;
using SeleniumExtras.PageObjects;
using SpecflowAdvancedTask.Global;

namespace SeleniumAdvancedTask.Pages
{
    //<Summary>
    //this class handles different functionalites of profile page
    //Add,upadate Availability,Earn target and hours
    //change password
    //Add update Description
    //Add,update and Delete Languages,Skills,Education and certification.
    //</Summary>
    class ProfilePage
    {
        public ProfilePage()
        {

            PageFactory.InitElements(Base.driver, this);
        }

        //profile page object repository

        //Availability
        [FindsBy(How = How.XPath, Using = "//div[@class='extra content']/descendant::div[5]/span/i")]
        public IWebElement Availability { get; set; }

        //Availability dropdown 
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        public IWebElement dropdownAvailability { get; set; }

        //Hours
        [FindsBy(How = How.XPath, Using = "//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span/i")]
        public IWebElement Hours { get; set; }

        //Hours dropdown 
        [FindsBy(How = How.Name, Using = "//select[@name='availabiltyHour']")]
        public IWebElement dropdownHours { get; set; }

        //Earn Target
        [FindsBy(How = How.XPath, Using = "//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span/i")]
        public IWebElement EarnTarget { get; set; }

        //Earn target dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        public IWebElement dropdownEarnTarget { get; set; }

        //click description
        [FindsBy(How = How.XPath, Using = "//div[@class='eight wide column']/descendant::div[3]/h3/span/i")]
        public IWebElement Desription { get; set; }

        //Add Description
        [FindsBy(How = How.XPath, Using = "//div[@class='eight wide column']/descendant::div[2]/form/descendant::div[6]/textarea")]
        public IWebElement txtDescription { get; set; }

        //Save Description
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        public IWebElement btnSaveDescription { get; set; }

        //AddNewLanguage
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[2]/descendant::div[6]/table/thead/tr/th[3]/div")]
        public IWebElement btnLangAddNew { get; set; }

        //UpdateLanguage button
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[3]/span[1]/i")]
        public IWebElement btnEditLanguage { get; set; }

        //Update confirm button language
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        public IWebElement btnUpdateConfirmLanguage { get; set; }

        //DeleteLanguage button
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[3]/span[2]/i")]
        public IWebElement btnDeleteLanguage { get; set; }


        //lnguage input text
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        public IWebElement txtLanguage { get; set; }

        //level dropdown
        [FindsBy(How = How.Name, Using = "level")]
        public IWebElement dropdownLevel { get; set; }

        //add button to save Language
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        public IWebElement btnAdd { get; set; }

        //slect Skills tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Skills')]")]
        public IWebElement tabSkills { get; set; }

        //AddNew Skills
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[3]/descendant::div[6]/table/thead/tr/th[3]/div")]
        public IWebElement btnAddNewSkills { get; set; }

        //SKills textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        public IWebElement txtSkills { get; set; }

        //skills dropdown
        [FindsBy(How = How.XPath, Using = "//Select[@class='ui fluid dropdown']")]
        public IWebElement dropdownSkillsLevel { get; set; }


        //skills add button
        [FindsBy(How = How.XPath, Using = "//span[@class='buttons-wrapper']/input[1]")]
        public IWebElement btnAddSkill { get; set; }

        //Edit Skills button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='form-wrapper']/table/tbody/tr[1]/td[3]/span[1]/i")]
        public IWebElement btnEditSkill { get; set; }

        //Update Skills
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        public IWebElement btnUpdateSkill { get; set; }

        //skills delete button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='form-wrapper']/table/tbody/tr[1]/td[3]/span[2]/i")]
        public IWebElement btnDeleteSkill { get; set; }

        //Education tab
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Education')]")]
        public IWebElement tabEducation { get; set; }

        //Addnew Education button
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[4]/descendant::div[6]/table/thead/tr/th[6]/div")]
        public IWebElement btnAddNewEducation { get; set; }

        //University/colleage textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        public IWebElement txtCollegeUni { get; set; }

        //select country of college/university
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        public IWebElement dropdownCollegeUni { get; set; }

        //select title
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        public IWebElement dropdownTitle { get; set; }

        //Degree textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        public IWebElement txtDegree { get; set; }

        //select graduation year
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        public IWebElement dropdownYear { get; set; }

        //clcick on add to save education
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button ']")]
        public IWebElement btnAddEducation { get; set; }

        //edit education btton 
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[6]/span[1]/i")]
        public IWebElement btnEditEducation { get; set; }

        //delete education tab
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[6]/span[2]/i")]
        public IWebElement btnEDeleteEducation { get; set; }

        //update education  //input[@value='Update']
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        public IWebElement btnUpdateEducation { get; set; }

        //click on certification tab 
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Certifications')]")]
        public IWebElement tabCertifications { get; set; }

        //click on Addnew Certification 
        [FindsBy(How = How.XPath, Using = "//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[5]/descendant::div[5]/div/table/thead/tr[1]/th[4]/div")]
        public IWebElement btnAddNewCetification { get; set; }

        //Certificate textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        public IWebElement txtCertificate { get; set; }

        //certified from textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        public IWebElement txtCertified { get; set; }

        //year dropdown for certification 
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        public IWebElement dropdownYearCertified { get; set; }

        //click on add for certification 
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[13]/input[1]")]
        public IWebElement btnAddCertification { get; set; }

        //click on edit certification 
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[4]/span[1]/i")]
        public IWebElement btnEditCertification { get; set; }

        //Delete edit certification
        [FindsBy(How = How.XPath, Using = "//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[4]/span[2]/i")]
        public IWebElement btnDeleteCertification { get; set; }

        //Update certification button
        [FindsBy(How = How.XPath, Using = "//input[@value='Update']")]
        public IWebElement btnUpdateCertification { get; set; }

        //for share skill link
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        public IWebElement ShareSkill { get; set; }


        //Finds ManageListings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        public IWebElement ManageLIstings { get; set; }



        //populate data
        public void PopulateValues()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "Profile");
        }

        //populate data for 
        public void PopulateDataForTabs()
        {
            ExcelLibrary.PopulateInCollection(Base.TestDataPath, "AddProfile");
        }

        public void ClickShareSkill()
        {
            Base.driver.WaitForElement(By.XPath("//div[@id='account-profile-section']/descendant::div[1]/section/descendant::a[6]"));
            ShareSkill.Click();
        }


        // Clicks on ManageListings Link

        public void ClickManageListings()
        {
            Base.driver.WaitForElement(By.XPath("//div[@id='account-profile-section']/descendant::div[1]/section/descendant::a[3]"));
            ManageLIstings.Click();
        }

        #region Add profile

        //add availability for new user
        public void ClickAvailability()
        {
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span/i"));
            Availability.Click();
        }
        public void AddAvailability()
        {
            PopulateValues();
            
            Base.driver.WaitForElement(By.XPath("//select[@name='availabiltyType']"));
            SelectElement availabiltyDropdown = new SelectElement(dropdownAvailability);
            availabiltyDropdown.SelectByText(ExcelLibrary.ReadData(2, "Availability"));
        }

        public void ClickHours()
        {
            Thread.Sleep(5000);
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span/i"));
            Hours.Click();
        }
        public void AddHours()
        {
            PopulateValues();
            //Hours.Click();
            Base.driver.WaitForElement(By.XPath("//div[@class='right floated content'] /span/select"));
            SelectElement HoursDropdown = new SelectElement(dropdownHours);
            HoursDropdown.SelectByText(ExcelLibrary.ReadData(2, "Hours"));

        }

        public void AddEarnTarget()
        {
            PopulateValues();
           // EarnTarget.Click();
            Base.driver.WaitForElement(By.XPath("//select[@name='availabiltyTarget']"));
            SelectElement earnTargetDropdown = new SelectElement(dropdownEarnTarget);
            earnTargetDropdown.SelectByText(ExcelLibrary.ReadData(2, "Earn Target"));

        }
        public void ClickDescription()
        {
            Base.driver.WaitForElement(By.XPath("//div[@class='eight wide column']/descendant::div[3]/h3/span/i"));
            Desription.Click();
        }

        public void AddDescription()
        {
            PopulateValues();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='eight wide column']/descendant::div[3]/h3/span/i"));
            //Desription.Click();
            txtDescription.Clear();
            txtDescription.SendKeys(ExcelLibrary.ReadData(2, "Description"));
            Base.driver.WaitForClickableElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            btnSaveDescription.Click();
        }
        public void ClickAddNewLanguage()
        {
            //click on addnew
            Base.driver.WaitForElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[2]/descendant::div[6]/table/thead/tr/th[3]/div"));
            btnLangAddNew.Click();
        }
        public void AddLanguage()
        {
            PopulateDataForTabs();

            //click on addnew
           // Base.driver.WaitForElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[2]/descendant::div[6]/table/thead/tr/th[3]/div"));
           // btnLangAddNew.Click();

            //enter language in language textbox
            txtLanguage.SendKeys(ExcelLibrary.ReadData(2, "Language"));

            //select level
            Base.driver.WaitForElement(By.Name("level"));
            SelectElement levelDropdown = new SelectElement(dropdownLevel);
            levelDropdown.SelectByValue(ExcelLibrary.ReadData(2, "Level"));

            //click on Add to save language
            btnAdd.Click();
        }
        public void ClickSkillsTab()
        {
            //click on skills tab
            Thread.Sleep(5000);
            Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Skills')]"));
            tabSkills.Click();
        }
        public void AddSkills()
        {

            PopulateDataForTabs();

            //click on skills tab
           // Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Skills')]"));
            //tabSkills.Click();

            //add new button
            btnAddNewSkills.Click();

            //add skills textbox
            Base.driver.WaitForElement(By.XPath("//input[@placeholder='Add Skill']"));
            txtSkills.SendKeys(ExcelLibrary.ReadData(2, "Skills"));

            //slecting skilll level
            Base.driver.WaitForElement(By.XPath("//Select[@name='level']"));
            SelectElement skillLeveldropdown = new SelectElement(dropdownSkillsLevel);
            skillLeveldropdown.SelectByText(ExcelLibrary.ReadData(2, "Skill level"));

            //click add button

            btnAddSkill.Click();

        }
        public void CLickEducationTab()
        {
            //click on education tab
            Thread.Sleep(5000);
             Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
             tabEducation.Click();
        }
        public void AddEducation()
        {
            PopulateDataForTabs();

            //click on education tab
           // Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
           // tabEducation.Click();

            //click on Addnew button
            Base.driver.WaitForClickableElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[4]/descendant::div[6]/table/thead/tr/th[6]/div"));
            btnAddNewEducation.Click();

            //college name textbox
            txtCollegeUni.SendKeys(ExcelLibrary.ReadData(2, "College Name"));

            //country dropdown
            Base.driver.WaitForElement(By.XPath("//select[@name='country']"));
            SelectElement CountryDropdown = new SelectElement(dropdownCollegeUni);
            CountryDropdown.SelectByValue(ExcelLibrary.ReadData(2, "Country of College"));

            //selecting title
            Base.driver.WaitForElement(By.XPath("//select[@name='title']"));
            SelectElement TitleDropdown = new SelectElement(dropdownTitle);
            TitleDropdown.SelectByValue(ExcelLibrary.ReadData(2, "Title"));


            //dgree textbox
            txtDegree.SendKeys(ExcelLibrary.ReadData(2, "Degree"));

            //selecting year of graduation
            Base.driver.WaitForElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement YearDropdown = new SelectElement(dropdownYear);
            YearDropdown.SelectByValue(ExcelLibrary.ReadData(2, "Year of graduation"));

            //click on add to save education
            btnAddEducation.Click();
        }
        public void ClickCertificationsTab()
        {
            //click on certification tab
            Thread.Sleep(5000);
            Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Certifications')]"));
            tabCertifications.Click();
        }
        public void AddCertifications()
        {
            PopulateDataForTabs();

            //click on certification tab
           // Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Certifications')]"));
           // tabCertifications.Click();

            //click on Addnew 
            Base.driver.WaitForClickableElement(By.XPath("//div[@id='account-profile-section']/descendant::section[2]/child::div/descendant::div[2]/child::div[3]/form/child::div[5]/descendant::div[5]/div/table/thead/tr[1]/th[4]/div"));
            btnAddNewCetification.Click();

            //Certificate textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='certificationName']"));
            txtCertificate.SendKeys(ExcelLibrary.ReadData(2, "Certificate"));

            //certified from textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='certificationFrom']"));
            txtCertified.SendKeys(ExcelLibrary.ReadData(2, "Certified from"));

            //year dropdown
            Base.driver.WaitForElement(By.XPath("//select[@name='certificationYear']"));
            SelectElement YearDropdown = new SelectElement(dropdownYearCertified);
            YearDropdown.SelectByValue(ExcelLibrary.ReadData(2, "Year"));

            //click on add
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='five wide field']/input[1]"));
            btnAddCertification.Click();
        }
        #endregion
        #region update Profile
        public void UpdateAvailability()
        {
            PopulateValues();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span/i"));
            Base.driver.WaitForElement(By.XPath("//select[@name='availabiltyType']"));
            SelectElement availabiltyDropdown = new SelectElement(dropdownAvailability);
            availabiltyDropdown.SelectByText(ExcelLibrary.ReadData(3, "Availability"));

        }

        public void UpdateHours()
        {
            PopulateValues();
            //Base.driver.WaitForClickableElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span/i"));
            //Hours.Click();
            Base.driver.WaitForClickableElement(By.XPath("//select[@name='availabiltyHour']"));
            SelectElement HoursDropdown = new SelectElement(dropdownHours);
            HoursDropdown.SelectByText(ExcelLibrary.ReadData(3, "Hours"));

        }

        public void ClickEarnTarget()
        {
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span/i"));
            EarnTarget.Click();
        }
        public void UpdateEarnTarget()
        {
            PopulateValues();
            //Base.driver.WaitForClickableElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span/i"));
            //EarnTarget.Click();
            Base.driver.WaitForClickableElement(By.XPath("//select[@name='availabiltyTarget']"));
            SelectElement earnTargetDropdown = new SelectElement(dropdownEarnTarget);
            earnTargetDropdown.SelectByText(ExcelLibrary.ReadData(3, "Earn Target"));
        }

        public void UpdateDescription()
        {
            PopulateValues();
            //Base.driver.WaitForElement(By.XPath("//div[@class='eight wide column']/descendant::div[3]/h3/span/i"));
           // Desription.Click();
            Base.driver.WaitForElement(By.XPath("//div[@class='eight wide column']/descendant::div[2]/form/descendant::div[6]/textarea"));
            txtDescription.Clear();
            Base.driver.WaitForElement(By.XPath("//div[@class='eight wide column']/descendant::div[2]/form/descendant::div[6]/textarea"));
            txtDescription.SendKeys(ExcelLibrary.ReadData(3, "Description"));
            Base.driver.WaitForElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button"));
            btnSaveDescription.Click();
        }
        public void EditLanguageBtn()
        {
             Base.driver.WaitForElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[3]/span[1]/i"));
            btnEditLanguage.Click();
        }
        public void UpdateLanguage()
        {
            PopulateDataForTabs();
           // Base.driver.WaitForElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[3]/span[1]/i"));
           // btnEditLanguage.Click();

            //enter language in language textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='name']"));
            txtLanguage.Clear();
            txtLanguage.SendKeys(ExcelLibrary.ReadData(3, "Language"));

            //select level
            Base.driver.WaitForElement(By.Name("level"));
            SelectElement levelDropdown = new SelectElement(dropdownLevel);
            levelDropdown.SelectByValue(ExcelLibrary.ReadData(3, "Level"));

            //click on update to save language
            btnUpdateConfirmLanguage.Click();

        }

        public void UpdateSkills()
        {
            PopulateDataForTabs();

            //click on skills tab
           // Base.driver.WaitForElement(By.XPath("//a[@class='item'][contains(text(),'Skills')]"));
           // tabSkills.Click();

            //edit buttonbutton
            Base.driver.WaitForElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='form-wrapper']/table/tbody/tr[1]/td[3]/span[1]/i"));
            btnEditSkill.Click();

            //add skills textbox
            Base.driver.WaitForElement(By.XPath("//input[@placeholder='Add Skill']"));
            txtSkills.Clear();
            txtSkills.SendKeys(ExcelLibrary.ReadData(3, "Skills"));

            //slecting skilll level
            Base.driver.WaitForElement(By.XPath("//Select[@name='level']"));
            SelectElement skillLeveldropdown = new SelectElement(dropdownSkillsLevel);
            skillLeveldropdown.SelectByText(ExcelLibrary.ReadData(3, "Skill level"));

            //click update button
            Base.driver.WaitForClickableElement(By.XPath("//input[@value='Update']"));
            btnUpdateSkill.Click();

        }
        public void UpdateEducation()
        {
            PopulateDataForTabs();

            //click on education tab
            //Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
            //tabEducation.Click();

            //click on edit button
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[6]/span[1]/i"));
            btnEditEducation.Click();

            //college name textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='instituteName']"));
            txtCollegeUni.Clear();
            txtCollegeUni.SendKeys(ExcelLibrary.ReadData(3, "College Name"));

            //country dropdown
            Base.driver.WaitForElement(By.XPath("//select[@name='country']"));
            SelectElement CountryDropdown = new SelectElement(dropdownCollegeUni);
            CountryDropdown.SelectByValue(ExcelLibrary.ReadData(3, "Country of College"));

            //selecting title
            Base.driver.WaitForElement(By.XPath("//select[@name='title']"));
            SelectElement TitleDropdown = new SelectElement(dropdownTitle);
            TitleDropdown.SelectByValue(ExcelLibrary.ReadData(3, "Title"));

            //dgree textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='degree']"));
            txtDegree.Clear();
            txtDegree.SendKeys(ExcelLibrary.ReadData(3, "Degree"));

            //selecting year of graduation
            Base.driver.WaitForElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement YearDropdown = new SelectElement(dropdownYear);
            YearDropdown.SelectByValue(ExcelLibrary.ReadData(3, "Year of graduation"));

            //click on add to update education 
            Base.driver.WaitForClickableElement(By.XPath("//input[@value='Update']"));
            btnUpdateEducation.Click();
        }

        public void UpdateCeritfications()
        {
            PopulateDataForTabs();

            //click on certification tab
            //Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Certifications')]"));
            //tabCertifications.Click();

            //click on Edit button 
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[4]/span[1]/i"));
            btnEditCertification.Click();

            //Certificate textbox
            Base.driver.WaitForElement(By.XPath("//input[@name='certificationName']"));
            txtCertificate.Clear();
            txtCertificate.SendKeys(ExcelLibrary.ReadData(3, "Certificate"));

            //certified from textbox 
            Base.driver.WaitForElement(By.XPath("//input[@name='certificationFrom']"));
            txtCertified.Clear();
            txtCertified.SendKeys(ExcelLibrary.ReadData(3, "Certified from"));

            //year dropdown 
            Base.driver.WaitForElement(By.XPath("//select[@name='certificationYear']"));
            SelectElement YearDropdown = new SelectElement(dropdownYearCertified);
            YearDropdown.SelectByValue(ExcelLibrary.ReadData(3, "Year"));

            //click on Update
            Base.driver.WaitForElement(By.XPath("//input[@value='Update']"));
            btnUpdateCertification.Click();
        }
        #endregion

        #region delete
        public void DeleteLanguage()
        {
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[3]/span[2]/i"));
            btnDeleteLanguage.Click();
        }

        public void DeleteSkills()
        {
            //Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Skills')]"));
            //tabSkills.Click();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']/descendant::div[@class='form-wrapper']/table/tbody/tr[1]/td[3]/span[2]/i"));
            btnDeleteSkill.Click();
        }

        public void DeleteEducation()
        {
            //Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Education')]"));
            //tabEducation.Click();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[6]/span[2]/i"));
            btnEDeleteEducation.Click();

        }

        public void DeleteCertifications()
        {
           // Base.driver.WaitForClickableElement(By.XPath("//a[@class='item'][contains(text(),'Certifications')]"));
            //tabCertifications.Click();
            Base.driver.WaitForClickableElement(By.XPath("//div[@class='twelve wide column scrollTable']/div/table/tbody/tr[1]/td[4]/span[2]/i"));
            btnDeleteCertification.Click();

        }

        #endregion
    }




}


