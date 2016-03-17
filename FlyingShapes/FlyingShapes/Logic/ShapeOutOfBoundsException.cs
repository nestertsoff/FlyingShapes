namespace FlyingShapes.Logic
{
    using System;
    using System.Runtime.Serialization;

    public class ShapeOutOfBoundsException : Exception
    {
        public ShapeOutOfBoundsException()
        {
        }

        public ShapeOutOfBoundsException(string message) : base(message)
        {
        }

        public ShapeOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ShapeOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
