using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 movement;
    public float speed;
    Renderer shipRenderer;
    MainMenuObjects mainMenuObjects;



    void Start()
    {

        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 20f);
        speed = Random.Range(10, 15);
        shipRenderer = GetComponent<Renderer>();
        mainMenuObjects = FindObjectOfType<MainMenuObjects>();
        // shipRenderer.material = mainMenuObjects.RandomShipMaterial[MainMenuObjects.RandomColor];
    }

    void FixedUpdate()
    {
        if (movement.x == 0)
        {
            movement.x += 10f;
        }

        if (GetComponentInParent<MainMenuObjects>().tag == "LeftTag")
        {
            rb.AddForce(movement * speed * Time.deltaTime);
        }
        else if (GetComponentInParent<MainMenuObjects>().tag == "RightTag")
        {
            rb.AddForce(movement * -speed * Time.deltaTime);
        }

    }
}
