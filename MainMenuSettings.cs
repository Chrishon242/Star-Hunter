using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class MainMenuSettings : MonoBehaviour
{

    public   AudioMixer audioMixer;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Mute(bool trigger)
    {
        AudioListener.pause = !AudioListener.pause;
         
    }

    public void SetVolume (float Volume)
    {

        audioMixer.SetFloat("Volume", Volume);
    }

    public void SetQuality(int QualityIndex)
    {
        QualitySettings.SetQualityLevel(QualityIndex);
        print(QualityIndex);
    }

    
}