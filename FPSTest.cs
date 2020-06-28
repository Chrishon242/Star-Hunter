using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSTest : MonoBehaviour
{
    public  Text FPS_text;
    float DeltaTime = 1.0f;

 
    private void  Update()
    {
        float fps = DeltaTime / Time.deltaTime;

        FPS_text.text = fps.ToString();
 

    }
}
       
 

 