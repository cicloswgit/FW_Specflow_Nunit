using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowNunit
{

    [Binding]
    public class Menu_Steps
    {
        private readonly IWebDriver Driver;
        private static WebDriverWait Wait;
        
        public Menu_Steps(IWebDriver _Driver)
        {
            Driver = _Driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
        }

        [Given(@"que eu acesso o site Selenium HQ")]
        public void AcessoSite()
        {
            Driver.Navigate().GoToUrl(Helper.URL);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMinutes(2);

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
        }

    }
}
