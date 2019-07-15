using System;

namespace GLFWDotNet.Utilities
{
    public class GLFWException : Exception
    {
        public int? ErrorCode { get; }

        public GLFWException(string message)
            : base(message)
        {
        }

        public GLFWException(int error, string message)
            : base(message)
        {
            this.ErrorCode = error;
        }
    }
}
