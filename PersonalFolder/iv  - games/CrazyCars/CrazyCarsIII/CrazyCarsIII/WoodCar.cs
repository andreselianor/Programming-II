﻿namespace CrazyCarsIII
{
    public class WoodCar
    {
        private double _position;

        public double Position => _position;

        public void Simulate()
        {
            _position += 15;
        }
    }
}
