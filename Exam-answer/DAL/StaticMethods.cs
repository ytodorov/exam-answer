using System;
using System.Runtime.InteropServices;

namespace Core
{
    public static class StaticMethods
    {
        [DllImport("Kernel32.dll", CallingConvention = CallingConvention.Winapi)]
        private static extern void GetSystemTimePreciseAsFileTime(out long filetime);

        public static long GetTicksNow()
        {
            long fileTime;
            GetSystemTimePreciseAsFileTime(out fileTime);
            DateTimeOffset offset = DateTimeOffset.FromFileTime(fileTime);
            long ticks = offset.Ticks;

            return ticks;
        }
    }
}