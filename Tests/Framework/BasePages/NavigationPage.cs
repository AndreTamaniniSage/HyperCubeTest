using OpenQA.Selenium;
using TechTalk.SpecFlow;
namespace HyperCubeTest
{
    [Binding]
    public class NavigationPage
    {
        private IWebDriver _driver;

        public NavigationPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void OpenInitialUrl(){
             _driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebSite());
        }
    }
}