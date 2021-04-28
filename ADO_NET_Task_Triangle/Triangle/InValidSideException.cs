using System;
using System.Collections.Generic;
using System.Text;

namespace Triangle
{
    class InValidSideException : Exception
    {
        public InValidSideException(string e)
        {
            Console.WriteLine(e);
        }
    }
}
