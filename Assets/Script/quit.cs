using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class quit : MonoBehaviour
{
    public void Quit()
    {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
    }
}
