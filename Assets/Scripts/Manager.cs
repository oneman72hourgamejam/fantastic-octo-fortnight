using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager
{
    private int a;
    public int A => a;

    public Manager(int _a)
    {
        a = _a;
    }

    public int Add(int a)
    {
        a = a + 2;
        return a;
    }
}


