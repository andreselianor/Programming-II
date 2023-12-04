using System;

namespace Exercism
{
    class RemoteControlCarv2
    {
        private int _speed;
        private int _battery;
        private int _batteryDrain;
        private int _position;

        public RemoteControlCarv2(int speed, int batteryDrain)
        {
            _speed = speed;
            _battery = 100;
            _batteryDrain = batteryDrain;
        }

        public int Speed => _speed;
        public int Battery => _battery;
        public int BatteryDrain => _batteryDrain;

        public bool BatteryDrained()
        {
            return (_battery <= 0 || _battery < _batteryDrain);
        }

        public int DistanceDriven()
        {
            return _position;
        }

        public void Drive()
        {
            if (_battery >= _batteryDrain)
                _position += _speed;

            _battery -= _batteryDrain;
        }

        public static RemoteControlCarv2 Nitro()
        {
            RemoteControlCarv2 car = new RemoteControlCarv2(50, 4);
            return car;
        }
    }


    class RaceTrack
    {
        private int _distance;

        public RaceTrack(int distance)
        {
            _distance = distance;
        }

        public bool TryFinishTrack(RemoteControlCarv2 car)
        {
            return (car.Battery / car.BatteryDrain) * car.Speed >= _distance;
        }
    }
}

