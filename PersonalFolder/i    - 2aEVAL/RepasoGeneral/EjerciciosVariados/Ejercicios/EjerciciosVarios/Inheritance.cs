using System;

namespace EjerciciosVarios
{
    public abstract class Inheritance
    {
        protected int year;

        public Inheritance(int year)
        {
            this.year = year;
        }
        public virtual int GetDate()
        {
            return year;
        }
        public virtual int GetDay()
        {
            return year;
        }
    }

    public class Child : Inheritance
    {
        protected int month;

        public Child(int month) : base(1)
        {
            this.month = month;
        }
        public override int GetDate()
        {
            return month;
        }

        public override int GetDay()
        {
            return month;
        }
    }
    public class Grandson: Child
    {
        protected int day;

        public Grandson(int day) : base(2)
        {
            this.day = day;
        }
        public override int GetDate()
        {
            return day;
        }
        public override int GetDay()
        {
            return day;
        }
    }
}
