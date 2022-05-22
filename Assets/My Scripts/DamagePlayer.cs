using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    [SerializeField]
    FloatVariable playerHP;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
            playerHP.runtimeValue -= 1;
    }
}
