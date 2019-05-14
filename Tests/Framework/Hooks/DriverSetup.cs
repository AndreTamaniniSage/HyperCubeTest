using System;
using System.IO;
using System.Reflection;
using BoDi;
using Framework.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TechTalk.SpecFlow;

namespace HyperCubeTest
{
    [Binding]
    public class DriverSetup
    {
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
                    Driver = new FirefoxDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;

                case BrowserType.Chrome:
                    Driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;

                case BrowserType.IExplorer:
                    Driver = new InternetExplorerDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                    break;
                default:
                    throw new Exception("Driver Not Found: " + ObjectRepository.Config.GetBrowser());
            }

            _objectContainer.RegisterInstanceAs(Driver);
        }
    }
}
