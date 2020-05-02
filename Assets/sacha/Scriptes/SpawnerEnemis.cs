using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerEnemis : MonoBehaviour
{
    public GameObject obstacle;
    private float timeBtwSpawn;
    public float StartTimeBtwspawn;


    private void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            Instantiate(obstacle, transform.position, Quaternion.identity);
            timeBtwSpawn = StartTimeBtwspawn;
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
