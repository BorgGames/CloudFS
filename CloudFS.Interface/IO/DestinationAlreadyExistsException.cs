using System;
using System.IO;

namespace IgorSoft.CloudFS.Interfaces.IO
{
    public class DestinationAlreadyExistsException : IOException
    {
        /// <see cref="https://learn.microsoft.com/en-us/windows/win32/debug/system-error-codes--0-499-"/>
        const int ERROR_ALREADY_EXISTS = 183;
        public string FileName { get; }
        public DestinationAlreadyExistsException(string message, string fileName = null, Exception innerException = null)
            : base(message, innerException)
        {
            HResult = Win32.HResult.FromWin32(ERROR_ALREADY_EXISTS);
            FileName = fileName;
        }
    }
}
