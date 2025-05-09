using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerCamera : MonoBehaviour
{
    Transform player;
    float startOffset;

    void Start()
    {
        player = FindObjectOfType<HandMovement>().transform;
        startOffset = transform.position.y - player.position.y;
    }

    void Update()
    {
        transform.position = new Vector3(0f, player.position.y + startOffset, -10f);
    }
}
