using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumAdavance
{
    public class royalcaribbean
    {
        [Test]
        public void Royal()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://www.royalcaribbean.com/";
            driver.FindElement(By.XPath("//span[text()='Sign In']")).Click();
            driver.FindElement(By.PartialLinkText("© 2023 Royal Caribbean")).Click();
        }
    }
}
