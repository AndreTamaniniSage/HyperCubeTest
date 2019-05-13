using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace HyperCubeTest
{   
    [Binding]
    public class ValuePage
    {
        private IWebDriver _driver;

        public ValuePage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void InsereOValorParaOCampo(string value, string field) => _driver.FindElement(By.Id("txtUsuario")).SendKeys(value);
    }
}
