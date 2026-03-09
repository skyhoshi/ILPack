using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task ExtensionMethod()
        {
            Assert.Equal("HelloWorldHelloWorld", await Invoke(
                $"var r = \"HelloWorld\".Repeated();",
                "r"));
        }
    }
}
