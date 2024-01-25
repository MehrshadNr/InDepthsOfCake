using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class ShootingSystem : MonoBehaviour
{
    private Camera minCam;
    private Vector3 mousePose;


    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;

    private void Start()
    {
        minCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    private void Update()
    {
        // Mouse Aim
        mousePose = minCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePose - transform.position;

        float rotZ = math.atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,rotZ);

        // Shooting
        if(Input.GetMouseButton(0) && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, bulletTransform.rotation);
        }

        if(!canFire)
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring)
            {
                canFire=true;
                timer = 0;
            }
        }
    }
}
