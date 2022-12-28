using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Security.Cryptography.X509Certificates;

namespace demoguru99
{
    public class program
    {
        public static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demo.guru99.com/test/newtours/register.php";
            driver.FindElement(By.Name("firstName")).SendKeys("Pratik");
            driver.FindElement(By.Name("lastName")).SendKeys("rane");
            driver.FindElement(By.Name("phone")).SendKeys("9078687789");
            driver.FindElement(By.Name("userName")).SendKeys("Pratik@123gmail.com");
            driver.FindElement(By.Name("city")).SendKeys("Satara");
            driver.FindElement(By.Name("state")).SendKeys("Maharashtra");
            driver.FindElement(By.Name("postalCode")).SendKeys("412344");
            driver.FindElement(By.Name("country")).Click();
            driver.FindElement(By.XPath("//option[@value='ALGERIA']")).Click();
            driver.FindElement(By.Name("email")).SendKeys("Pratik@123gmail.com");
            driver.FindElement(By.Name("password")).SendKeys("12345");
            driver.FindElement(By.Name("confirmPassword")).SendKeys("12345");
            driver.FindElement(By.Name("submit")).Click();





        }
        }
    }

