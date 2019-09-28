using System;
using System.IO;

namespace SCFE
{
    public class FileException : IOException
    {
        public FileException()
        {
        }

        public FileException(string message) : base(message)
        {
        }

        public FileException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}