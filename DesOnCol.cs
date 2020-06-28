using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesOnCol : MonoBehaviour {

    public ActiveCloakBar ACBar;
    public float AmpMeter;
    GameObject SideEffect;

     

    private void Awake()
    {
        ACBar = FindObjectOfType <ActiveCloakBar>();
        SideEffect = FindObjectOfType<GameEffects>().GameEffect[1];
    }
    private void OnTriggerEnter(Collider other)
    {
           if ( other.gameObject.tag == "Respawn")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "Player")
        {
            ActiveCloakBar.CloakBar  += AmpMeter; 
             Destroy(gameObject);
        }
    }
     
  
}
