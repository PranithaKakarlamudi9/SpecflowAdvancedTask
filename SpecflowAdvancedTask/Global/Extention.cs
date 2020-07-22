using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SeleniumAdvancedTask.Global
{
    //<Summary>
    //This class has all wait extension methods
    //</Summary>
    public static class Extension
    {
        //this wait method is for elements to wait for ceratin time 
        public static IWebElement WaitForElement(this IWebDriver driver, By ele, int timeOutinSeconds = 25)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                return wait.Until(x => x.FindElement(ele));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is: " + e);
                throw;
            }

        }

        //this wait method is for clickable elements to wait for ceratin time
        public static IWebElement WaitForClickableElement(this IWebDriver driver, By ele, int timeOutinSeconds = 25)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                return wait.Until(x => x.FindElement(ele));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is: " + e);
                throw;
            }
        }

        //this wait method is for list of elements to wait for ceratin time
        public static IList<IWebElement> WaitForList(this IWebDriver driver, By ele, int timeOutinSeconds = 25)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeOutinSeconds));
                return wait.Until(x => x.FindElements(ele));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception is: " + e);
                throw;
            }
        }
    }
}
