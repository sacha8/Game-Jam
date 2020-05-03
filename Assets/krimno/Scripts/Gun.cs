using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Inventory inv;
    public GameObject pistolet;
    public GameObject hache;
    public GiveItem giveItem;

    public void Start()
    {
        pistolet.SetActive(false);
    }

    private void Update()
    {
        GivePistolet();
    }

    void GivePistolet()
    {
        if (inv.ferCount >= 15 && inv.buchesCount >= 15 && giveItem.iHaveHache == true)
        {
            inv.ferCount -= 15;
            inv.ferCountText.text = inv.ferCount.ToString();
            inv.buchesCount -= 15;
            inv.buchesCountText.text = inv.buchesCount.ToString();
            pistolet.SetActive(true);

        }
    }

}
