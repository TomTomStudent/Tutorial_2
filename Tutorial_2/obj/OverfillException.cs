using System.Runtime.Serialization;

namespace Tutorial_2.obj
{
    [Serializable]
    internal class OverfillException : Exception
    {
        public OverfillException() : base("Current mass is above payload mass. Oops!") 
        { 
        }

        public OverfillException(string? message) : base(message) 
        { 
        }

        public OverfillException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected OverfillException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}