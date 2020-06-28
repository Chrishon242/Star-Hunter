 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{

    public GameObject[] AsteroidSpawn_Lvl1; //white Asteroids
    public GameObject[] AsteroidSpawn_Lvl2;  //Green Asteroids
    public GameObject[] AsteroidSpawn_Lvl3;  //Yellow Asteroids
    public GameObject[] AsteroidSpawn_Lvl4; //Red Asteroids



    float SpawnRange;
    float SecondSpawnRange;
    float ThirdSpawnRange;


    Vector3 SpawnPosition;
    Vector3 SecondSpawnPoint;
    Vector3 ThirdSpawnPoint;


    int AsteroidSpawn;
    int SecondAsteroidSpawn;
    int ThirdAsteroidSpawn;

    ScoreOverTime scoreTime;
    float timer = 1f;
    public static bool speedShift = false;

    void Start()
    {
        scoreTime = FindObjectOfType<ScoreOverTime>();
 
        InvokeRepeating("SpawnAsteroids", 0, 1f);
        // InvokeRepeating("SpawnOverTime", 0, 1f);

        StartCoroutine("SpawnOverTime");
    }


    void SpawnAsteroids()
    {
        SpawnRange = Random.Range(-10f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids
        SecondSpawnRange = Random.Range(-10f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids
        ThirdSpawnRange = Random.Range(-10f, 9f);   //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids


        SpawnPosition = new Vector3(SpawnRange, transform.position.y, transform.position.z);  // is the actula position of the asteroids 
        SecondSpawnPoint = new Vector3(SecondSpawnRange, transform.position.y, transform.position.z); //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids
        ThirdSpawnPoint = new Vector3(SecondSpawnRange, transform.position.y, transform.position.z); //  This generates a random number from -10 - 8 in  which we can use for the spawn position of the asteroids


        AsteroidSpawn = Random.Range(0, 3);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
        SecondAsteroidSpawn = Random.Range(0, 3);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
        ThirdAsteroidSpawn = Random.Range(0, 3);   // this code is used to help spawn the asteroids, it will spawn a  asteroid based on the number called, (0, 1 & 2)
    }

    IEnumerator SpawnOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(timer);
 
            if (ScoreOverTime.CurrentScore  <= 1000f)
            {
                Instantiate(AsteroidSpawn_Lvl1[AsteroidSpawn], SpawnPosition, Quaternion.identity);
            }
            else if (ScoreOverTime.CurrentScore <= 2000f)
            {
                Instantiate(AsteroidSpawn_Lvl2[AsteroidSpawn], SpawnPosition, Quaternion.identity);
            }
            else if (ScoreOverTime.CurrentScore <= 3000f)
            {
                timer = 1.2f;
                speedShift = true;
                Instantiate(AsteroidSpawn_Lvl3[AsteroidSpawn], SpawnPosition, Quaternion.identity);
                Instantiate(AsteroidSpawn_Lvl3[SecondAsteroidSpawn], SecondSpawnPoint, Quaternion.identity);
 

            }

            else
            {
                Instantiate(AsteroidSpawn_Lvl4[AsteroidSpawn], SpawnPosition, Quaternion.identity);
                Instantiate(AsteroidSpawn_Lvl4[SecondAsteroidSpawn], SecondSpawnPoint, Quaternion.identity);
                Instantiate(AsteroidSpawn_Lvl4[ThirdAsteroidSpawn], ThirdSpawnPoint, Quaternion.identity);


            }

        }

    }
}


