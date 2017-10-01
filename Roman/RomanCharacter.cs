using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman
{
    class RomanCharacter
    {

        public int Value { get; private set; }
        public string Character { get; private set; }

        public RomanCharacter(int value, string character)
        {
            Value = value;
            Character = character;
        }
    }
}
