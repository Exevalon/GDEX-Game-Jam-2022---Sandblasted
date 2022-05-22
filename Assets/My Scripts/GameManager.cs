using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    FloatVariable playerHP;

    private void Awake()
    {
        playerHP.runtimeValue = playerHP.initialValue;
    }
}
