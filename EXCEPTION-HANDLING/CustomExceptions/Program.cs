using System;
using System.Runtime.Serialization;

namespace CustomExceptions
{
    class Program
    {
        //creating a custom class and inheriting base class Excemption
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLoggedInException("user is logged in  -  no duplicate sessions");
            }
            catch (UserAlreadyLoggedInException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        [Serializable]
        public class UserAlreadyLoggedInException : Exception
        {
            public UserAlreadyLoggedInException(string message) : base(message)
            {
            }
            public UserAlreadyLoggedInException(string message ,Exception innerExcemption) : base(message ,innerExcemption)
            {
            }
            public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info , context)
            {
            }
        }
    }
}
