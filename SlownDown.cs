using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlownDown : MonoBehaviour
{    public float timer = 5f ;
    public bool triggered;
 
    //set a timer  for when the code will collapse
    //within timer
    private void Awake()
    {
        

    }
    private void Update()
    {    
        StartCoroutine("slowDown");
        
    }
   
    void  flashTest()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Destroy(GetComponent<SlownDown>());
            triggered = false;
        }
    }
    IEnumerator slowDown ()
    {
        triggered = true;
        flashTest();
        if (triggered == true)
        {
            Time.timeScale = 0.25f;
         }
        else 
        {
            Time.timeScale = 1f;
        }

        yield return new WaitForSecondsRealtime(timer);
        triggered = false;
        Time.timeScale = 1f; 
        Destroy(GetComponent<SlownDown>());
         
    }

}