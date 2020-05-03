using UnityEngine;

public class CraftItem : MonoBehaviour
{
    [Header("ItemDonnateHache")]
    public Inventory inv;
    public GameObject hache;
    [Header("OpenDoor")]
    public bool iHaveHache = false;
    public GameObject PorteEnBoit;
    public Ennemi AIdestroy;
    public GameObject Spawner;

    void Start()
    {
        hache.SetActive(false);
    }

}
