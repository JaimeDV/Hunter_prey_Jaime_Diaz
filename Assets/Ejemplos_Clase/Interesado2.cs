using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interesado2 : MonoBehaviour
{
    private void Start()
    {
        GestorDeEventos.onSpacePressed += MoveDown;
    }

    private void OnDestroy()
    {
        GestorDeEventos.onSpacePressed -= MoveDown;
    }


    private void MoveDown(float distance)
    {
        transform.position += -Vector3.up * distance;
    }
}
