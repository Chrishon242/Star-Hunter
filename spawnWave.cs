using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWave : MonoBehaviour
{
    public GameObject[] AsteroidSpawn_Lvl1; //white Asteroids
    public GameObject[] AsteroidSpawn_Lvl2;  //Green Asteroids
    public GameObject[] AsteroidSpawn_Lvl3;  //Yellow Asteroids
    public GameObject[] AsteroidSpawn_Lvl4; //Red Asteroids

 

    float SpawnRange;
    float SecondSpawnRange;


    Vector3 SpawnPosition;
    Vector3 SecondSpawnPoint;


    int AsteroidSpawn;
    int SecondAsteroidSpawn;

    ScoreOverTime scoreTime;

    void Start()
    {
        scoreTime = FindObjectOfType<ScoreOverTime>();
 
        InvokeRepeating("SpawnAsteroids", 0, 1f);
        InvokeRepeating("SpawnOverTime", 0, 0.9f);
    }


    void SpawnAsteroids()
    {
        SpawnRange = Random.Range(-10f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids
        SecondSpawnRange = Random.Range(-10f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids


        SpawnPosition = new Vector3(SpawnRange, transform.position.y, transform.position.z);  // is the actula position of the asteroids 
        SecondSpawnPoint = new Vector3(SecondSpawnRange, transform.position.y, transform.position.z); //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids


        AsteroidSpawn = Random.Range(0, 3);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
        SecondAsteroidSpawn = Random.Range(0, 3);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
    }

    void SpawnOverTime()
    {
        if (ScoreOverTime.CurrentScore <= 2500f)
        {
            Instantiate(AsteroidSpawn_Lvl1[AsteroidSpawn], SpawnPosition, Quaternion.identity);
        }
        else if (ScoreOverTime.CurrentScore <= 5000f)
        {
            Instantiate(AsteroidSpawn_Lvl2[AsteroidSpawn], SpawnPosition, Quaternion.identity);
        }
        else if (ScoreOverTime.CurrentScore <= 7500f)
        {

            Instantiate(AsteroidSpawn_Lvl3[AsteroidSpawn], SpawnPosition, Quaternion.identity);
            Instantiate(AsteroidSpawn_Lvl3[SecondAsteroidSpawn], SecondSpawnPoint, Quaternion.identity);
        }

        else
        {
            Instantiate(AsteroidSpawn_Lvl4[AsteroidSpawn], SpawnPosition, Quaternion.identity);
            Instantiate(AsteroidSpawn_Lvl4[SecondAsteroidSpawn], SecondSpawnPoint, Quaternion.identity);
        }
    }
}
