using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyText : MonoBehaviour
{
    IEnumerator coroutine;

    private void Start()
    {
        coroutine = RestartGame();
        StartCoroutine(coroutine);
    }
    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
