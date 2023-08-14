using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application.Wrappers
{
    internal interface IBaseDataResult<T> : IBaseResult
    {
        T DataValue { get; set; }
    }
}
