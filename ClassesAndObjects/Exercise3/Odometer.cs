using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    class Odometer
    {
        private int _currentMileage;
        private const int _maxMileage = 999999;
        private const int _minMileage = 0;
        private FuelGauge _fuelGauge;

        public Odometer(FuelGauge _fuelGauge)
        {
            this._fuelGauge = new FuelGauge();
        }

        public int ReportMileage()
        {
            return _currentMileage;
        }

        public bool MaxMileage()
        {
            bool succsesful = true;
            if (_fuelGauge.ReportLevel() > 0)
            {
                if (_currentMileage < _maxMileage)
                {
                    _currentMileage++;
                }
                else
                {
                    _currentMileage = 0;
                }

                if (_currentMileage % 10 == 0)
                {
                    _fuelGauge.DecreaseOfFuel();
                }
            }
            else
            {
                Console.WriteLine($"Fuel level is: {_fuelGauge.ReportLevel()}, please fill up your fuel tank!");
                succsesful = false;
            }
            return succsesful;
        }
    }
}
