using UnityEngine;

public class PickUpFer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.addFer(1);
            Destroy(gameObject);
        }
    }
}

