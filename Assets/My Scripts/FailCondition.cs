using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailCondition : MonoBehaviour
{
    IEnumerator coroutine;
    [SerializeField]
    FloatVariable playerHP;
    [SerializeField]
    GameObject player;

    // Update is called once per frame
    void Update()
    {
        if(playerHP.runtimeValue <= 0)
        {
            playerHP.runtimeValue = 0;
            coroutine = RestartGame();
            StartCoroutine(coroutine);
            player.SetActive(false);
        }
    }

    IEnumerator RestartGame()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(0);
    }
}
