using NerdStore.WebApp.MVC;
using NerdStore.WebApp.Tests.Config;
using System;
using Xunit;

namespace NerdStore.WebApp.Tests
{
    public class UsuarioTests
    {
        private readonly IntegrationTestsFixture<StartupWebTests> _testsFixture;

        public UsuarioTests(IntegrationTestsFixture<StartupWebTests> testsFixture)
        {
            _testsFixture = testsFixture;
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
