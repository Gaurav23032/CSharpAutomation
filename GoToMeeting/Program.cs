using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace GoToMeeting
{
    public class program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.goto.com/meeting";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
           driver.FindElement(By.LinkText("")).Click();
        }
    }
}
