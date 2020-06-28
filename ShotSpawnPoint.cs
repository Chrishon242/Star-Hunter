using System.Collections;
using System.Collections.Generic;
using UnityEngine; 


public class ShotSpawnPoint : MonoBehaviour
{ 
    public Transform spawnPoint;
    public GameObject shot;
    PauseGame ShotControl;
     
    ActiveCloakBar ACbar;
    public static  bool pullTrig = false;
    public bool triggerButton = false; 
    float NextFire;
    PlayerController FireRate;

    float timeLoop;

    private void Start()
    {
        ACbar = FindObjectOfType<ActiveCloakBar >();
        FireRate = FindObjectOfType<PlayerController>();
        ShotControl = FindObjectOfType<PauseGame>();
        StartCoroutine("ShotSpawn");
    }
    
    IEnumerator ShotSpawn()
    {
         while (true)
        {
            yield return new WaitForSeconds(timeLoop);
            ShotTrigger();
        }
    }

    private void ShotTrigger()
    { 
        if ( pullTrig == true && PauseGame.OnPause == false)
        {
            Fire(true);
        }
        else if (pullTrig == true && PauseGame.OnPause == true)
        {
            Fire(false);
        }
    } 

    public void Fire(bool trigger)
    {
        

        if ( trigger == true && Time.time > NextFire)
        {
            NextFire = Time.time + FireRate.fireRate;
            Instantiate(shot, this.gameObject.transform.position, this.gameObject.transform.rotation);
        } 
    }
      
    }
