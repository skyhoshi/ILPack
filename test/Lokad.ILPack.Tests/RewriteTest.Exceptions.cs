using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task ThrowGuardedException()
        {
            Assert.Equal(true, await Invoke(
                $"var r = x.ThrowGuardedException();",
                "r"
                ));
        }

        [Fact]
        public async Task ThrowGuardedExceptionWithFinally()
        {
            Assert.Equal(0b0000_0111, await Invoke(
                $"int r = 0; x.ThrowGuardedExceptionWithFinally(ref r);",
                "r"
                ));
        }

        [Fact]
        public async Task ThrowNestedGuardedExceptionWithFinally()
        {
            Assert.Equal(0b0111_0111, await Invoke(
                $"int r = 0; x.ThrowNestedGuardedExceptionWithFinally(ref r);",
                "r"
                ));
        }

        [Fact]
        public async Task ThrowGuardedExceptionWithUntypedCatchAndFinally()
        {
            Assert.Equal(0b0000_0111, await Invoke(
                $"int r = 0; x.ThrowGuardedExceptionWithUntypedCatchAndFinally(ref r);",
                "r"
                ));
        }

    }
}
