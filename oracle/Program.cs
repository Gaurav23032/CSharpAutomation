using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace oracle
{

    public class program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.oracle.com/in/database/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//span[text()='View Accounts']")).Click();
            driver.FindElement(By.XPath("//a[text()='Sign-In']")).Click();
            Console.WriteLine(driver.Title);
            Console.WriteLine(driver.Url);
            Thread.Sleep(1000);
            IWebElement element = driver.FindElement(By.XPath("//h2[contains(text(),' Oracle account sign in')]"));
            string ele = element.Text;
            Console.WriteLine(ele);


        }
    }
}