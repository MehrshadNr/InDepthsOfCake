using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject aaudioSource;
    public AudioClip audio;
    public Animator animator;

    public void ReStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void BackToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void End()
    {
        audioSource.clip = audio;
        audioSource.Play();
        aaudioSource.SetActive(false);
        //animator.enabled = true;
    }
}
