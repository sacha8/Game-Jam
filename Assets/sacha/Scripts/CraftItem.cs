using UnityEngine;
using UnityEngine.UI;

public class CraftItem : MonoBehaviour
{
    [Header("ItemDonnateHache")]
    public Inventory inv;
    public GameObject hache;
    public int HacheMatériaux;
    [Header("OpenDoor")]
    public bool iHaveHache = false;

    void Start()
    {
        hache.SetActive(false);
    }

    public void CraftHache()
    {
        if (inv.ferCount >= HacheMatériaux && inv.buchesCount >= HacheMatériaux && iHaveHache == false)
        {
            inv.buchesCount -= HacheMatériaux;
            inv.buchesCountText.text = "" + inv.buchesCount;
            inv.ferCount -= HacheMatériaux;
            inv.ferCountText.text = "" + inv.ferCount;
            hache.SetActive(true);

            iHaveHache = true;
        }
    }

}
