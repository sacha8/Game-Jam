using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    public int LifeMax = 50;
    int currentHealth;
    public GameObject particulDed;
    public Animator animator;
    public AudioSource Hurt;

    void Start()
    {
        currentHealth = LifeMax;
    }

    public void TakeDommage(int dommage)
    {
        currentHealth -= dommage;
        animator.SetTrigger("EnnemiBlesser");
        Hurt.Play();
        
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
