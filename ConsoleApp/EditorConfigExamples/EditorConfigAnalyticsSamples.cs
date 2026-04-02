namespace ConsoleApp.EditorConfigExamples;

public interface sampleProcessor
{
    void Process();
}

public sealed class EditorConfigAnalyticsSamples : sampleProcessor
{
    private readonly int _configuredValue = 10;
    int _mutableButNeverChanged = 5;

    public void Process()
    {
        int param = 2;
        _mutableButNeverChanged++;
        var number = 42;
        int current = this._mutableButNeverChanged;
        bool positive = number > 0 ? true : false;



        if (positive == true)
            Console.WriteLine($"Configured: {_configuredValue}, Current: {current}");

    }

    public static void Run()
    {
        EditorConfigAnalyticsSamples sample = new();
        sample.Process();

        string? text = null;
        bool hasText = text != null ? true : false;

        if (object.ReferenceEquals(text, null))
        {
            Console.WriteLine($"Text is null: {hasText}");
        }

        try
        {
            throw new Exception();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}