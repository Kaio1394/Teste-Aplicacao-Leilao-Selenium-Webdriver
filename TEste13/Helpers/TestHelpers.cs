using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;


namespace TestandoAplicacaoLeilaoWeb.Helpers
{
    public class TestHelpers
    {
        public static string PastaDoExecutavel()
        {
            var driver = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return driver;
        }
    }  
}
