using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTrigger : MonoBehaviour
{
      
    public ActiveCloakBar ACB;
    public bool buttonTrigger;
      public RevampCloak  cloakOn;
    public ShotSpawnPoint shotTrigger;

    private void Awake()
    {
        cloakOn = FindObjectOfType<RevampCloak>();
        shotTrigger = FindObjectOfType<ShotSpawnPoint>();
    }


    

    public void OnPointerDown()
    {     ////////////////////////activate cloak bar
         
           
        cloakOn.Btrig  = true;  
        cloakOn.Cloaking(true); // controls cloak
        ACB.isTriggered = true; // controls bar
         cloakOn.DefaultColor(true);

         
    }

    public void OnPointerUp()
    {  ////////////////////// turns off cloak
        cloakOn.Btrig = false;
        // shotTrigger.Fire(false);

        cloakOn.Cloaking(false);
        ACB.isTriggered = false;
        cloakOn.DefaultColor(false);
        /* //////////////////// Stops FIRE TRIGGER 
        shotTrigger.Fire(false);
        shotTrigger.pullTrig = false;*/

    }

  


}
