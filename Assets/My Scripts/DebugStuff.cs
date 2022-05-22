using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DebugStuff : MonoBehaviour
{
    public InputAction exitGame;
    public InputAction restartGame;

    private void OnEnable()
    {
        exitGame.Enable();
        restartGame.Enable();
    }

    private void OnDisable()
    {
        exitGame.Disable();
        restartGame.Disable();
    }

    void Update()
    {
        if(exitGame.triggered)
            Application.Quit();

        if(restartGame.triggered)
            SceneManager.LoadScene(0);
    }
}
