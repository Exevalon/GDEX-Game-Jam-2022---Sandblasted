using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DebugStuff : MonoBehaviour
{
    public InputAction exitGame;

    private void OnEnable()
    {
        exitGame.Enable();
    }

    private void OnDisable()
    {
        exitGame.Disable();
    }

    void Update()
    {
        if(exitGame.triggered)
            Application.Quit();
    }
}
