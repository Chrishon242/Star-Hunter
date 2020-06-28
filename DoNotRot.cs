using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

 
public class DoNotRot : MonoBehaviour {

    Quaternion rotation;
    Transform fixedRotation;
    public float rotate;

    private void Start()
    {
        //    rotation = transform.rotation;
        
        rotation = transform.rotation;
     }

    private void Update()
    {
        transform.rotation = Quaternion.Euler(0, rotate, 0);

    }
}
