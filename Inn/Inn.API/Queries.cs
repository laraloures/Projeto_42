using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Inn.Inn.API
{
    interface Queries<T>
    {
        void insert();
        T selectAll();
        void delete();
        void updade();
    }
}
