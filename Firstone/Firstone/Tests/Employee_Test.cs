using Firstone.Pages;
using Firstone.Utilites;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firstone.Tests
{
    [TestFixture]
    [Parallelizable]
    public class Employee_Test: CommonDriver
    {
        [SetUp]
        public void LoginSteps()
        {
            driver =  new ChromeDriver();
            // Login page object initialization and definition
            Loginpage loginpageobj = new Loginpage();
            loginpageobj.LoginActions(driver);

            HomePage homepageobj = new HomePage();
            homepageobj.GotoEmployeePage(driver);

        }
    
         [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.CreateEmployee(driver);

        }

        [Test, Order(2)]
        public void EditEmployee()
        {
            EmployeePage employeePageObj = new EmployeePage();
            employeePageObj.EditEmployee(driver);
        }

        [Test, Order(3)]
        public void DeleteEmployee()
        {
            EmployeePage employeePageObj = new EmployeePage();
             employeePageObj.DeleteEmployee(driver);
        }

        [TearDown]
        public new void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
