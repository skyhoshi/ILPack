using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task Constructor()
        {
            Assert.Equal(("none", "none"), await Invoke(
                $"var r = new MyClass();",
                "(r.CtorStringA, r.CtorStringB)"));
        }

        [Fact]
        public async Task ConstructorCallsBase()
        {
            Assert.Equal(("A", "none"), await Invoke(
                $"var r = new MyClass(\"A\");",
                "(r.CtorStringA, r.CtorStringB)"));
        }

        [Fact]
        public async Task ConstructorCallsThis()
        {
            Assert.Equal(("A", "B"), await Invoke(
                $"var r = new MyClass(\"A\", \"B\");",
                "(r.CtorStringA, r.CtorStringB)"));
        }
    }
}
