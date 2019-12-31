using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lap04.Data
{
    interface ClassInterface<T>
    {
        Task<bool> Them(T obj);
        Task<bool> CapNhap(T obj);
        Task<bool> Xoa(T obj);

    }
}
