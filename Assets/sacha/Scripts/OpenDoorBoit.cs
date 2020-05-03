using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorBoit : MonoBehaviour
{
    public GameObject OBJhache;
    public CraftItem Hache;
    public GameObject Spawner;


    public void OnCollisionEnter2D(Collision2D col)
    {
        if (Hache.iHaveHache == true)
        {
            Spawner.transform.Translate(76, 15, 0);
            Destroy(gameObject);
            Destroy(OBJhache);
        }
    }
}
