using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumConcept
{
    public class program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://github.com/login";
            string title = driver.Title;
            Console.WriteLine(title);
            Console.WriteLine(driver.Url);
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);

            driver.FindElement(By.Id("login_field")).SendKeys("gauravksagar2020@gmail.com");
            driver.FindElement(By.Id("password")).SendKeys("gksagar2020");
            driver.FindElement(By.Name("commit")).Click();


        }
    }
}
