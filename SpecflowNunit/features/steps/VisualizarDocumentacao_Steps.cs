using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace SpecflowNunit
{
    [Scope(Tag = "documentacao")]
    [Binding]
    public class VisualizarDocumentacao_Steps
    {

        private readonly IWebDriver Driver;
        private WebDriverWait Wait;
        
        public VisualizarDocumentacao_Steps(IWebDriver _Driver)
        {
            Driver = _Driver;
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(50));
        }
                
        
        [When(@"clico no link Documents")]
        public void ClicoLinkDocuments()
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Documentation"))).Click();
        }
        
        [Then(@"eu visualizo sua pagina de documentacao")]
        public void VisualizoDocumentacao()
        {
            StringAssert.Contains("http://www.seleniumhq.org/docs/", Driver.Url);
        }
        
    }
}
