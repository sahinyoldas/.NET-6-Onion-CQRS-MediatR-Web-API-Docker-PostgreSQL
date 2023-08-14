using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrappers
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T dataValue, string message) : base(dataValue, true, message)
        {
        }
    }
}
