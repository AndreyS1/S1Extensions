using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using Xunit;

namespace Tests
{
    public class BooleanTests
    {
        [Fact]
        public void BooleanIf()
        {
            var tmp1 = "";
            var tmp2 = "";

            true.IfTrue(() =>
            {
                tmp1 = "true";
            }).IfFalse(() =>
            {
                tmp2 = "false";
            });

            Assert.Equal("true", tmp1);
            Assert.Equal("", tmp2);

            (new List<string>()).Any()
                .IfTrue(() => tmp1 = "true2")
                .IfFalse(() => tmp2 = "false2");

            Assert.Equal("true", tmp1);
            Assert.Equal("false2", tmp2);
        }

        [Fact]
        public void BooleanNot()
        {
            var tmp1 = "";
            var tmp2 = "";

            false.Not().IfTrue(() =>
            {
                tmp1 = "true";
            }).IfFalse(() =>
            {
                tmp2 = "false";
            });

            Assert.Equal("true", tmp1);
            Assert.Equal("", tmp2);

            (new List<string>()).Any().Not().Not()
                .IfTrue(() => tmp1 = "true2")
                .IfFalse(() => tmp2 = "false2");

            Assert.Equal("true", tmp1);
            Assert.Equal("false2", tmp2);
        }
    }
}

