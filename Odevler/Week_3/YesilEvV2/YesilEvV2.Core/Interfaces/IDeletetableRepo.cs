using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YesilEvV2.Core.Interfaces
{
    public interface IDeletetableRepo<T> : IRepo<T> where T : class
    {
        T Delete(T item);
    }
}
