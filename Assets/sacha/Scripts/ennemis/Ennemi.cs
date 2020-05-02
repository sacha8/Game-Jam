using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public int LifeMax = 50;
    int currentHealth;
    public GameObject particulDed;

    void Start()
    {
        currentHealth = LifeMax;
    }

    private void Update()
    {
        if (currentHealth <= 0)
        {
            
            
        }
    }

    public void TakeDommage(int dommage)
    {
        currentHealth -= dommage;


        if(currentHealth <= 0)
        {
            Instantiate(particulDed, transform.position, Quaternion.identity);
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
