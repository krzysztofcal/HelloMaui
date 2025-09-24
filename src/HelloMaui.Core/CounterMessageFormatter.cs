namespace HelloMaui.Core;

public static class CounterMessageFormatter
{
    public static string GetMessage(int count)
    {
        if (count <= 0)
        {
            return "Click me";
        }

        return count == 1 ? "Clicked 1 time" : $"Clicked {count} times";
    }
}
