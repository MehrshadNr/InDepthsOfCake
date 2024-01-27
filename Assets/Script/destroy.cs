using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    public float time = 2;
    private void Start()
    {
        Destroy(gameObject,time);
    }
}
