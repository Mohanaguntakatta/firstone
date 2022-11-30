using Firstone.Pages;
using Firstone.Utilites;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




namespace Firstone.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {
        [Test, Order (1)]
        public void CreateTM_Test()
        {
            HomePage homepageobj = new HomePage();
            homepageobj.GotoTMPage(driver);

            TMPage tmpageobj = new TMPage();
            tmpageobj.CreateTM(driver);
        }

        [Test, Order (2)]
        public void EditTM_Test()
        {

            HomePage homepageobj = new HomePage();
            homepageobj.GotoTMPage(driver);

            TMPage tmpageobj = new TMPage(); 
            tmpageobj.EditTM(driver);
        }

        [Test, Order (3)]
        public void DeleteTM_Test()
        {
            HomePage homepageobj = new HomePage();
            homepageobj.GotoTMPage(driver);

            TMPage tmpageobj = new TMPage(); 
            tmpageobj.DeleteTM(driver);
        }        











    }
}
