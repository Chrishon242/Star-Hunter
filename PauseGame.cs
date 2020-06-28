using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
public class PauseGame : MonoBehaviour
{

    public  static bool OnPause = false;
    public static bool RestoreScore = false;
     
    public void GamePaused()
    {
        OnPause = true;
        Time.timeScale = 0f;
     }

    public void GameResumed()
    {
        OnPause = false;
        Time.timeScale = 1f;
 
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1;
        OnPause = false;
        RestoreScore = true;
        PlasmaToken.AddTokens = false;
         Highscore.NewHighScore_IsTrue = false;
    }


    public void LoadMainMenu()
    {

    }

    public void Options()
    {

    }

 

}
