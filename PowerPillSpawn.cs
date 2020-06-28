using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerPillSpawn : MonoBehaviour
{
    public GameObject[] PowerSpawn ;



    float SpawnRange;
    Vector3 SpawnPosition; 
    int pillSpawn;

    
    float timeLoop = 5f;
    float LoopOverTime = 1f;

    private void Awake()
    {
          StartCoroutine("SpawnGenerator");  
          StartCoroutine("PowerPills");  
    } 

    IEnumerator SpawnGenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeLoop);
            PowerPillPosition();
        }
    }

    void PowerPillPosition()
    {
        SpawnRange = Random.Range(-8f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids
        pillSpawn = Random.Range(0, 4);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
        SpawnPosition = new Vector3(SpawnRange, transform.position.y, transform.position.z);  // is the actula position of the asteroids 
    }



    IEnumerator PowerPills()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeLoop);
            SpawnOverTime();
        }
    }

    void SpawnOverTime()
    {
        Instantiate(PowerSpawn[pillSpawn], SpawnPosition, Quaternion.Euler(0,90,90));

    }
      
}
