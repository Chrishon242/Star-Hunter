using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour {
    
    public Rigidbody rb;
      const float G =550f;
    float timeLoop = 1f;
    private void Start()
    {
        if (gameObject.tag != "BlackHole")
        {
            rb = GetComponent<Rigidbody>();
        }

        StartCoroutine("AttractOBJ");
    }


    IEnumerator AttractOBJ()
    {
        yield return new WaitForSeconds(timeLoop);
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        AttractData();
    }

    private void AttractData()
    {
        Attractor[] attractors = FindObjectsOfType<Attractor>();
        foreach (Attractor attactor in attractors)
        {
            if (attactor != this)
            {
                Attract(attactor);
            }
        }
    }

    void Attract (Attractor obj)
    {
        Rigidbody rbToAttract = obj.rb;
        Vector3 direction = rb.position - rbToAttract.position;
        float distance = direction.magnitude;

        float forceMagnitude =G * (rb.mass * rbToAttract.mass) / Mathf.Pow(distance, 2);
        Vector3 force = direction.normalized * forceMagnitude;

        rbToAttract.AddForce(force);
    }
}
