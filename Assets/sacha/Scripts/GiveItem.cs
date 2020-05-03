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
    public bool iHaveHache;
    public GameObject PorteEnBoit;
    public GameObject Spawner;

    private void Start()
    {
        iHaveHache = false;
        hache.SetActive(false);
    }

<<<<<<< HEAD
    public void Case1()
    {
        if (inv.ferCount >= 2.5 && inv.buchesCount >= 2.5 && iHaveHache == false)
        {
            iHaveHache = true;
            hache.SetActive(true);
            inv.ferCount -= 5;
            inv.ferCountText.text = inv.ferCount.ToString();
            inv.buchesCount -= 5;
            inv.buchesCountText.text = inv.buchesCount.ToString();

            
            
        }
        
    }
=======
//    public void Case1()
  //  {
    //    if (inv.ferCount >= 5 && inv.buchesCount >= 5 && iHaveHache == false)
      //      {
        //        inv.ferCount -= 5;
          //      inv.ferCountText.text = inv.ferCount.ToString();
            //    inv.buchesCount -= 5;
              //  inv.buchesCountText.text = inv.buchesCount.ToString();
                //hache.SetActive(true);
                //iHaveHache = true;
            //}
    //}
>>>>>>> e3c96c8a04e1a18cd4ca91bd2d7c95b0cddfeade

    private void Update()
    {
        //Case1();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(iHaveHache == true)
        {
            Destroy(PorteEnBoit);
            Destroy(hache);
            Spawner.transform.Translate(76, 15, 0);
        }
    }


    public void craftHache()
    {
        if (inv.ferCount >= 5 && inv.buchesCount >= 5 && iHaveHache == false)
        {
            inv.ferCount -= 5;
            inv.ferCountText.text = inv.ferCount.ToString();
            inv.buchesCount -= 5;
            inv.buchesCountText.text = inv.buchesCount.ToString();
            hache.SetActive(true);
            iHaveHache = true;
        }
    }

}
