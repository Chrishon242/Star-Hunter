using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TriggerTest : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Give me something");
        Debug.Log(other.gameObject);
    }


}
