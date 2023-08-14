using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrappers
{
    public class DataResult<T> : Result, IBaseDataResult<T>
    {
        public DataResult(T dataValue, bool success, string message) : base(success, message)
        {
            DataValue = dataValue;
        }

        public DataResult(T dataValue, bool success) : base(success)
        {
            DataValue = dataValue;
        }
        public T DataValue { get; set; }
    }
}
