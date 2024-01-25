using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force = 40;
    public float EnrmyForce = 1000;

    private void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        rb = GetComponent<Rigidbody2D>();
        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 direction = mousePos - transform.position;
        Vector3 rotation = transform.position - mousePos;
        rb.velocity = new Vector2 (direction.x, direction.y).normalized * force;
        float rot = math.atan2(rotation.y, rotation.x) * Mathf.Deg2Rad;
        //transform.rotation = Quaternion.Euler(0,0,rot + 90);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("2");
        if (col.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("1");
            //col.gameObject.GetComponent<Rigidbody2D>().AddForce(-transform.forward * EnrmyForce);
            Destroy(gameObject);
        }
    }
}
