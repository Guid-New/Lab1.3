using System;

namespace Lab1_2.Logic
{
    public class IncorrectSystemRequirementsException : Exception
    {
        public IncorrectSystemRequirementsException(string message):base(message)
        {
            
        }
    }
}