using System;


namespace ExFixacao.Entities.Exceptions
{
    class ForbiddenOperation : ApplicationException
    {
        public ForbiddenOperation(string message) : base(message) { }
    }
}
