using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTrigger : MonoBehaviour
{
    ShotSpawnPoint FireBullets;


    private void Start()
    {
        FireBullets = FindObjectOfType<ShotSpawnPoint>();
        ShotSpawnPoint.pullTrig = false;

    }

    public void OnPointerDown()
    {
        ShotSpawnPoint.pullTrig = true;
    }
    public void OnPointerUp()
    {
        ShotSpawnPoint.pullTrig = false;
    }

}
