using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWaves : MonoBehaviour
{

    public float speed = 0.5f;
    public float BG;
    Renderer render;
    float timeLoop;
 

    private void Start()
    { 
        render = GetComponent<Renderer>();
        StartCoroutine("OffSet");
      }

 
    IEnumerator OffSet()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeLoop);
            Vector2 offset;

            if (gameObject.tag == "CloakRecharge" || gameObject.tag == "SuperNova")
            {
                offset = new Vector2(Time.time * speed, Time.deltaTime * speed);
                render.material.SetTextureOffset("_MainTex", offset);
            }
             

        }
    }

    private void FixedUpdate()
    {
        if (gameObject.tag == "BackGround")
            {
            Vector2 offset;
            offset = new Vector2(0, Time.time * speed);
            render.material.SetTextureOffset("_BaseMap", offset);
        }
    }

}