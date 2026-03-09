using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task CallExplicitlyImplementedInterfaceMethod()
        {
            Assert.Equal(1001, await Invoke(
                $"int r = (x as IMyItf).InterfaceMethod1();",
                "r"));
        }

        [Fact]
        public async Task CallImplicitlyImplementedInterfaceMethodThroughInterface()
        {
            Assert.Equal(1002, await Invoke(
                $"int r = (x as IMyItf).InterfaceMethod2();",
                "r"));
        }

        [Fact]
        public async Task CallImplicitlyImplementedInterfaceMethodThroughClass()
        {
            Assert.Equal(1002, await Invoke(
                $"int r = x.InterfaceMethod2();",
                "r"));
        }

        [Fact]
        public async Task CallExplicitlyImplementedGenericInterfaceMethod()
        {
            Assert.Equal(4711, await Invoke(
                $"int r = (x as IMyItf).InterfaceMethod3<int>(() => 4711);",
                "r"));
        }

        [Fact]
        public async Task ImplementImportedInterface()
        {
            Assert.Equal(1, await Invoke(
                $"var a = new MyComparable(10); var b = new MyComparable(20);",
                "a.CompareTo(b)"
                ));
        }

        [Fact]
        public async Task ImplementImportedGenericInterface()
        {
            Assert.Equal(1, await Invoke(
                $"var a = new MyComparableT(10); var b = new MyComparableT(20);",
                "a.CompareTo(b)"
                ));
        }

    }
}
