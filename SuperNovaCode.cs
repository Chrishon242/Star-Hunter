using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperNovaCode : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "notPlayer")
        {
            Destroy(other.gameObject);
            Debug.Log("Colliding and destroy");
        }
    }



}
