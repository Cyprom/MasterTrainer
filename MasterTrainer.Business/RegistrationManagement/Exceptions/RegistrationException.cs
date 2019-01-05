using System;

namespace MasterTrainer.Business.RegistrationManagement.Exceptions
{
    public class RegistrationException : Exception
    {
        public RegistrationException(string message) : base(message) { }
    }
}
