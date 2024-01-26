using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField]private Slider slider;
    public float maxHealth;
    public GameObject End;
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                TakeDamage(5);
            }

            if (slider.value == 0)
            {
                Debug.Log("end");
                End.SetActive(true);
                Destroy(gameObject);
            }
        }
    }
    public void TakeDamage(float damage)
    {
        slider.value -=damage;
    }
}
