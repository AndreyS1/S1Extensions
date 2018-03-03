using Core;
using Xunit;

namespace Tests
{
    public class CommonTests
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

        }

    }
}

//bool? b2 = null;
//bool? b3 = true;
//Console.WriteLine(b2);
//Console.WriteLine(b3);

//b2.Then(x => x == null, 
//() => Console.WriteLine("now  null"));
//b2.Then(x => x == null, 
//x => x = true)
//.ThenNotNull(() => Console.WriteLine("now not null"));

//Console.WriteLine(b2==null);

//b2.IsNull().ThenNotNull(() => Console.WriteLine("not null"))
//.Else(() => Console.WriteLine("null"));