using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

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
            Actions actions = new Actions(driver);
            try
            {
                actions.ScrollToElement(driver.FindElement(By.LinkText("Try Free"))).Perform();
            }
            catch { }
            Thread.Sleep(5000);
           driver.FindElement(By.LinkText("Try Free")).Click();

            driver.FindElement(By.Name("FirstName")).SendKeys("john");
            driver.FindElement(By.Name("LastName")).SendKeys("wick");
            driver.FindElement(By.XPath("//input[@id='login__email']")).SendKeys("john@gmail.com");
            
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@id='CompanySize']")));
            select.SelectByValue("10 - 99");
            driver.FindElement(By.XPath("//button[text()='Start My Trial']")).Click();

            
        }
    }
}
