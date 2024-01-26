using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{
    public GameObject enemy;
    public float time;
     float temp;
     float temp2;

    private void Start()
    {
        temp = time;
        temp2 = time;
    }
    private void Update()
    {
        temp -= time * Time.deltaTime;
        if (temp <= 0)
        {
            Instantiate(enemy, transform.position, transform.rotation);
            temp = temp2;
        }
    }
}
