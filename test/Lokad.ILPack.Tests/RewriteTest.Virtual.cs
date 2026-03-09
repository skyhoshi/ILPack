using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task AbstractMethodThroughBase()
        {
            Assert.Equal("MyClass.AbstractMethod", await Invoke(
                "var bt = x as MyBaseClass;  var r = bt.AbstractMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task AbstractMethodThroughImpl()
        {
            Assert.Equal("MyClass.AbstractMethod", await Invoke(
                "var r = x.AbstractMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task VirtualMethodThroughBase()
        {
            Assert.Equal("MyClass.VirtualMethod", await Invoke(
                "var bt = x as MyBaseClass;  var r = bt.VirtualMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task VirtualMethodThroughImpl()
        {
            Assert.Equal("MyClass.VirtualMethod", await Invoke(
                "var r = x.VirtualMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task HiddenMethodThroughBase()
        {
            Assert.Equal("MyBaseClass.HiddenMethod", await Invoke(
                "var bt = x as MyBaseClass;  var r = bt.HiddenMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task HiddenMethodThroughImpl()
        {
            Assert.Equal("MyClass.HiddenMethod", await Invoke(
                "var r = x.HiddenMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task HiddenVirtualMethodThroughBase()
        {
            Assert.Equal("MyBaseClass.HiddenVirtualMethod", await Invoke(
                "var bt = x as MyBaseClass;  var r = bt.HiddenVirtualMethod();",
                "r"
                ));
        }

        [Fact]
        public async Task HiddenVirtualMethodThroughImpl()
        {
            Assert.Equal("MyClass.HiddenVirtualMethod", await Invoke(
                "var r = x.HiddenVirtualMethod();",
                "r"
                ));
        }

    }
}
