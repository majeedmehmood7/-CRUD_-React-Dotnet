using System.Runtime.Serialization;

namespace Backend.Controllers
{
    [Serializable]
    internal class DbupdateConcurrencyException : Exception
    {
        public DbupdateConcurrencyException()
        {
        }

        public DbupdateConcurrencyException(string? message) : base(message)
        {
        }

        public DbupdateConcurrencyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected DbupdateConcurrencyException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}