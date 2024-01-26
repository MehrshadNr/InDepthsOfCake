using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    float SpeedY, SpeedX;
    public bool canMove = true;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        if (canMove)
        {
            SpeedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
            SpeedY = Input.GetAxisRaw("Vertical") * moveSpeed;
            rb.velocity = new Vector2(SpeedX, SpeedY);


            //Audio
            if (SpeedX != 0 || SpeedY != 0)
            {

            }
        }

    }
}