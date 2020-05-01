using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    public int Health;
    public int Potions;
    public int degats;

    public Text vie;

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        Health = 100;
        vie.text = "Vie : " + Health;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {
                if(inventory.isFull[i] == false)
                {
                    // ON peut mettre les item dans l'inventaire
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }

    private void Update()
    {
        
    }

    public void decreaseHealth()
    {
        vie.text = "Vie : " + (Health -= degats); 
    }

    public void AddHealth()
    {
        vie.text = "Vie : " + (Health += Potions);
    }
}
