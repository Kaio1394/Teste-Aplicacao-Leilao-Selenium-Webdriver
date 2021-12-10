using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TestandoAplicacaoLeilaoWeb.Helpers;

namespace TestandoAplicacaoLeilaoWeb.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelpers.PastaDoExecutavel());
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
