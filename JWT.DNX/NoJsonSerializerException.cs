using System;

namespace JWT
{
    public class NoJsonSerializerException : Exception
    {
        public NoJsonSerializerException()
            : base("You need to set a JSON serializer. You only need to do this once")
        { }
    }
}
