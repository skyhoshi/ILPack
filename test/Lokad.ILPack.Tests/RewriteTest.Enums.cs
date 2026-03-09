using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task BasicEnumTest()
        {
            Assert.Equal(150, await Invoke(
                $"int r = (int)MyEnum.Pears;",
                "r"));
        }

    }
}
