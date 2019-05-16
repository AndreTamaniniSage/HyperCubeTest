using OpenQA.Selenium;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace HyperCubeTest
{
    [Binding]
    public class NavigationSteps
    {
        private NavigationPage navPage => new NavigationPage(_driver);
        private IWebDriver _driver;

        public NavigationSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"a tela inicial")]
        public void NavegaTelaInicial()
        {
            navPage.OpenInitialUrl();
        }

        [Given(@"o menu (.*)")]
        [When(@"acessado o menu (.*)")]
        public void OMenu(string menuPath)
        {
            navPage.NavigateByMenu(menuPath);
        }
    }
}
