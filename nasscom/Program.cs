﻿
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace nasscom
{
    public class program
    {
        static void Main(String[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://nasscom.in/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//a[text()='Login']")).Click();
            driver.FindElement(By.XPath("//li[text()='register']")).Click();
            driver.FindElement(By.XPath("//input[@id='edit-field-fname-reg-0-value']")).SendKeys("admin");
            driver.FindElement(By.XPath("//input[@id='edit-field-lname-0-value']")).SendKeys("pass");
            driver.FindElement(By.XPath("//input[@id='edit-mail']")).SendKeys("admin@gmail.com");
            driver.FindElement(By.XPath("//input[@id='edit-field-company-name-registration-0-value']")).SendKeys("Google");
            SelectElement select = new SelectElement(driver.FindElement(By.XPath("//select[@id=\"edit-field-business-focus-reg\"]")));
            select.SelectByText("IT Consulting");
            driver.FindElement(By.XPath("//input[@id='edit-submit--2']")).Click();







        }
    }
}