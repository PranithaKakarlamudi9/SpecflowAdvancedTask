using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using SeleniumAdvancedTask.Pages;
using SpecflowAdvancedTask.Global;
using TechTalk.SpecFlow;

namespace SpecflowAdvancedTask.Hook
{
    [Binding]
    //<summary>
    //This class intialises extent report and creates report about feature,scenario and steps tested.
    //</summary>
    class Start
    {
        Base baseObj = new Base();
       static  bool registeredUser = true;

        #region reports
        public static ExtentTest featureName;
        public static ExtentTest scenarioName;
        public  static ExtentReports extent;
        public  static ScenarioContext contextScenario;
        

        public  static void InitialiseReports()
        {
            //creating html reporter object with reports patha as paramter
            ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(Base.ReportsPath);

            //configuring theme of report
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;

            //creating extent report object
            extent = new ExtentReports();

            //Atcching html reporter to extent object 
            extent.AttachReporter(htmlReporter);
        }
        #endregion
        [BeforeTestRun]
        public  static void   SetUp()
        {
            InitialiseReports();

            //initialisng webdriver driver object with browser
            Base.IntialiseBrowser("Chrome");

            //check user is registered or not
            if (registeredUser == true)
            {
                LoginPage login = new LoginPage();
                login.LogIn();
            }
            else
            {
                RegistrationPage registration = new RegistrationPage();
                registration.Register();
            }

        }

        //This method gets feature title being tested
        [BeforeFeature]
        public  static void BeforeFeatureStart(FeatureContext featureContext)
        {
            
            if (featureContext != null)
            {
                featureName = extent.CreateTest<Feature>(featureContext.FeatureInfo.Title, featureContext.FeatureInfo.Description);
            }
        }

       //This method gets scenario title being tested
        [BeforeScenario]
        public void BeforeScenarioStart(ScenarioContext scenarioContext)
        {
            if (scenarioContext != null)
            {
                contextScenario= scenarioContext;
                scenarioName = featureName.CreateNode<Scenario>(scenarioContext.ScenarioInfo.Title, scenarioContext.ScenarioInfo.Description);
            }

        }
        //<summary>
        //This method gets title of sceanrio steps of passed tests in report
        //This method reports error if test failed
        //</summary>
        [AfterStep]
        public  void AfterEachStep()
        {
            
            ScenarioBlock scenarioBlock = contextScenario.CurrentScenarioBlock;            
            switch (scenarioBlock)
            {
                case ScenarioBlock.Given:
                    if (contextScenario.TestError != null)
                    {
                        scenarioName.CreateNode<Given>(contextScenario.StepContext.StepInfo.Text).Fail(contextScenario.TestError.Message +"\n"+contextScenario.TestError.StackTrace);
                       
                    }
                    else
                    {
                        scenarioName.CreateNode<Given>(contextScenario.StepContext.StepInfo.Text);
                        
                    }
                    break;

                case ScenarioBlock.When:
                    if (contextScenario.TestError != null)
                    {
                        scenarioName.CreateNode<When>(contextScenario.StepContext.StepInfo.Text).Fail(contextScenario.TestError.Message + "\n" + contextScenario.TestError.StackTrace);

                    }
                    else
                    {
                        scenarioName.CreateNode<When>(contextScenario.StepContext.StepInfo.Text);

                    }
                    break;

                case ScenarioBlock.Then:
                    if (contextScenario.TestError != null)
                        if (contextScenario.TestError != null)
                        {
                            scenarioName.CreateNode<Then>(contextScenario.StepContext.StepInfo.Text).Fail(contextScenario.TestError.Message + "\n" + contextScenario.TestError.StackTrace);

                        }
                        else
                        {
                            scenarioName.CreateNode<Then>(contextScenario.StepContext.StepInfo.Text);

                        }
                    break;
            }
        }
        [AfterTestRun]
        public static  void TearDown()
        {

            //Close Browser opened by Selenium
            Base.driver.Quit();

            //Flush() write everything to the Report
            extent.Flush();
        }





    }
}
