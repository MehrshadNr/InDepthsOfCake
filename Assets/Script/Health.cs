using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]private Slider slider;
    public float maxHealth;
    public GameObject End;
    public UiManager uiManager;
    public AudioSource audioSource;
    public GameObject aaudioSource;
    public AudioClip audio;
    public Animator animator;


    private void Start()
    {
        if(slider != null)
        {
            slider.maxValue = maxHealth;
            slider.value = maxHealth;
        }
    }
    private void Update()
    {
        if (slider != null)
        {

            if (slider.value == 0)
            {
                Debug.Log("end");
                End.SetActive(true);
                audioSource.clip = audio;
                audioSource.Play();
                aaudioSource.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
    public void TakeDamage(float damage)
    {
        slider.value -=damage;
    }
}
