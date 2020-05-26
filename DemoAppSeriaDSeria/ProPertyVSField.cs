
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAppSeriaDSeria
{
    [Serializable]
    class ProPertyVSField
    {
        private string _myField;

        public string Name; // Field should not be Public Tahole dot dile peye jabe.
        public string MyProperty
        {
            get
            {
                return _myField;
            }
            set
            {
                _myField = value;
            }
        }
        public int AnotherProperty { get; set; }
    }
}
