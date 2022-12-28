using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FaceBook
{
    public class program
    {
        public static void Main(string[]args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.facebook.com/signup";
        }

    }
}
