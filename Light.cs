using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Light
    {
        private int Level;
        private int Hour;

        public Light(int level,int hour)
        {
            Level = level;
            Hour = hour;
        }
        public Light()
        {
        }
        public int _level
        {
            set
            {
                Level = value;
            }
            get
            {
                return Level;
            }
        }

        public int _hour { get => Hour; set => Hour = value; }
    }
}
