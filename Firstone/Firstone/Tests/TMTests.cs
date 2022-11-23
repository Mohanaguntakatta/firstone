using Firstone.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;



// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
Loginpage loginpageobj = new Loginpage();
loginpageobj.LoginActions(driver);

HomePage homepageobj = new HomePage();
homepageobj.GotoTMPage(driver);

TMPage tmpageobj = new TMPage();
tmpageobj.CreateTM(driver);

tmpageobj.EditTM(driver);

tmpageobj.DeleteTM(driver);










  















