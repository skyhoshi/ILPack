using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task NestedClass()
        {
            Assert.Equal(9, await Invoke(
                $"var r = new MyClass.NestedClass().Method();",
                "r"
            ));
        }
    }
}
