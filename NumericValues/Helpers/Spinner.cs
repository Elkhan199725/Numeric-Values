using System;
using System.Threading;

namespace NumericValues.Helpers;

public class Spinner : IDisposable
{
    private const string Sequence = @"/-\|";  // Rotating spinner symbols
    private int counter = 0;
    private readonly int left;
    private readonly int top;
    private readonly int delay;
    private bool active;
    private readonly Thread thread;
    private readonly ConsoleColor spinnerColor;

    public Spinner(int left, int top, int delay = 100, ConsoleColor color = ConsoleColor.Green)
    {
        this.left = left;
        this.top = top;
        this.delay = delay;
        this.spinnerColor = color;
        thread = new Thread(Spin) { IsBackground = true };  // Ensures thread doesn't prevent app from closing
    }

    public void Start()
    {
        active = true;
        if (!thread.IsAlive)
            thread.Start();
    }

    public void Stop()
    {
        active = false;
        thread.Join(); // Ensures the thread properly stops
        ClearSpinner();
    }

    private void Spin()
    {
        while (active)
        {
            Turn();
            Thread.Sleep(delay);
        }
    }

    private void Draw(char c)
    {
        Console.SetCursorPosition(left, top);
        Console.ForegroundColor = spinnerColor;
        Console.Write(c);
        Console.ResetColor();
    }

    private void Turn()
    {
        Draw(Sequence[++counter % Sequence.Length]);
    }

    private void ClearSpinner()
    {
        Console.SetCursorPosition(left, top);
        Console.Write(' '); // Clears the spinner
    }

    public void Dispose()
    {
        Stop();
    }
}
