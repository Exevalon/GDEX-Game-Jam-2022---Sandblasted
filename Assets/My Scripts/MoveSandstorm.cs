using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSandstorm : MonoBehaviour
{
    public float speed;
    Vector3 targetPosition;

    private void Update()
    {
        targetPosition = new Vector3(targetPosition.x + 0.05f, 0, 0);
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * speed);
    }
}
