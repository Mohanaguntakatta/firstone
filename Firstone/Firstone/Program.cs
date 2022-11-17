using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



// open chrome browser
IWebDriver driver = new ChromeDriver();
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

// chech if user has logged in successfully


// click Administration button
IWebElement administrationButton = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationButton.Click();
Thread.Sleep(1000);

// identify time&meterials button
IWebElement timeMeterials = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeMeterials.Click();
Thread.Sleep(1000);

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
Thread.Sleep(1000);



//check if the user save record


