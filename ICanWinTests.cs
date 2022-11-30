
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace lab9_WebDriver;


public class ICanWinTests : TestsClass
{
    protected override string? Url =>  "https://pastebin.com";


    private By btCreateNewPaste = By.XPath("//button[text()='Create New Paste']");
    private By msgError = By.XPath("//div[@class='error-summary']");


    private string codeValue = "Hello from WebDriver";
    private string titleValue = "helloweb";


    [Test]
    public void Test1()
    {

        Thread.Sleep(1000);
        findElement(By.XPath(("//span[@id='select2-postform-expiration-container']"))).Click();
        Thread.Sleep(1000);
        findElement(By.XPath(($"//li[text()='10 Minutes']"))).Click();
        findElement(By.XPath(("//input[@id='postform-name']"))).SendKeys(titleValue);
        findElement(By.XPath(("//textarea"))).SendKeys(codeValue); 
        


        var btPaste = findElement(btCreateNewPaste);
        btPaste.Click();
        Thread.Sleep(2000);


        //var errorMsg = driver.FindElement(msgError);

        var currentUrl = driver.Url;
        Assert.IsTrue(currentUrl != Url);
        

    }

}