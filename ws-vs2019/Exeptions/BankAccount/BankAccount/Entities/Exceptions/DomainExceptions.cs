using System;


namespace BankAccount.Entities
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {

        }
    }
}
