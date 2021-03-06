// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HyperCubeTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Cadastro de Empresa")]
    public partial class CadastroDeEmpresaFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CadastroEmpresa.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Cadastro de Empresa", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Testar inserção de valores nos parâmetros de pesquisa")]
        public virtual void TestarInsercaoDeValoresNosParametrosDePesquisa()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Testar inserção de valores nos parâmetros de pesquisa", null, ((string[])(null)));
#line 2
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 3
testRunner.Given("o menu Cadastro|Empresa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Tipo Inscrição",
                        "Número Inscrição",
                        "Razão Social"});
            table7.AddRow(new string[] {
                        "Sociedade Empresária Limitada",
                        "17.756.309/0001-09",
                        "Empresa De Doces"});
#line 4
testRunner.When("informado os valores para os campos", ((string)(null)), table7, "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Tipo Inscrição",
                        "Número Inscrição",
                        "Razão Social"});
            table8.AddRow(new string[] {
                        "Sociedade Empresária Limitada",
                        "17.756.309/0001-09",
                        "Empresa De Doces"});
#line 7
testRunner.Then("os valores dos campos devem ser", ((string)(null)), table8, "Então ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Testar inserção de valores nos parâmetros de cadastro da Empresa")]
        public virtual void TestarInsercaoDeValoresNosParametrosDeCadastroDaEmpresa()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Testar inserção de valores nos parâmetros de cadastro da Empresa", null, ((string[])(null)));
#line 10
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 11
testRunner.Given("o menu Cadastro|Empresa", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 12
testRunner.When("acionado o botão Novo", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Contrato",
                        "Número Inscrição",
                        "Razão Social",
                        "Natureza Jurídica"});
            table9.AddRow(new string[] {
                        "Sociedade Empresária Limitada",
                        "17.756.309/0001",
                        "Empr",
                        "indi"});
#line 13
testRunner.And("informado os valores para os campos", ((string)(null)), table9, "E ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Entidade Educativa",
                        "Empresa de Trabalho Temporário"});
            table10.AddRow(new string[] {
                        "Marcada",
                        "Marcada"});
#line 16
testRunner.And("as opções estiverem", ((string)(null)), table10, "E ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Contrato",
                        "Número Inscrição",
                        "Razão Social",
                        "Natureza Jurídica"});
            table11.AddRow(new string[] {
                        "Sociedade Empresária Limitada",
                        "17.756.309/0001",
                        "Empr",
                        "indi"});
#line 19
testRunner.Then("os valores dos campos devem ser", ((string)(null)), table11, "Então ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "Entidade Educativa",
                        "Empresa de Trabalho Temporário"});
            table12.AddRow(new string[] {
                        "Marcada",
                        "Marcada"});
#line 22
testRunner.And("as opções devem estar", ((string)(null)), table12, "E ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
