using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiveItem : MonoBehaviour
{
    public Inventory inv;
    public GameObject hache;
    public bool iHaveHache = false;

    private void Start()
    {
        hache.SetActive(false);
    }

    public void Case1()
    {
        if (inv.ferCount >= 5 && inv.buchesCount >= 5)
        {
            inv.ferCount -= 5;
            inv.ferCountText.text = inv.ferCount.ToString();
            inv.buchesCount -= 5;
            inv.buchesCountText.text = inv.buchesCount.ToString();

            hache.SetActive(true);
            iHaveHache = true;
        }
        
    }

    private void Update()
    {
        Case1();
    }

}
