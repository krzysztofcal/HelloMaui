using HelloMaui.Core;

namespace HelloMaui.Tests;

public class CounterMessageFormatterTests
{
    [Theory]
    [InlineData(-1, "Click me")]
    [InlineData(0, "Click me")]
    [InlineData(1, "Clicked 1 time")]
    [InlineData(3, "Clicked 3 times")]
    public void GetMessage_returns_expected_text(int count, string expected)
    {
        var message = CounterMessageFormatter.GetMessage(count);

        Assert.Equal(expected, message);
    }
}
