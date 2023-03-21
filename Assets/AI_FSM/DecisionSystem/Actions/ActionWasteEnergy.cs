using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionWasteEnergy : IAction
{
    /// <summary>
    /// lose energy when doing anything
    /// </summary>


    /// the game object with condition tired
    public GameObject eventReceiver;

    public float degradeRate;

    public override void Act()
    {
        Debug.Log("degrading");
        eventReceiver.GetComponent<ConditionIsTired>().getTired(Time.deltaTime * degradeRate);
    }
    
}
