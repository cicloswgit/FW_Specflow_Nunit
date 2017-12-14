using TechTalk.SpecFlow;
using OpenQA.Selenium;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNunit
{
    [Scope(Tag = "busca_hq")]
    [Binding]
    public class BuscaHQ_Steps
    {

        private BuscaHQ Busca;

        public BuscaHQ_Steps(IWebDriver _Driver)
        {
            Busca = new BuscaHQ(_Driver);
        }

        [Given(@"preencho o campo de busca ""(.*)""")]
        public void PreenchoBusca(string texto)
        {
            Busca.PreencherBusca(texto);    
        }

        [Given(@"preencho o campo de busca (.*)")]
        public void PreenchoBusca(string nome_parametro, Table table)
        {
            var TabelaDados = new TabelaPesquisa().RecuperarObjeto(table);
            Busca.PreencherBusca(TabelaDados.Pesquisa);
        }


        [When(@"eu clico na acao Go")]
        public void ClicoGo()
        {
            Busca.SubmeterBusca();
        }

        [Then(@"o sistema apresenta resultado")]
        public void VejoResultado()
        {
            Busca.ValidarResultado();
        }
        
    }
}
