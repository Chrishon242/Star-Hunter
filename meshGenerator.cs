using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class meshGenerator : MonoBehaviour
{
    private void Update()
    {
       Debug.Log( GetComponentInChildren<MeshRenderer >().material = this.gameObject.GetComponent<MeshRenderer>().material);
    }




}
