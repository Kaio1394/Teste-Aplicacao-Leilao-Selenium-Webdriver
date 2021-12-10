using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TestandoAplicacaoLeilaoWeb.Fixtures
{
    [CollectionDefinition("Chrome Driver")]
    public class CollectionFixture : ICollectionFixture<TestFixture>
    {
    }
}
