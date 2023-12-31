﻿using System;
using System;
using System.Collections.Generic;

public class Robot
{
    private string _name = "";
    private List<string> _robotList = new List<string>();

    public Robot()
    {
        GenerateRandomName();
    }

    public string Name => _name;

    public void GenerateRandomName()
    {
        Random random = new Random();
        string name = "";
        for (int i = 0; i < 2; i++)
        {
            name += Convert.ToChar(random.Next(65, 91));
        }

        for (int i = 0; i < 3; i++)
        {
            name += Convert.ToChar(random.Next(48, 58));
        }

        SetName(name);

    }

    public void SetName(string name)
    {
        if (_robotList.Contains(name))
            Reset(name);
        AddName(name);
    }


    public void AddName(string name)
    {
        _name = name;
        _robotList.Add(name);
    }

    public void Reset(string name)
    {
        _robotList.Remove(name);
        _name = "";
        GenerateRandomName();
    }
}