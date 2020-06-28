using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActiveCloakBar : MonoBehaviour
{

    [Range(0, 1)]
    public static float CloakBar;
    public Image ActiveCloak;
    public bool isTriggered = false;
    RevampCloak IsCloakOn;
    PlayerController playerCloakTime;

    public float BarDraining;


    private void Start()
    {
        ActiveCloak = GetComponent<Image>();
        IsCloakOn = FindObjectOfType<RevampCloak>();
        playerCloakTime = FindObjectOfType<PlayerController>();
        CloakBar = 1f;
        BarDraining = playerCloakTime.CloakTime; 
    }


    private void FixedUpdate()
    {
        Check4Trigger();
    }


    void Check4Trigger()
    {
        if (CloakBar <= 0)
        {
            FindObjectOfType<RevampCloak>().trigFix = false;

        }
        else
        {
            FindObjectOfType<RevampCloak>().trigFix = true;

        }


        ActiveCloak.fillAmount = CloakBar;//CONTROL FILL.AMOUNT
        CloakBar = Mathf.Clamp01(CloakBar);//CLAMP RANGE
        if (isTriggered == true)
        {
            StartCoroutine(ActiveCloakON(true));

        }
    }

    public IEnumerator ActiveCloakON(bool trigger)
    {
        yield return new WaitForSeconds(0.1f);

        if (trigger == true && IsCloakOn.Btrig == true)
        {

            CloakBar -= playerCloakTime.CloakTime * Time.deltaTime;

        }


    }

}
