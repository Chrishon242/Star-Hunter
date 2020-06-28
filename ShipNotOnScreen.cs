using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipNotOnScreen : MonoBehaviour
{

    public Vector3 objectPosition;
    public GameObject Indicator;
    float positionZ;
    float randomPosition;
    public bool sideSwitch = false;
    
   
    private void Start()
    {
        if ( gameObject.tag != "Respawn")
        {
         randomPosition = Random.Range(-2f, 2f);
        positionZ = gameObject.transform.position.z + randomPosition; 
        objectPosition = new Vector3(gameObject.transform.position.x, 0f, positionZ); 
         Instantiate(Indicator, objectPosition , Quaternion.Euler(0f, 90f, 0));
        }
        else if (gameObject.tag == "Respawn")
        {
            sideSwitch = true;
            randomPosition = Random.Range(-2f, 2f);
            positionZ = gameObject.transform.position.z + randomPosition;
            objectPosition = new Vector3(gameObject.transform.position.x, 0f, positionZ);
            Instantiate(Indicator, -objectPosition, Quaternion.Euler(0f, -90f, 0));
        }




        //   THE SIZE OF THE ARROW IS == TO THE DISTANCE FROM THE SHIP TO IT. 
    }
}
