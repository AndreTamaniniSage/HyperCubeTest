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

        [Given(@"a ação do botão (.*)")]
        [When(@"acionado o botão (.*)")]
        public void PressionadoOBotao(string button)
        {
            actionPage.ClickButton(button);
        }

        [Given(@"que a opção (.*) esteja (.*)")]
        [When(@"a opção (.*) estiver (.*)")]
        public void MarcadaAOpcao(string option, string action)
        {
            actionPage.ClickCheckBoxComboBox (option, action);
        }

        [Given(@"que as opções estejam")]
        [When(@"as opções estiverem")]
        public void MarcadaAOpcao(Table table)
        {
            var rowValores = table.Rows[0];

            foreach (var nomeCampo in table.Header)
            {
            actionPage.ClickCheckBoxComboBox (nomeCampo, rowValores[nomeCampo]);
            }
        }

        [Then(@"a opção (.*) deve estar (.*)")]
        public void AOpcaoDeveEstar(string option, string conditionWaited)
        {   
           if(conditionWaited.ToUpper().Equals("MARCADA"))
               Assert.IsTrue(actionPage.ReturnCheckBoxComboBoxCondition(option));

           if(conditionWaited.ToUpper().Equals("DESMARCADA"))
                    Assert.IsFalse(actionPage.ReturnCheckBoxComboBoxCondition(option));
        }

        [Then(@"as opções devem estar")]
        public void AsOpcoesDevemEstar(Table table)
        {   
             var rowValores = table.Rows[0];

            foreach (var nomeCampo in table.Header)
            {
                if(rowValores[nomeCampo].ToUpper().Equals("MARCADA"))
                    Assert.IsTrue(actionPage.ReturnCheckBoxComboBoxCondition(nomeCampo));

                if(rowValores[nomeCampo].ToUpper().Equals("DESMARCADA"))
                    Assert.IsFalse(actionPage.ReturnCheckBoxComboBoxCondition(nomeCampo));               
            }

        }

    }  
}
