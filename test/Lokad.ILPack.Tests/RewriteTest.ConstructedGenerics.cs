using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    public partial class RewriteTest
    {
        [Fact]
        public async Task GenericStructInt()
        {
            Assert.Equal(5, await Invoke(
                @"var r = x.GenericStructInt;",
                "r.Value"
                ));
        }

        [Fact]
        public async Task GenericStructConstructedMethod()
        {
            Assert.Equal("Hello Generic World!", await Invoke(
                @"var r = x.GenericStructConstructedMethod(""Hello Generic World!"");",
                "r.Value"
                ));
        }

        [Fact]
        public async Task GenericClassInt()
        {
            Assert.Equal(5, await Invoke(
                @"var r = x.GenericClassInt;",
                "r.Value"
            ));
        }

        [Fact]
        public async Task GenericClassConstructedMethod()
        {
            Assert.Equal("Hello Generic World!", await Invoke(
                @"var r = x.GenericClassConstructedMethod(""Hello Generic World!"");",
                "r.Value"
            ));
        }
    }
}
