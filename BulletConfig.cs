using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletConfig : MonoBehaviour
{
    public   Rigidbody RBbullet;
    public float speed;
    Vector3 Movement;
    private void Awake()
    {
        RBbullet = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Movement = new Vector3(0, 0, speed * Time.deltaTime);

        RBbullet.velocity = Movement;
    }


}
