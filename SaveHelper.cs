using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    static class SaveHelper
    {
        public static void SaveToFile(string path, params ISavable[] objectsToSave)
        {
            using (var sw = new StreamWriter(path))
            {
                foreach (var item in objectsToSave)
                {
                    item.Save(sw);
                    //var h = item as Human;
                    //if (h != null)
                    //    h.Save(sw);
                    //var b = item as Band;
                    //if (b != null)
                    //    b.Save(sw);

                    //var i = item as Institutioin;
                    //if (i != null)
                    //    i.Save(sw);
            }
            }
        }
    }
}
