using System;
using System.Collections.Generic;
using System.Text;

namespace IgorSoft.CloudFS.Interfaces.Win32
{
    static class HResult
    {
        public static int FromWin32(int errorCode) => unchecked((int)0x80070000 | errorCode);
    }
}
