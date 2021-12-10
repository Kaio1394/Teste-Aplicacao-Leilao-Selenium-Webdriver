using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TestandoAplicacaoLeilaoWeb.Fixtures;
using Xunit;

namespace TestandoAplicacaoLeilaoWeb
{
    [Collection("Chrome Driver")]
    public class AplicacaoLeilao
    {
        private IWebDriver driver;

        public AplicacaoLeilao(TestFixture fixture)
        {
            driver = fixture.Driver;
        }
        [Fact]
        public void RegistrandoUmaContaNaAplicacao()
        {
            // Dado que eu acesso a p�gina.
            driver.Navigate().GoToUrl("http://localhost:5000/");

            // Quando eu preecho os campos para registro de uma nova conta.
            driver.FindElement(By.Id("Nome")).SendKeys("Ksio");
            driver.FindElement(By.Id("Email")).SendKeys("kaio.santiago.13@hotmail.com");
            driver.FindElement(By.Id("Password")).SendKeys("1234");
            driver.FindElement(By.Id("ConfirmPassword")).SendKeys("1234");

            // E clico no bot�o Registrar.
            driver.FindElement(By.Id("btnRegistro")).Click();

            // Ent�o Capturo o t�tulo da p�gina
            Assert.Contains("Obrigado", driver.PageSource);
        }
    }
}
