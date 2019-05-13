using OpenQA.Selenium;
using TechTalk.SpecFlow;
namespace HyperCubeTest
{
    [Binding]
    public class ValueSteps
    {

        private ValuePage valuePage => new ValuePage(_driver);
        private IWebDriver _driver;

        public ValueSteps(IWebDriver driver)
        {
            _driver = driver;
        }


        [Given(@"o valor ""(.*)"" para o campo ""(.*)""")]
        [When(@"informado valor ""(.*)"" para o campo ""(.*)""")]
        public void OValorParaOCampo(string value, string field) => valuePage.InsereOValorParaOCampo(value, field);
    }
}
