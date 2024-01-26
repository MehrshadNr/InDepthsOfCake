using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public Timer timer;
    private void Update()
    {
        if (gameObject.GetComponent<Timer>().seconds == 0)
        {
            timer.minutes = timer.temp;
            timer.seconds = 0;
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
