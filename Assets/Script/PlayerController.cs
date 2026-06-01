using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D)) ]

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;

    Animate animate;

    private Rigidbody2D rb;
    private Vector3 movementVector;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animate = GetComponent<Animate>();
    }
    void Update()
    {
        movementVector.x = Input.GetAxisRaw("Horizontal");
        movementVector.y = Input.GetAxisRaw("Vertical");
        
        animate.moveX = movementVector.x;
        animate.moveY = movementVector.y;

        rb.linearVelocity = new Vector2(movementVector.x, movementVector.y).normalized * speed;
    }
}
