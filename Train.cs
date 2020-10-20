using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Train
    {
        private int HourTrain;
        private int HourRead;
        private int MinForRead;
        private List<Light> _levels;

        public Train(int hourTrain, int hourRead, int minForRead)
        {
            MinForRead = minForRead;
            HourTrain = hourTrain;
            HourRead = hourRead;
            _levels = new List<Light>();
        }

        public int _minForRead { get => MinForRead; set => MinForRead = value; }
        public int _hourRead { get => HourRead; set => HourRead = value; }
        public int _hourTrain { get => HourTrain; set => HourTrain = value; }
        internal List<Light> Levels { get => _levels; set => _levels = value; }

        public void addLevel(Light level)
        {
            _levels.Add(level);
        }
        public void PrintRead() {
            foreach (Light light in _levels) {
                if (light._level >= MinForRead) {
                    Console.Write("{0}:{1} ",light._hour,light._level);
                }
                
            }
        }
    }
}
