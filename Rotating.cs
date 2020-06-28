using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating : MonoBehaviour {
   public  Transform rotty;
    public float speed = 50f;
    float RotSpeed = 1f;
		// Update is called once per frame
	void Update () { 
        rotty.Rotate( RotSpeed * speed * Time.deltaTime, 0 ,0);    
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (gameObject.tag == "PowerUpTS")
        {
            // speed = GetComponent<SlownDown>().timeDelay;
        }
    }
        private void OnCollisionExit(Collision collision)
        {
            if (gameObject.tag == "PowerUpTS")
            {
                speed =50f;
            }
        }


}
