using System;
using System.Collections.Generic;
using System.Text;

namespace Man
{
    class InValidManStudentException : Exception
    {
        public InValidManStudentException(string e)
        {
            Console.WriteLine(e);
        }
    }
}
