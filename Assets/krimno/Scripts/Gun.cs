using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Inventory inv;
    public GameObject pistolet;
    public GameObject hache;
    

    public void Start()
    {
        pistolet.SetActive(false);
    }

    private void Update()
    {
        if(inv.ferCount >= 15 && inv.buchesCount >= 15 && hache)
        {
            inv.ferCount -= 15;
            inv.ferCountText.text = inv.ferCount.ToString();
            inv.buchesCount -= 15;
            inv.buchesCountText.text = inv.buchesCount.ToString();
            pistolet.SetActive(true);

        }
    }

}
