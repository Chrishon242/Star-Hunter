using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour
{
    Renderer matShader;
    float colorConverter = 1f;
    private void Start()
    {
        matShader = GetComponent<Renderer>();

        InvokeRepeating("ChangeColor", 0f, 1f);

    }
    #region  

    void ChangeColor()
    {
        if (gameObject.tag == "MilkyAsteroids")
        {
            MilkyAsteroids();

        }
        else if (gameObject.tag == "TropicalAsteroids")
        {
            TropicalAsteroids();
 

        }
        else if (gameObject.tag == "LemonAsteroids")
        {
            LemonAsteroids();
 
        }

        else if (gameObject.tag == "VermillionAsteroids")
        {
            VermillionAsteroids();
 
        }
    }


    void MilkyAsteroids()
    { // White
        matShader.material.SetColor("_EmissionColor", new Color(colorConverter, colorConverter, colorConverter, 0f));
    }

    void TropicalAsteroids()
    {//  Green
        matShader.material.SetColor("_EmissionColor", new Color(0, colorConverter, 0, 0f));
    }

    void LemonAsteroids()
    {// Yellow
        matShader.material.SetColor("_EmissionColor", new Color(colorConverter, colorConverter, 0, 0f));
        // CALL THEM LEMON ASTEROIDS AND THEN MAKE A NEW TYPE OF ASTEROIDS CALLED THE GOLDEN ONES
    }
    void VermillionAsteroids()
    {//Red
        matShader.material.SetColor("_EmissionColor", new Color(colorConverter, 0, 0, 0f));
    }

    #endregion
}
