using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOverTime : MonoBehaviour {
    // THIS CODE IS USED FOR OFFICAL POWER UPS

         
     public    static float DestroyOverTime = 3f;

    private void Start()
    {
        Destroy(gameObject, DestroyOverTime);
    }


}
