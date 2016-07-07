using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {
        private string _name;

        public MyClass()
        {
        }

        //public string Name
        //{
        //    get { return _name; }
        //    set { _name = value; }
        //}

        public MyClass(string _name)
        {
            this._name = _name;
        }
    }
}
