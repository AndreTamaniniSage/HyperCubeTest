Feature: Cadastro de Empresa

Cenário: Testar inserção de valores nos parâmetros de pesquisa
Dado o menu "Cadastro|Empresa"
Quando informado os valores para os campos
    |Tipo Inscrição                |Número Inscrição    |Razão Social       |Class. Tributária|
    |Sociedade Empresária Limitada |17.756.309/0001-09  |Empresa De Doces   |MEI              |
Então os valores dos campos devem ser
    |Tipo Inscrição                |Número Inscrição    |Razão Social       |Class. Tributária|
    |Sociedade Empresária Limitada |17.756.309/0001-09  |Empresa De Doces   |MEI              |



#Scenario: TestCenario2
#Given a tela inicial
#Given o valor "teste" para o campo "teste" 