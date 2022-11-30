using OpenQA.Selenium;


namespace Firstone.Pages
{
    public class HomePage
    {
        public void GotoTMPage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            // click Administration button
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationButton.Click();
            Thread.Sleep(1500);

            // identify time&meterials button
            IWebElement timeMeterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMeterials.Click();
            Thread.Sleep(1000);


        }

        public void GotoEmployeePage(IWebDriver driver)
        {
            Thread.Sleep(3000);
            // click Administration button
            IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            administrationButton.Click();
            Thread.Sleep(1500);

            // identify time&meterials button
            IWebElement employeeOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employeeOption.Click();
            Thread.Sleep(1000);


        }



    }
}
