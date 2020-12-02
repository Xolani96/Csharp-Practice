using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class KeyValuPair<Tkey, Tvalue>
    {
        //Generic field , it cannot be initialized.
        public Tkey Key { get; set; }
        //Generic field , it cannot be initialized.
        public Tvalue Value { get; set; }
    }
}
