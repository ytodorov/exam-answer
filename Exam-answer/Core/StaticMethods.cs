using System;
using System.Runtime.InteropServices;

namespace Core
{
    public static class StaticMethods
    {
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        static extern void GetSystemTimePreciseAsFileTime(out long filetime);

        public static long GetTicksNow()
        {
            long fileTime;
            GetSystemTimePreciseAsFileTime(out fileTime);
            var offset = DateTimeOffset.FromFileTime(fileTime);
            var ticks = offset.Ticks;

            return ticks;
        }
    }
}
