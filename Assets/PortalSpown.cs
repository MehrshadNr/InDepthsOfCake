using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSpown : MonoBehaviour
{
    public GameObject enemy;
    public GameObject Player;
    public Timer time;
    public bool canSpown;

    private void Start()
    {

    }
    private void Update()
    {
        if(canSpown)
        {
            if (time.minutes == 0 && time.seconds == 0)
            {
                GameObject b = Instantiate(enemy, transform.position, transform.rotation);
                b.GetComponent<Portal>().portalSpown = gameObject.GetComponent<PortalSpown>();
                b.GetComponent<Portal>().timer = time;
                canSpown = false;
            }
        }
    }
}
