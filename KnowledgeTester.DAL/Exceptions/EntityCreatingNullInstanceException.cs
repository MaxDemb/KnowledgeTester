using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace DAL.EntityFramework.Exceptions
{
    public class ArgumentEntityNullInstanceException : ArgumentException
    {
        public ArgumentEntityNullInstanceException()
        {
        }

        public ArgumentEntityNullInstanceException(string message, string paramName) : base(message, paramName)
        {
        }

        public ArgumentEntityNullInstanceException(string message, string paramName, Exception inner) : base(message, paramName, inner)
        {
        }

        protected ArgumentEntityNullInstanceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
