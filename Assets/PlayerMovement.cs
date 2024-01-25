using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    float SpeedY, SpeedX;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        SpeedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        SpeedY = Input.GetAxisRaw("Vertical") * moveSpeed;
        rb.velocity = new Vector2(SpeedX, SpeedY);
    }
}