using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public GameObject Hiteffect;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(Hiteffect, transform.position, Quaternion.identity);
        Destroy(effect, 100f);
        Destroy(gameObject);
    }
}
