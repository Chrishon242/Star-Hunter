using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstacles : MonoBehaviour
{
    public bool enterTrigger = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "HazardShip")
        {
            enterTrigger = true;
            Debug.Log(enterTrigger); 
        }
    }


    private void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
        if (other.gameObject.tag == "HazardShip")
        {
            enterTrigger = false;
            Debug.Log(enterTrigger);
        }
    }
}
