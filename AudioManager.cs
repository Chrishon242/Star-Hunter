using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource BGM;
     public AudioClip[] audioClips;

    int AudioMix;

    private void Awake()
    {
         AudioMix = Random.Range(0, 4); 

        BGM.clip = audioClips[AudioMix];
        BGM.Play();

    }


}
