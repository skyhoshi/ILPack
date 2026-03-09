using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task Pinned()
        {
            Assert.Equal(10, await Invoke(
                "var r = x.Pinned(new int[] { 1, 2, 3, 4 });",
                "r"));
        }
    }
}
