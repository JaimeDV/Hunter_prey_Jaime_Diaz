using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestorDeEventos : MonoBehaviour
{
    public delegate void PressSpaceAction(float value);
    public static event PressSpaceAction onSpacePressed;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onSpacePressed(1.5f);
        }
    }
}
