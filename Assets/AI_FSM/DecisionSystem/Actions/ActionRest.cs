using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.EventSystems.EventTrigger;

public class ActionRest : IAction
{
    /// <summary>
    /// the game object with condition tired
    /// </summary>
    public GameObject eventReceiver;

    public float timeTorest;

   
    public void Play()
    {
        Act();
    }
    public override void Act()
    {
        Debug.Log("resting");
        regenEnergy();
    }
   
    private IEnumerator regenEnergy()
    {
        yield return new WaitForSeconds(timeTorest);
        eventReceiver.GetComponent<ConditionIsTired>().regenEnergy();
    }
}
