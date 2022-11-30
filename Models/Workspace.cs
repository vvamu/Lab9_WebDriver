using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab9_WebDriver.Models;

public class Workspace
{
    public static IWebDriver? driver { get; set; }

    public Workspace(string pathToDriver)
    {
        if (driver == null)
            driver = new OpenQA.Selenium.Chrome.ChromeDriver(pathToDriver);
    }

    public void OpenBrowserWithUrl(string url)
    {
        driver.Navigate().GoToUrl(url);
        driver.Manage().Window.Maximize();
    }

    public void CloseBrowser()
    {
        driver.Quit();
        driver.Dispose();
    }

    public IWebElement findElementByXPath(string path) => driver.FindElements(By.XPath(path)).First();

}

