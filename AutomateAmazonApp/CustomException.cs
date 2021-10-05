using System;

namespace AutomateAmazonApp
{
    public class CustomException : Exception
    {
        ExceptionType type;
        public enum ExceptionType
        {

            NO_SUCH_ELEMENT, INVALID_SELECTOR, FILE_NOT_FOUND
        }
        public CustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
