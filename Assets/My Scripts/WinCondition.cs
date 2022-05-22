using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    IEnumerator coroutine;

    [SerializeField]
    GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        //player wins if they reach this
        if (other.gameObject.tag == "Player")
            winText.SetActive(true);

        // Upon winning, we need to go to next scene or credits or play some sort of fanfare
        coroutine = RestartGame();
        StartCoroutine(coroutine);
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
