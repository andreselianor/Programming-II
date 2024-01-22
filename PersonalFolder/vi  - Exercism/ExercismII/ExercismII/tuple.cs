using System;

public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = false;
        bool IsFake = false;
        
        string state = phoneNumber.Substring(0,3);
        string prefix = phoneNumber.Substring(4,3);
        string number = phoneNumber.Substring(8,4);
		
        if(state == "212")
            IsNewYork = true;
		
        if(prefix == "555")
            IsFake = true;
		
        string LocalNumber = number;
		
        return (IsNewYork,IsFake,LocalNumber);
    }
	
    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        bool resultNumber = phoneNumberInfo.Item2;
        return resultNumber;
    }
}