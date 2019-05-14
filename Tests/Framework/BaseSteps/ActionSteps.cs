using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
namespace HyperCubeTest
{
    [Binding]
    public class ActionSteps
    {
        private ActionPage actionPage => new ActionPage(_driver);
        private IWebDriver _driver;

        public ActionSteps(IWebDriver driver)
        {
            _driver = driver;
        }

        [Given(@"a ação do botão ""(.*)""")]
        [When(@"acionado o botão ""(.*)""")]
        public void PressionadoOBotao(string button)
        {
            actionPage.clickButton(button);
        }
    }
}
