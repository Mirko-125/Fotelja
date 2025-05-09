using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float moveSpeedY;
    [SerializeField] private float moveSpeedX;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        HandYPush();
        HandXSteer();
    }

    void HandYPush()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, -moveSpeedY);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0);
        }
    }

    void HandXSteer()
    {
        rb.velocity = new Vector2(moveSpeedX * Input.GetAxisRaw("Horizontal"), rb.velocity.y);
    }
}
