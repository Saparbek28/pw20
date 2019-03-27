using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public delegate void PropertyEventHandler(object sender, string args);
    public interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
}
