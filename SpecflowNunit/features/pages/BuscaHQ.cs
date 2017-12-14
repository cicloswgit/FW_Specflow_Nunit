using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowNunit
{
    public class BuscaHQ
    {
        private readonly IWebDriver Driver;
        private static WebDriverWait Wait;

        public BuscaHQ(IWebDriver _Driver)
        {
            Driver = _Driver;
            PageFactory.InitElements(Driver, this);
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
        }
        

        [FindsBy(How = How.Id, Using = "q")]
        private IWebElement CampoBusca { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#submit")]
        private IWebElement BotaoGo { get; set; }

        
        public void PreencherBusca(string texto)
        {
            Wait.Until(Campo => CampoBusca.Displayed);
            CampoBusca.SendKeys(texto);
        }

        public void SubmeterBusca()
        {
            Wait.Until(Botao => CampoBusca.Displayed && CampoBusca.Enabled);
            BotaoGo.Click();
        }

        public void ValidarResultado()
        {
            Wait.Until(ExpectedConditions.UrlContains("https://cse.google.com/cse?"));

            StringAssert.Contains("https://cse.google.com/cse?", Driver.Url);
        }

    }
}
