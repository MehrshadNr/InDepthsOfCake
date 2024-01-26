using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    [HideInInspector] public bool MultiplyBullet;
    [HideInInspector]public float force = 40;

    //test

    private void Start()
    {
        if (MultiplyBullet)
        {

        }
        else
        {
            mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
            rb = GetComponent<Rigidbody2D>();
            mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 direction = mousePos - transform.position;
            Vector3 rotation = transform.position - mousePos;
            rb.velocity = new Vector2(direction.x, direction.y).normalized * force;
            float rot = math.atan2(rotation.y, rotation.x) * Mathf.Deg2Rad;

        }

        Destroy(gameObject, 5);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("2");
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("1");
            AiChase ai = col.gameObject.GetComponent<AiChase>();
            ai.test();
            Destroy(gameObject);
        }
        //Destroy(gameObject);
    }
}
