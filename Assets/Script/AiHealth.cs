using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHealth : MonoBehaviour
{
    public float maxHealth;
    public float hp;
    public AudioSource audioSource;
    public AudioClip audio;
    private void Start()
    {
            hp = maxHealth;
    }
    private void Update()
    {
            if (hp == 0)
            {
               //  audioSource.Play();
           // Destroy(gameObject);
            }
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
    }
}
