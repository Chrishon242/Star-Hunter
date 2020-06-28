using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsFalling : MonoBehaviour
{

    float speed;
    Rigidbody rb;
    Vector3 movement;
    float minSpeed = 7f;
    float maxSpeed = 12f;

    float timeLoop;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
        if (SpawnZone.speedShift == true)
        {
            minSpeed = 10f;
            maxSpeed = 15f;
        }
        else
        {
            minSpeed = 7f;
            maxSpeed = 12f;
        }
        speed = Random.Range(minSpeed, maxSpeed);
         movement = new Vector3(0.0f, 0.0f, -speed);
        rb.velocity = movement;
    }
}
