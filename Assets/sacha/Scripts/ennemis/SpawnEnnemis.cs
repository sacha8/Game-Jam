using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnnemis : MonoBehaviour
{
    public Transform Ennemis;

    private float TimeAfterSpawn;
    public float StartTimeSpawn;

    private void Update()
    {
        if(TimeAfterSpawn <= 0)
        {
            Instantiate(Ennemis, transform.position, Quaternion.identity);
            TimeAfterSpawn = StartTimeSpawn;
        }else
        {
            TimeAfterSpawn -= Time.deltaTime;
        }
    }
}
