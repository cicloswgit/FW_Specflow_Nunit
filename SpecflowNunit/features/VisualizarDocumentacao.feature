#language: pt-BR
@documentacao
Funcionalidade: Visualizar Documentacao

	A medida que eu acesso o site do Selenium HQ
	Como cliente interessado ou estudante
	Eu desejo visualizar sua documentacao

Contexto: Acesso site Selenium HQ
	Dado que eu acesso o site Selenium HQ

@sucesso
Cenario: Visualizar Documentação com sucesso
	Quando clico no link Documents
	Então eu visualizo sua pagina de documentacao
