using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrappers
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T dataValue, bool success, string message) : base(dataValue, false, message)
        {
            DataValue = dataValue;
        }
        public ErrorDataResult(T dataValue) : base(dataValue, false)
        {
        }
    }
}
