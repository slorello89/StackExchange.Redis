// EXAMPLE: set_and_get
// HIDE_START

using StackExchange.Redis;
using Xunit;
namespace ExamplesTest;

public class UnitTest1
{
    [Fact]
    public void SetAndGet()
    {
        // HIDE_END
        var redis = ConnectionMultiplexer.Connect("localhost:6379");
        var db = redis.GetDatabase();

        db.StringSet("bike:1", "Process 134");

        var value = db.StringGet("bike:1");

        // HIDE_START
        Assert.Equal("Process 134", value);

    }
}
// HIDE_END
