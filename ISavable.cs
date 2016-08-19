using System.IO;
using System.Text;

namespace Inheritance
{
    public interface ISavable
    {
        void Save(StreamWriter writer);
    }
}