using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;

    private void Update()
    {
        transform.position = playerTransform.position + new Vector3(1, 2f, -10f);;
    }
}
