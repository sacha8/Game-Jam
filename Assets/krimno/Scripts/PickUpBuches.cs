using UnityEngine;

public class PickUpBuches : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Inventory.instance.addBuches(1);
            Destroy(gameObject);
        }
    }
}
