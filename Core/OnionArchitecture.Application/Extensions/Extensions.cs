using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Application
{
    public static class Extensions
    {
        public static bool IsAny<T>(this IEnumerable<T> list)
        {
            return list != null && list.Any() ? true : false;
        }
    }
}
