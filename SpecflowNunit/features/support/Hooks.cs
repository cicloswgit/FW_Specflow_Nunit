using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowNunit
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer Container;
        private IWebDriver Driver;

        public Hooks(IObjectContainer _Container)
        {
            Container = _Container;
        }

        [BeforeScenario]
        public void IniciarCenarios()
        {
            Driver = Helper.EscolherBrowser("chrome");
            Container.RegisterInstanceAs<IWebDriver>(Driver);
        }
        

        [AfterScenario]
        public void FinalizarTodosOsTestes()
        {
            Helper.CapturarEvidencia(Driver, ScenarioContext.Current.ScenarioInfo.Title);

            if (Driver != null)
            {
                Driver.Close();
                Driver.Quit();
            }
        }
    }
}
