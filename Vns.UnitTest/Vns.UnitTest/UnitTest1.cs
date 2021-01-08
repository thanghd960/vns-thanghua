using System;
using Vns.Core.Commons;
using Xunit;

namespace Vns.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string url = FriendlyUrlHelper.GetFriendlyTitle("Hứa Đại Thắng");
            Console.WriteLine(url);

        }
    }
}
