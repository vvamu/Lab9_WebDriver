
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;


namespace lab9_WebDriver;


public class MyTest : TestsClass
{
    protected override string? Url => "https://www.wattpad.com/home";

    private string bookName = "Остров Остов";

    [Test]
    public void SearchBook()
    {

        Thread.Sleep(1000);
        var searchInput = findElement("//input[@id='search-query']");
        searchInput.Click();
        searchInput.SendKeys(bookName);
        searchInput.SendKeys(Keys.Enter);

        Thread.Sleep(1000);
        string text = "";
        try
        {
             

            var elements = driver.FindElements(By.ClassName("title"));
                foreach (var eleme in elements)
                    if (eleme.Text == bookName)
                    {
                        text = eleme.Text;
                        Assert.True(text != "");

                    return;
                    }

        }
        catch
        {
            Assert.Fail(); 
        }


    }

}