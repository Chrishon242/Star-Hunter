using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour
{
 
    void Update()
    {
        GetComponent<AudioSource>().Play();

    }
}
