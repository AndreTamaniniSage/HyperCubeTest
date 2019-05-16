using NUnit.Framework;
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

        [Given(@"o valor (.*) para o campo (.*)")]
        [When(@"informado o valor (.*) para o campo (.*)")]
        public void OValorParaOCampo(string value, string field)
        {
            valuePage.InsertValueToField(value, field);
        }

        [Given(@"o valores para os campos")]
        [When(@"informado os valores para os campos")]
        public void OValoresParaOsCampos(Table table)
        {
            var rowValores = table.Rows[0];

            foreach (var nomeCampo in table.Header)
            {
                valuePage.InsertValueToField(rowValores[nomeCampo],nomeCampo);
            }
        }

        [Then(@"o valor do campo (.*) deve ser (.*)")]
        public void OValorDoCampoDeveSer(string value, string field)
        {
            Assert.AreEqual(value, valuePage.ReturnValueFromField(field));
        }

        [Then(@"os valores dos campos devem ser")]
        public void OsValoresDosCamposDevemSer(Table table)
        {
            var rowValores = table.Rows[0];

            foreach (var nomeCampo in table.Header)
            {
            Assert.AreEqual(rowValores[nomeCampo], valuePage.ReturnValueFromField(nomeCampo));
            }
        }
    }
}
