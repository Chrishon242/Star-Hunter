using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorControl : MonoBehaviour {
    // THIS IS SCRIPT IS USED ONLY FOR THE COLOR MANAGER GameObject 
     public    Material [] ControlColor;
    GameObject playerDefaultColor;
    private void Start()
    {
        playerDefaultColor = GameObject.FindGameObjectWithTag("Player");
        ControlColor[10] = playerDefaultColor.GetComponent<Renderer>().material;
    }
}
    
