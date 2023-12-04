using System;

namespace Exercism
{
    public class RemoteControlCar
    {
        private double _meters = 0.0;
        private double _battery = 100.0;

        public static RemoteControlCar Buy()
        {
            RemoteControlCar car = new RemoteControlCar();
            return car;
        }

        public string DistanceDisplay()
        {
            return $"Driven {_meters} meters";
        }

        public string BatteryDisplay()
        {
            if (_battery > 0)
                return $"Battery at {_battery}%";
            return "Battery empty";
        }

        public void Drive()
        {
            if (_battery <= 0)
            {
                _meters += 0;
            }
            else
            {
                _meters += 20.0;
                _battery -= 1.0;
            }
        }
    }
}

