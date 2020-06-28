using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerManager : MonoBehaviour
{
    PlayerController playerShip;
    GameObject SelectedPlayer;
    // USE THIS SCRIPT TO SELECT BETWEEN PLAYERSHIPS

    private void Start()
    {
        playerShip = FindObjectOfType<PlayerController>();
        StartCoroutine(LoadSceneOnDestroy());
    }


    IEnumerator LoadSceneOnDestroy()
    {
        while (true)
        {
            yield return new WaitForSeconds(2f);
            if (playerShip.gameObject.activeInHierarchy == false) 
            {
                Highscore.NewHighScore_IsTrue = true;
                PlasmaToken.AddTokens = true;
                TokenCollect.AddTokensToMainMenu();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            }
        }
    }

}