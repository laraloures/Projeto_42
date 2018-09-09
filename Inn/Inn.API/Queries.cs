using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_42.Inn.Inn.API
{
    interface Queries<T>
    {
        string connectionString;
        void insert();
        T selectAll();
        void delete();
        void updade();
    }
}
