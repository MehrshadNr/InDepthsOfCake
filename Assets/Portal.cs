using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public Timer timer;
    public PortalSpown portalSpown;
    private void Update()
    {
        if (gameObject.GetComponent<Timer>().seconds == 0)
        {
            timer.minutes = 1;
            timer.seconds = 0;
            portalSpown.canSpown = true;
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
