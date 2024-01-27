using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPortal : MonoBehaviour
{
    public float temp;
    public GameObject portal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        temp -= 1 * Time.deltaTime;
        if (temp <= 0)
        {
            portal.SetActive(true);
            //temp = temp2;
        }
    }

    public void _portal()
    {
            portal.SetActive(true);

    }
}
