using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task Nullable()
        {
            Assert.Equal(false, await Invoke(
                $"var r = x.GetNullable();",
                "r"
            ));
        }
    }
}
