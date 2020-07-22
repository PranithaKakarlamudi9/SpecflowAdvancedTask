using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SpecflowAdvancedTask.Global
{
    //<summary>
    //This class has paths and intilaises Wed driver with a browser
    //</summary>
    class Base
    {

        public static IWebDriver driver { get; set; }

        #region access path
        //path to website,reports, test data and screenshots
        public static String BaseUrl = "http://192.168.99.100:5000";
        public static String ReportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Reports\\");
        public static String TestDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestData\\MarsTestData.xlsx");
        #endregion

        //This method intialises webdriver with browser type as paramater
        public static void IntialiseBrowser(String browser)
        {

            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
            }
        }
    }
}
