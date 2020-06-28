using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOnContact : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boundary" || other.gameObject.tag == "Player")
        {
            return;
        }
        Destroy(gameObject);
    }
}
