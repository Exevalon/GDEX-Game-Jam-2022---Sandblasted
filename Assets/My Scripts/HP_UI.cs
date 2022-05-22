using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HP_UI : MonoBehaviour
{
    TextMeshProUGUI textMeshProUGUI;
    [SerializeField]
    FloatVariable playerHP;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void OnGUI()
    {
        textMeshProUGUI.text = "LIFE:" + playerHP.runtimeValue.ToString();
    }
}
