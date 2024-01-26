using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShootingSystem : MonoBehaviour
{
    private Camera minCam;
    private Vector3 mousePose;


    public float force = 40;
    public float MultiplyGunforce = 40;
    private Rigidbody2D rb;
    public GameObject bulletPrefab;
    public GameObject MultiplybulletPrefab;
    public Transform bulletTransform;
    private bool canFire = true;
    public bool MultiplyBullet;
    private float timer;
    public float timeBetweenFiring;

    //test
    public int amuntOfBullet;
    public float ofset;
    public float spread;

    private void Start()
    {
        minCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }
    private void Update()
    {
        // Mouse Aim
        if (MultiplyBullet)
        {
            mousePose = minCam.ScreenToWorldPoint(Input.mousePosition);
            float angle = math.atan2(mousePose.y, mousePose.x) * Mathf.Deg2Rad;
            transform.rotation = Quaternion.AngleAxis(angle + ofset, Vector3.forward);
        }
        else
        {
            mousePose = minCam.ScreenToWorldPoint(Input.mousePosition);
        }

        Vector3 rotation = mousePose - transform.position;

        float rotZ = math.atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        // Shooting
        if (Input.GetMouseButton(0) && canFire)
        {
            if(MultiplyBullet)
            {
                _MultiplyBullet();
                canFire = false;
            }
            else
            {
                canFire = false;
                GameObject b = Instantiate(MultiplybulletPrefab, bulletTransform.position, bulletTransform.rotation);
                Rigidbody2D brb = b.GetComponent<Rigidbody2D>();
                Vector2 dir = transform.rotation * -Vector2.left;
                Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(0, 0);
                brb.velocity = (dir + pdir) * MultiplyGunforce;

                b.gameObject.GetComponent<BulletScript>().force = MultiplyGunforce;
                b.gameObject.GetComponent<BulletScript>().MultiplyBullet = true;
            }
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

    public void _MultiplyBullet()
    {
        for (int i = 0; i < amuntOfBullet; i++)
        {
            GameObject b = Instantiate(MultiplybulletPrefab, bulletTransform.position, bulletTransform.rotation);
            Rigidbody2D brb = b.GetComponent<Rigidbody2D>();
            Vector2 dir = transform.rotation * -Vector2.left;
            Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-spread, spread);
            brb.velocity = (dir + pdir) * MultiplyGunforce;

            b.gameObject.GetComponent<BulletScript>().force = MultiplyGunforce;
            b.gameObject.GetComponent<BulletScript>().MultiplyBullet = true;
        }
    }
}
