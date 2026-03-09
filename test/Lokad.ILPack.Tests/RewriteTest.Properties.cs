using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task ReadOnlyProperty()
        {
            Assert.Equal(23, await Invoke(
                "",
                "x.ReadOnlyProperty"));
        }

        [Fact]
        public async Task WriteOnlyProperty()
        {
            Assert.Equal(true, await Invoke(
                "x.WriteOnlyProperty = 99;",
                "true"));
        }

        [Fact]
        public async Task ReadWriteOnlyProperty()
        {
            Assert.Equal(101, await Invoke(
                "x.ReadWriteProperty = 101;",
                "x.ReadWriteProperty"));
        }

        [Fact]
        public async Task WrappedSingleton()
        {
            Assert.Equal(default(string), await Invoke(
                "",
                "x.WrappedSingleton"));
        }
    }
}
