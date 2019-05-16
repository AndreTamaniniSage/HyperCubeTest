Funcionalidade: Cadastro de Empresa
Cenário: Testar inserção de valores nos parâmetros de pesquisa
Dado o menu Cadastro|Empresa
Quando informado os valores para os campos
| Tipo Inscrição                | Número Inscrição   | Razão Social     |
| Sociedade Empresária Limitada | 17.756.309/0001-09 | Empresa De Doces |
Então os valores dos campos devem ser
| Tipo Inscrição                | Número Inscrição   | Razão Social     |
| Sociedade Empresária Limitada | 17.756.309/0001-09 | Empresa De Doces |
Cenário: Testar inserção de valores nos parâmetros de cadastro da Empresa
Dado o menu Cadastro|Empresa
Quando acionado o botão Novo
E informado os valores para os campos
| Contrato                      | Número Inscrição | Razão Social | Natureza Jurídica |
| Sociedade Empresária Limitada | 17.756.309/0001  | Empr         | indi              |
E as opções estiverem
| Entidade Educativa | Empresa de Trabalho Temporário |
| Marcada            | Marcada                        |
Então os valores dos campos devem ser
| Contrato                      | Número Inscrição | Razão Social | Natureza Jurídica |
| Sociedade Empresária Limitada | 17.756.309/0001  | Empr         | indi              |
E as opções devem estar
| Entidade Educativa | Empresa de Trabalho Temporário |
| Marcada            | Marcada                        |