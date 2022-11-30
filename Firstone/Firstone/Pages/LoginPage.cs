using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Firstone.Pages
{
    public class Loginpage
    {
      public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            // launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
            Thread.Sleep(1000);

            // identify username textbox and enter valid user name
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");
            Thread.Sleep(1000);

            // identify password text box and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Name("Password"));
            passwordTextbox.SendKeys("123123");
            Thread.Sleep(1000);


            // click login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
            loginButton.Click();
            Thread.Sleep(1000);


        }


    }
}
