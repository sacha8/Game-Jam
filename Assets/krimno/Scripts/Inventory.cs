using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int buchesCount;
    public Text buchesCountText;

    public int ferCount;
    public Text ferCountText;

    public static Inventory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("Il y a une autre instance de Inventory dans la scene");
            return;
        }

        instance = this;
    }

    public void addBuches(int countBuches)
    {
        buchesCount += countBuches;
        buchesCountText.text = buchesCount.ToString();
    }

    public void addFer(int countFer)
    {
        ferCount += countFer;
        ferCountText.text = ferCount.ToString();
    }
}
