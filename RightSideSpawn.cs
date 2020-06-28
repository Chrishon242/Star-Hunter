using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightSideSpawn : MonoBehaviour
{

    public Vector3 objectPosition;
    public GameObject Indicator;
    float positionZ;
    float randomPosition;
    public bool sideSwitch = false;

    private void Start()
    { 
            sideSwitch = true; 
            randomPosition = Random.Range(-2f, 2f);
            positionZ = this.gameObject.transform.position.z + randomPosition;
            objectPosition = new Vector3(this.gameObject.transform.position.x, 0f, positionZ);
            Instantiate(Indicator, -objectPosition, Quaternion.Euler(0f, 270f, 0)); 
    }
}
