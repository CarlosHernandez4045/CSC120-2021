using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class DeMorgansTheorem
    {
        public bool SetInputX { get; set; }
        public bool SetInputY { get; set; }
        public bool NotX()
        {
            return !SetInputX;
        }
        public bool NotY()
        {
            return !SetInputY;
        }
        public bool NotThenAnd()
        {
            return NotX() && NotY();
        }
        public bool AndThenNot()
        {
            bool and = SetInputX && SetInputY;

            return !and;
        }
        public bool OrThenNot()
        {
            bool or = SetInputX | SetInputY;

            return !or;
        }
        public bool NotThenOr()
        {
            return NotX() | NotY();
        }
        public bool Or()
        {
            return SetInputX | SetInputY;
        }
    }
}
