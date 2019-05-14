using System;
using System.Runtime.Serialization;

namespace Fibonachi
{
    [Serializable]
    internal class InitializationException : Exception
    {
        public InitializationException()
        {
        }

        public InitializationException(string message) : base(message)
        {
        }

        public InitializationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected InitializationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public string Message { get; set; }
    }
}