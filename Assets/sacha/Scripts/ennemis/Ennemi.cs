using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi : MonoBehaviour
{
    [Header("DropItemRandom")]
    public GameObject[] items;

    [Header("LifeEnnemis")]
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
        int rand = Random.Range(0, items.Length);
        Instantiate(items[rand], transform.position, Quaternion.identity);
    }
}
