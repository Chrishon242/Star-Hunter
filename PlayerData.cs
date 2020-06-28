using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerData : MonoBehaviour
{
    public static float _totalPlasmaTokens;
    public static float _StoredHighScore;
    static bool OnStart = true;
    public static bool FirstFile = false;

    private void Start()
    { 
        if (OnStart == true)
        {     
            SaveManager.LoadData();
            Highscore.LoadHighscore();
            PlasmaToken.AddPlasmaTokens();
 
            OnStart = false;  
        }

        if (PauseGame.RestoreScore == true)
        {

            Highscore.LoadHighscore();
            PlasmaToken.LoadPlasmaTokens();
            PauseGame.RestoreScore = false;
        }

     }


  

    public void PlayerStats(float damage, float speed, float fireRate, float cloakTime, float tilt, GameObject PlayerShip)
    {
        // PlayerShip = LoadShip;
    }

    public void SaveData()
    {
        SaveManager.SaveData();
    }

    public void LoadData()
    {
        SaveManager.LoadData();
        Highscore.LoadHighscore();
    }


}
