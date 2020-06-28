using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blastRadious : MonoBehaviour {

    public float scaleRate = 10f;
    public float DelayDestroy = 0.3f;
    public static float NovaDamage = 99999.0f;

    


    private void FixedUpdate()
    {
         transform.localScale += Vector3.one * scaleRate * Time.deltaTime; 
         Destroy(gameObject, DelayDestroy);
    }


}


