using Firstone.Utilites;
using OpenQA.Selenium;


namespace Firstone.Pages
{
    public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            //identify create new button
            IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNew.Click();
            Thread.Sleep(1000);

            //identify tyecode button
            IWebElement typecodeButton = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/label"));
            typecodeButton.Click();
            Thread.Sleep(1000);


            //identify code textbox
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("C001");
            Thread.Sleep(1000);


            //identify description textbox
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Glass");
            Thread.Sleep(1000);

            //identify price per unit textbox
            IWebElement priceperunitTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            priceperunitTextbox.SendKeys("100");
            Thread.Sleep(1000);

            //click save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(1500);

            //click go to the last page
            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpage.Click();
            Thread.Sleep(1500);

            // chech if user has logged in successfully
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if(newCode.Text == "C001")
            {
                Console.WriteLine("New record created successfully.");
            }
            else
            {
                Console.WriteLine("New record hasn't been created.");
            }
        }

        public void EditTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpage.Click();
            // click edit button
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();

            // edit code textbox 
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
            editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("C002");
            Thread.Sleep(1500);

            // edit description textbox
            IWebElement editDescriptionTextbox = driver.FindElement(By.Id("Description"));
            editDescriptionTextbox.Clear();
            editDescriptionTextbox.SendKeys("Firstone");
            Thread.Sleep(1500);

            // edit price per unit textbox
            IWebElement overlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement pricePerUnitTextbox = driver.FindElement(By.Id("Price"));
            
            overlappingTag.Click();
            pricePerUnitTextbox.Clear();
            overlappingTag.Click();
            pricePerUnitTextbox.SendKeys("200");

            // click save button
            IWebElement clickSavebutton = driver.FindElement(By.Id("SaveButton"));
            clickSavebutton.Click();
            Thread.Sleep(1500);

            // click go to the late page
            IWebElement gotothelastpageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpageButton.Click();
            Thread.Sleep(1500);
            

            //check if the user save record

        }

        public void DeleteTM(IWebDriver driver)
        {
            Thread.Sleep(2000);

            IWebElement gotothelastpage = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotothelastpage.Click();
            Thread.Sleep(2000);

            // click delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            deleteButton.Click();
            Thread.Sleep(2000);

            // conforming delete ok button
            driver.SwitchTo().Alert().Accept();

            // identify hello hari
            IWebElement hellohariButton = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            hellohariButton.Click();
            Thread.Sleep(1500);

            //click log off button
            IWebElement logoffButton = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/ul/li[2]/a"));
            logoffButton.Click();

            // chech if user has logged out successfully



        }


    }
}
