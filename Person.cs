using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public class Person : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;
        private string _name;
        private int _age;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, "Name");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, "Age");
                }
            }
        }

    }
}
