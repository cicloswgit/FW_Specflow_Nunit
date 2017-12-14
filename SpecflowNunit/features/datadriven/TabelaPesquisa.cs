using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNunit
{
    public class TabelaPesquisa
    {
        public TabelaPesquisa()
        {
            
        }

        public TabelaPesquisa(string _Pesquisa)
        {
            Pesquisa = _Pesquisa;
        }

        public string Pesquisa { get; set; }

        public TabelaPesquisa RecuperarObjeto(Table Table)
        {
            TabelaPesquisa Tabela = Table.CreateInstance<TabelaPesquisa>();
            ScenarioContext.Current.Set(Tabela);

            return Tabela;
        }
    }
}
