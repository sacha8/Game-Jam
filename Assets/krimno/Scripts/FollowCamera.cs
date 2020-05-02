using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [Header("Camera Follow")]
    private Transform PlayerTransform;

    void Start()
    {
        PlayerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void LateUpdate()
    {
        Vector3 temp = transform.position;

        temp.x = PlayerTransform.position.x;
        temp.y = PlayerTransform.position.y;


        transform.position = temp;

    }
}
