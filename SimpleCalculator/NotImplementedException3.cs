using System;
using System.Runtime.Serialization;

namespace SimpleCalculator
{
    [Serializable]
    internal class NotImplementedException3 : Exception
    {
        public NotImplementedException3()
        {
        }

        public NotImplementedException3(string message) : base(message)
        {
        }

        public NotImplementedException3(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NotImplementedException3(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}