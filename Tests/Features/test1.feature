Feature: Cadastro de Empresa

Scenario: Testar inserção de valores nos parâmetros de pesquisa
Given o menu "Cadastro|Empresa"
When informado os valores para os campos
    |Tipo Inscrição                |Número Inscrição    |Razão Social       |Class. Tributária|
    |Sociedade Empresária Limitada |17.756.309/0001-09  |Empresa De Doces   |MEI              |
Then os valores dos campos devem ser
    |Tipo Inscrição                |Número Inscrição    |Razão Social       |Class. Tributária|
    |Sociedade Empresária Limitada |17.756.309/0001-09  |Empresa De Doces   |MEI              |