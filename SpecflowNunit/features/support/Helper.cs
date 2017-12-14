using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SpecflowNunit
{
    public sealed class Helper
    {
        public const string URL = "http://www.seleniumhq.org/";
        public const string Caminho_Pasta = "C:\\EvidenciasSpec\\";

        public static void CapturarEvidencia(IWebDriver Driver, string NomeArquivo)
        {
            ITakesScreenshot Camera = Driver as ITakesScreenshot;
            Screenshot Evidencia = Camera.GetScreenshot();
            Evidencia.SaveAsFile(Caminho_Pasta+NomeArquivo+".png", ScreenshotImageFormat.Png);
        }

        public static IWebDriver EscolherBrowser(string Browser)
        {
            if (Browser.Equals("chrome"))
            {
                return new ChromeDriver();
            }
            else if (Browser.Equals("ie"))
            {
                return new InternetExplorerDriver();
            }
            else
            {
                return new FirefoxDriver();
            }
        }
    }
}
