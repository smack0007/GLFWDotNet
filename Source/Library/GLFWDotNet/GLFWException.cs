using System;

namespace GLFWDotNet
{
    public class GLFWException : InvalidOperationException
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
