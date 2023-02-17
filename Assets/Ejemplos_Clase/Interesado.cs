using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interesado : MonoBehaviour
{
    /*
    private void Start()
    {
        GestorDeEventos.onSpacePressed += MoveUppwards;
    }

    private void OnDestroy()
    {
        GestorDeEventos.onSpacePressed -= MoveUppwards;
    }
    */

    private void OnEnable()
    {
        GestorDeEventos.onSpacePressed += MoveUppwards;
    }

    private void OnDisable()
    {
        GestorDeEventos.onSpacePressed -= MoveUppwards;
    }


    private void MoveUppwards(float distance)
    {
        transform.position += Vector3.up * distance;
    }
}
