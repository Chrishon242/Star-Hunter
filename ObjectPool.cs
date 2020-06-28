using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public Dictionary<string, Queue<GameObject>> poolDictionary;

    int AsteroidSpawn;
    Vector3 SpawnPosition;
    float SpawnRange;


    [System.Serializable]
    public class pool
    {
        public string tag;
        public GameObject[] Asteroidprefab;
        public int size;
    }
    public List<pool> pools;
    private void Start()
    {
        poolDictionary = new Dictionary<string, Queue<GameObject>>();
        InvokeRepeating("CallFromPool", 0f, 1.5f);

    }
    void CallFromPool()
    {
        SpawnRange = Random.Range(-10, 9f);
        SpawnPosition = new Vector3(SpawnRange, transform.position.y, transform.position.z);
        AsteroidSpawn = Random.Range(0, 3);


        foreach (pool poolingObj in pools)
        {
            Queue<GameObject> objectpool = new Queue<GameObject>();
            for (int i = 0; i < poolingObj.size; i++)
            {
                GameObject obj = Instantiate(poolingObj.Asteroidprefab[AsteroidSpawn]);                //Instantiate(poolingObj.Asteroidprefab[AsteroidSpawn]);
                print(obj);
                obj.SetActive(false);
                objectpool.Enqueue(obj);
            }
            poolDictionary.Add(poolingObj.tag, objectpool);
        }
    }

}

 