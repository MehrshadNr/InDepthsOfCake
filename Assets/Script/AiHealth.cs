using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AiHealth : MonoBehaviour
{
    public float maxHealth;
    public float hp;
    public GameObject a;
    private void Start()
    {
            hp = maxHealth;
    }
    private void Update()
    {
          if (hp == 0)
          {
                 Destroy(gameObject);
            dead();
          }
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
    }

    public void dead()
    {
        Instantiate(a, transform.position, transform.rotation);
    }
}
