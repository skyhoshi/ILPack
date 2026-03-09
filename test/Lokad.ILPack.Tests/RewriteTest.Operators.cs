using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lokad.ILPack.Tests
{
    partial class RewriteTest
    {
        [Fact]
        public async Task OperatorBinary()
        {
            Assert.Equal((40, 60), await Invoke(
                $"var s = new MyStruct(10,20) + new MyStruct(30, 40);",
                "(s.x,s.y)"));
        }

        [Fact]
        public async Task OperatorUnary()
        {
            Assert.Equal((-10, -20), await Invoke(
                $"var s = -(new MyStruct(10,20));",
                "(s.x,s.y)"));
        }

        [Fact]
        public async Task OperatorCastExplicit()
        {
            Assert.Equal("[10,20]", await Invoke(
                $"string s = new MyStruct(10,20);",
                "s"));
        }

        [Fact]
        public async Task OperatorCastImplicit()
        {
            Assert.Equal(5.5, await Invoke(
                $"double r = (double)new MyStruct(1, 10);",
                "r"));
        }

    }
}
