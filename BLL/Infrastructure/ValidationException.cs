﻿using System;

namespace BLL.Infrastructure
{
    public class ValidationException : Exception
    {
        public ValidationException(string message, Exception innerException) 
            : base(message, innerException)
        {
        }

        public ValidationException(string message) 
            : base(message)
        {
        }
    }
}