using System;

public class SpaceAge
{
    public double secondsOld;    
    
    public SpaceAge(double seconds)
    {
        secondsOld = seconds;
    }

    public double CalculateEarthDays(double seconds, double yearRate)
    {
        return seconds / 60 / 60 / 24 / (365.25 * yearRate);
    }
    public double OnEarth()
    {
        double EarthYearValue = 1;
        return CalculateEarthDays(secondsOld,EarthYearValue);
    }

    public double OnMercury()
    {
        double MercuryYearValue = 0.2408467;
        return CalculateEarthDays(secondsOld,MercuryYearValue);
    }

    public double OnVenus()
    {
        double VenusYearValue = 0.61519726;
        return CalculateEarthDays(secondsOld,VenusYearValue);
    }

    public double OnMars()
    {
        double MarsYearValue = 1.8808158;
        return CalculateEarthDays(secondsOld,MarsYearValue);
    }

    public double OnJupiter()
    {
        double JupiterYearValue = 11.862615;
        return CalculateEarthDays(secondsOld,JupiterYearValue);
    }

    public double OnSaturn()
    {
        double SaturnYearValue = 29.447498;
        return CalculateEarthDays(secondsOld,SaturnYearValue);
    }

    public double OnUranus()
    {
        double UranusYearValue = 84.016846;
        return CalculateEarthDays(secondsOld,UranusYearValue);
    }

    public double OnNeptune()
    {
        double NeptuneYearValue = 164.79132;
        return CalculateEarthDays(secondsOld,NeptuneYearValue);
    }
}