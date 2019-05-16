using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using BoDi;
using Framework.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace HyperCubeTest
{
    [Binding]
    public class DriverSetup
    {
        private string driversPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/../../../drivers/";
        private IObjectContainer _objectContainer;
        private IWebDriver Driver;
        public DriverSetup(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        { 
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Firefox:
                    Driver = new FirefoxDriver(driversPath);
                    break;

                case BrowserType.Chrome:
                    Driver = new ChromeDriver(driversPath);
                    break;

                case BrowserType.IExplorer:
                    Driver = new InternetExplorerDriver(driversPath);
                    break;
                default:
                    throw new Exception("Driver Not Found: " + ObjectRepository.Config.GetBrowser());
            }
            _objectContainer.RegisterInstanceAs(Driver);
            Driver.Manage().Window.Size = new Size(1342,735);
            Driver.Manage().Window.Position = new Point(0,0);
            Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebSite());
        }
    }
}
