using System;
using System.Collections.Generic;
using System.Linq;

namespace TOTD.Errors.Web
{
    public class ErrorWebDetail
    {
        public string Username
        {
            get;
            set;
        }

        public IReadOnlyDictionary<string, string[]> QueryString
        {
            get;
            private set;
        }

        public IReadOnlyDictionary<string, string[]> FormValues
        {
            get;
            private set;
        }

        public IReadOnlyDictionary<string, string[]> Cookies
        {
            get;
            private set;
        }

        public IReadOnlyDictionary<string, string[]> ServerVariables
        {
            get;
            private set;
        }
    }
}
