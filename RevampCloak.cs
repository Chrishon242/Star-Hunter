using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevampCloak : MonoBehaviour
{
    [Range(0f, 1f)]
    public float tuneScaler;
    public bool Btrig;
    public bool trigFix = true;
    bool checkTrigger = true;  // bool check 
    public Renderer DefaultMat;
    public Material ColorSwitch;
    public Collider Playercollider;
    GameObject subFlash;
    float time = 0.5f;



    private void Start()
    {   // this allows us to get the renderer component of this gameObject
        DefaultMat = GetComponent<Renderer>(); // This will be the default color for the ship
        Playercollider = GetComponent<Collider>(); // will be used to enable and disable collider 
        ColorSwitch = DefaultMat.material;
        subFlash = FindObjectOfType<GameEffects>().GameEffect[0];
        tuneScaler = Mathf.Clamp(tuneScaler, 0f, 1f);
        StartCoroutine("CloakOverTime"); 
    }



    IEnumerator CloakOverTime()
    {
        while (true)
        {

            yield return new WaitForSeconds(time);
            CloakTimeLeft();
        }
    }

    void CloakTimeLeft()
    {
        if (ActiveCloakBar.CloakBar <= 0)
        {
            Btrig = false;
            Cloaking(false);
        }
    }


    public void TriggerCloak()
    {
        if (Input.GetButton("Fire1"))
        {
            Cloaking(true);
        }

        else
        {
            Cloaking(false);
        }
    }


    public void Cloaking(bool trigger)
    {

        if (trigger == true && PauseGame.OnPause == false)
        {
            DefaultColor(true); //DEFAULT COLOR && CLOAK
            if (trigger == true && checkTrigger == true) // CREATES FLASH STARTUP AND IS CALLED ONLY ONCE!
            {


                Instantiate(subFlash, this.gameObject.transform);
                checkTrigger = false;
            }
        }
        else
        {
            DefaultColor(false);
            Playercollider.enabled = true;
            checkTrigger = true;
        }


    }




    public void DefaultColor(bool triggerCloak)
    {

        if (triggerCloak == true && trigFix == true)
        {
            DefaultMat.material = FindObjectOfType<ColorControl>().ControlColor[0];
            Playercollider.enabled = false;

        }
        else
        {

            DefaultMat.material = ColorSwitch;
            Playercollider.enabled = true;
        }

    }



}