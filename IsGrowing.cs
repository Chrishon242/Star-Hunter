using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsGrowing : MonoBehaviour {

    
    public float growing = .5f;
    public float delay = 2f;

    private void Update()
    {
        StartCoroutine("Growing");  
    }
    IEnumerator Growing ()
    {
        transform.localScale = new Vector3(
            Mathf.Clamp01(transform.localScale.x),
            Mathf.Clamp01(transform.localScale.y),
             Mathf.Clamp01(transform.localScale.z)
            );

        Vector3 linker = new Vector3(growing, growing, growing);
        transform.localScale += linker * Time.deltaTime;
    

        
        yield return new WaitForSecondsRealtime(delay);

        transform.localScale -= linker * 2f *Time.deltaTime;

        if (transform.localScale.x <= -0.01f || transform.localScale.y <= -0.01f || transform.localScale.z <= -0.01)
        {
            Destroy(gameObject);
        }


    }


}
