#language: pt-BR

@busca_hq
Funcionalidade: Busca Selenium HQ
	A medida que eu acesso o site Selenium HQ
	Como cliente interessado
	Eu desejo manipular elementos em seu formulário


Contexto: Acesso site Selenium HQ
	Dado que eu acesso o site Selenium HQ

@sucesso
Esquema do Cenário: Busca Selenium
	E preencho o campo de busca "<pesquisa>"
	Quando eu clico na acao Go
	Então o sistema apresenta resultado
	Exemplos: 
	|pesquisa	|
	|teste		|
	|selenium	|
	|hq			|
	|webdriver	|

Cenário: Busca Única Selenium
	E preencho o campo de busca <pesquisa>
	|  pesquisa	|
	|teste		|
	Quando eu clico na acao Go
	Então o sistema apresenta resultado