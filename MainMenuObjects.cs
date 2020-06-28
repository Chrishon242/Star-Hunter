using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuObjects : MonoBehaviour
{
    int randomGenerator;
    int randomGenerator1;
    int randomGenerator2;
    public GameObject[] MainMenuShips;
    public Vector3 pos;
    private float timeLoop = 4f;
    public Material[] RandomShipMaterial;
    public static int RandomColorLeft;
    public static int RandomColorRight;


    private void Start()
    {
        pos = gameObject.transform.position;
        StartCoroutine("spawnOverTime");
        InvokeRepeating("CallingTool", 0f, 1f);


    }


    private void CallingTool()
    {
        randomGenerator = Random.Range(-7, 8);
        randomGenerator1 = Random.Range(0, 3);
        randomGenerator2 = Random.Range(-10, 0);
        RandomColorLeft = Random.Range(0, 3);
        RandomColorRight = Random.Range(0, 3);
        pos.z = randomGenerator;
        pos.y = randomGenerator2;
        randomGenerator = Random.Range(-7, 8);

    }

    IEnumerator spawnOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(timeLoop);


            if (gameObject.tag == "LeftTag")
            {
                Instantiate(MainMenuShips[randomGenerator1], pos, Quaternion.Euler(0, 90, 0), gameObject.transform);
                MainMenuShips[randomGenerator1].GetComponent<Renderer>().material = RandomShipMaterial[RandomColorLeft];
            }
            else if (gameObject.tag == "RightTag")
            {
                Instantiate(MainMenuShips[randomGenerator1], pos, Quaternion.Euler(0, -90, 0), gameObject.transform);
                MainMenuShips[randomGenerator1].GetComponent<Renderer>().material = RandomShipMaterial[RandomColorRight];
                 
            }
        }
    }

}
