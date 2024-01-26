using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spown : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Player;
     float time = 1;
    public float temp;
    public float temp2;

    private void Update()
    {
        temp -= time * Time.deltaTime;
        if (temp <= 0)
        {
            GameObject b = Instantiate(enemy, transform.position, transform.rotation);
            temp = temp2;
        }
    }
}
