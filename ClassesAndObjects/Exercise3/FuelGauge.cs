using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class FuelGauge
    {
        private int _fuelLevel;
        private const int _maxFuelLevel = 70;
        private const int _minFuelLevel = 0;

        public int ReportLevel()
        {
            return _fuelLevel;
        }
        public void IncreaseOfFuel()
        {
            if (_fuelLevel < _maxFuelLevel)
            {
                _fuelLevel++;
            }
        }
        public void DecreaseOfFuel()
        {
            if (_fuelLevel > _minFuelLevel)
            {
                _fuelLevel--;
            }
            
        }


    }
}
