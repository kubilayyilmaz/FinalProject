using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Readonly propertyler constructor'da set edilebilir.

        public Result(bool success, string message) : this(success) //Bu constructor çalıştığı anda, tek parametreli constructorı'da benim yerime çalıştır
        {
            Message = message;

        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}