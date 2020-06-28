using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreOverTime : MonoBehaviour {
    public  static float  CurrentScore;
    const  float  ClampedScore = 999999999;
    public float multiplier; 
    TextMeshProUGUI Tmp;

    private void Start()
    {
        CurrentScore = 0f;
        CurrentScore  = Mathf.Clamp(CurrentScore , 0, ClampedScore);
        Tmp = GetComponent<TextMeshProUGUI>();
        //   StartCoroutine(OverTime());
       }
 


    void  FixedUpdate()
    {
        CurrentScore += multiplier * Time.deltaTime;
        Tmp.text = CurrentScore.ToString("0");
     }
}
