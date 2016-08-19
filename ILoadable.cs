using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface ILoadable
    {
        void Load(StreamReader reader);
    }
}
