using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour {
    public int health = 5;
    public Text healthText;
  public   TextMesh meshing;
      

      
    private void Update()
    {
        meshing.text = "Health : " + health;

        healthText.text = "HEALTH :  " + health;

        if (Input.GetKeyDown (KeyCode.A ))
        {
            health++;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            health--;
        }


    }



}
