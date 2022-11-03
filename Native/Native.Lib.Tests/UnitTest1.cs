
namespace Native.Lib.Tests;

using Xunit;
using Native.Lib;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal(3u, NativeInterop.Compile("str"));
    }
}