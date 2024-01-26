using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiHealth : MonoBehaviour
{
    public float maxHealth;
    public float hp;
    private void Start()
    {
            hp = maxHealth;
    }
    private void Update()
    {
            if (hp == 0)
            {
                Destroy(gameObject);
            }
    }
    public void TakeDamage(float damage)
    {
        hp -= damage;
    }
}
