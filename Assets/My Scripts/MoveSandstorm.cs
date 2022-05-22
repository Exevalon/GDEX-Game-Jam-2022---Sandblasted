using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandstorm : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0.05f, 0, 0);
    }
}
