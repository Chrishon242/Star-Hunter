using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffset : MonoBehaviour
{

    public float speed = 10f;
    Renderer render;
     float timeLoop;
    public Material MatOffset;
    Skybox sky;


    private void Start()
    {
        render = GetComponent<Renderer>();
        sky = FindObjectOfType<Skybox>();
        StartCoroutine("OffSet");
     }

    IEnumerator OffSet()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeLoop);
            Vector2 offset;
 
           if (gameObject.tag == "Finish")
            {
                 offset = new Vector2(0f, Time.time * speed);
                // MatOffset.SetTextureOffset("_MainTex", offset);
                
                sky.material.SetTextureOffset("_MainTex", offset);
            }
            else
            {
                offset = new Vector2(0, Time.time * speed);
                render.material.SetTextureOffset("_BaseMap", offset);

            } 
             
        }
    }

}
