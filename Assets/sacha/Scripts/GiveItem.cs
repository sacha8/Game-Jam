using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveItem : MonoBehaviour
{
    [Header("ItemDonnateHache")]
    public Inventory inv;
    public GameObject hache;
    [Header("OpenDoor")]
    public bool iHaveHache = false;
    public GameObject PorteEnBoit;
    public Ennemi AIdestroy;
    public GameObject Spawner;

    private void Start()
    {
        hache.SetActive(false);
    }

}
