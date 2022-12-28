
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;

namespace Parabank
{
 public class Program
    {
        public static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://parabank.parasoft.com/parabank/register.htm";
            driver.FindElement(By.Id("customer.firstName")).SendKeys("Ram");
            driver.FindElement(By.Id("customer.lastName")).SendKeys("mane");
            driver.FindElement(By.Id("customer.address.street")).SendKeys("BD road");
            driver.FindElement(By.Id("customer.address.city")).SendKeys("Pune");
            driver.FindElement(By.Id("customer.address.state")).SendKeys("Maharashtra");
            driver.FindElement(By.Id("customer.address.zipCode")).SendKeys("415522");
            driver.FindElement(By.Id("customer.phoneNumber")).SendKeys("9089765678");
            driver.FindElement(By.Id("customer.ssn")).SendKeys("2345");
            driver.FindElement(By.Id("customer.username")).SendKeys("powar");
            driver.FindElement(By.Id("customer.password")).SendKeys("ram123");
            driver.FindElement(By.Id("repeatedPassword")).SendKeys("ram123");
            driver.FindElement(By.XPath("//input[@value='Register']")).Click();

        }
    }
}