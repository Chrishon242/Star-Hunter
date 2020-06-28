using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class OnScreen : MonoBehaviour
{
 
    public  float speed;
   public Rigidbody rb;
   public Vector3 movement;
    

    private void Start()
    { 
        rb = GetComponent<Rigidbody>();
       
    }
    private void Update()
    {
      
        movement = new Vector3(6.0f, 0.0f, 0.0f);
         rb.AddForce(movement * speed * Time.deltaTime);
         
        
      
    }
}
