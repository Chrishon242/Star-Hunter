using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftSideSpawn : MonoBehaviour
{
    public Vector3 objectPosition;
    public GameObject Indicator;
    float positionZ;
    float randomPosition;
    public bool sideSwitch = false;


    private void Start()
    {
      
            randomPosition = Random.Range(-2f, 2f);
            positionZ = gameObject.transform.position.z + randomPosition;
            objectPosition = new Vector3(gameObject.transform.position.x, 0f, positionZ);
            Instantiate(Indicator, objectPosition, Quaternion.Euler(0f, 90f, 0));
       
    }



    }
