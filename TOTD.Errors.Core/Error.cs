using System;
using System.Collections.Generic;
using System.Linq;

namespace TOTD.Errors.Core
{
    public class Error : Error<int>
    {
    }

    public class Error<TKey>
    {
        public TKey ID
        {
            get;
            set;
        }

        public DateTimeOffset WhenOccurred
        {
            get;
            set;
        }

        public string ErrorType
        {
            get;
            set;
        }

        public string ErrorSource
        {
            get;
            set;
        }

        public string ErrorMessage
        {
            get;
            set;
        }

        public string StackTrace
        {
            get;
            set;
        }

        public string Username
        {
            get;
            set;
        }

        protected object Detail
        {
            get;
            set;
        }
    }
}
