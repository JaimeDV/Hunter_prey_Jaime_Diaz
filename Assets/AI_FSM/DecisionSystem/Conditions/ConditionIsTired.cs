using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Checks if "target" is is tired.
/// Doing anything tires the target
/// </summary>
public class ConditionIsTired : ICondition
{

    public float energy;
    public float energyCap;
    public override bool Test()
    {
        if (energy <= 0)
        {
            Debug.Log("tired D:");
            return true;
        }
        Debug.Log("Energy :D");
        return false;
    }
    public void regenEnergy()
    {
        Debug.Log("resting :D");
        energy = energyCap;
    }
    public void getTired(float value)
    {
        Debug.Log("getting tired D:");
        energy -= value;
    }
    private void Update()//for debug
    {
        Debug.Log(energy + " energy");
    }

}
