using System.Runtime.InteropServices;

public static class IdleTimeHelper
{
    [StructLayout(LayoutKind.Sequential)]
    private struct LASTINPUTINFO
    {
        public uint cbSize;
        public uint dwTime;
    }

    [DllImport("user32.dll")]
    private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

    public static TimeSpan GetIdleTime()
    {
        var lastInput = new LASTINPUTINFO
        {
            cbSize = (uint)Marshal.SizeOf<LASTINPUTINFO>()
        };

        GetLastInputInfo(ref lastInput);

        uint idleTimeMs = unchecked((uint)Environment.TickCount - lastInput.dwTime);
        return TimeSpan.FromMilliseconds(idleTimeMs);
    }
}