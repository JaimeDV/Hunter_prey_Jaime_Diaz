using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegados : MonoBehaviour
{
    public delegate void MyDelegate();
    public MyDelegate myMethod;

    delegate int MyIntDelegate(int value);
    MyIntDelegate myIntMethod;

    // Start is called before the first frame update
    void Start()
    {
        myIntMethod = MaxHundredValue;
        myIntMethod(120);

        myIntMethod = Multiply;
        myIntMethod(2);
    }

    public void Disapear()
    {
        // Code
    }

    public int MaxHundredValue(int value)
    {
        if(value > 100)
        {
            return 100;
        }

        return value;
    }

    public int Multiply(int baseNum)
    {
        return baseNum * 2;
    }
}
