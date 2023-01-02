using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumAdavance
{
    public class FrameTest
    {
        [Test]
        public void Demo1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("")));
            //  driver.FindElement(By.Name(""))


        }
        [Test]
        public void Demo2()
        {

        }
    }
}
