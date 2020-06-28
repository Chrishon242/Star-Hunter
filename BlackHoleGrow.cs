using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackHoleGrow : MonoBehaviour
{
      float growthSpeed = 2f;
     Vector3 scaleXYZ;
    public float DestroyDelay;
    private void Update()
    {
        StartCoroutine("DesTime");
    }


    IEnumerator DesTime()
    {
        scaleXYZ = new Vector3(growthSpeed, growthSpeed, growthSpeed);
  
        yield return new WaitForSecondsRealtime(DestroyDelay );

               transform.localScale = new Vector3(
            Mathf.Clamp(transform.localScale.x, 0f, 2.5f),
            Mathf.Clamp(transform.localScale.y, 0f, 2.5f),
            Mathf.Clamp(transform.localScale.z, 0f, 2.5f)
            );
        transform.localScale -= scaleXYZ * Time.deltaTime;


        if (transform.localScale.x <= 0.02f || transform.localScale.y <= 0.02f || transform.localScale.z <= 0.02f && gameObject.tag == "BlackHole")
        {
            Destroy(gameObject);
        }
       
    }
}
