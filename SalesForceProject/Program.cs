using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Maveric.Salesforce
{
    public class Program
    {
        public static void Main(string[]args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";
            driver.FindElement(By.Name("UserFirstName")).SendKeys("John");
            driver.FindElement(By.Name("UserLastName")).SendKeys("wick");
            driver.FindElement(By.Name("UserEmail")).SendKeys("John@gmail.com");
            SelectElement SelectTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            SelectTitle.SelectByText("IT Manager");
            driver.FindElement(By.Name("CompanyName")).SendKeys("Maveric System");

            SelectElement SelectEmployee= new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            SelectEmployee.SelectByText("101 - 500 employees");

          
         
            driver.FindElement(By.Name("CompanyEmployees")).Click();
            SelectElement SelectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            SelectCountry.SelectByText("Germany");
            driver.FindElement(By.ClassName("checkbox-ui")).Click();
           // driver.FindElement(By.t)
            driver.FindElement(By.Name("start my free trial")).Click();


        }
    }
}