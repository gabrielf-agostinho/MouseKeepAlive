using System.Runtime.InteropServices;

public static class MouseHelper
{
    [DllImport("user32.dll")]
    private static extern bool GetCursorPos(out POINT lpPoint);

    [DllImport("user32.dll")]
    private static extern bool SetCursorPos(int X, int Y);

    private struct POINT
    {
        public int X;
        public int Y;
    }

    private static readonly Random _random = new();

    public static void MoveNaturally()
    {
        GetCursorPos(out var start);

        int offsetX = _random.Next(-40, 40);
        int offsetY = _random.Next(-30, 30);

        var end = new POINT
        {
            X = start.X + offsetX,
            Y = start.Y + offsetY
        };

        MoveSmooth(start, end, steps: _random.Next(25, 45));
        Thread.Sleep(_random.Next(300, 600));
        MoveSmooth(end, start, steps: _random.Next(20, 40));
    }

    private static void MoveSmooth(POINT from, POINT to, int steps)
    {
        for (int i = 1; i <= steps; i++)
        {
            double t = (double)i / steps;

            // interpolação suave (ease-in-out)
            double smoothT = t * t * (3 - 2 * t);

            int x = (int)(from.X + (to.X - from.X) * smoothT + Noise());
            int y = (int)(from.Y + (to.Y - from.Y) * smoothT + Noise());

            SetCursorPos(x, y);

            Thread.Sleep(_random.Next(8, 15));
        }
    }

    private static int Noise()
    {
        return _random.Next(-1, 2); // micro variação humana
    }
}