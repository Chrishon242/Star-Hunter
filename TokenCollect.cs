using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class TokenCollect : MonoBehaviour
{

    public TextMeshProUGUI Tmp;
   public static int InGamePlasmaTokens; //    ONL TO B USED EVER IN THE GAME SCENE
    public static int FinalTokensAmount;

    const int clampedToken = 999999;


    private void Start()
    {
        Tmp = GetComponent<TextMeshProUGUI>();
        StartCoroutine(Token());
        InGamePlasmaTokens = 0;
        FinalTokensAmount = 0;
    }

    IEnumerator Token()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            InGamePlasmaTokens = Mathf.Clamp(InGamePlasmaTokens, 0, clampedToken);

            print("The total amount of tokens collected in game " + InGamePlasmaTokens);
            Tmp.text = InGamePlasmaTokens.ToString("0");
        }
    }

    public static void AddTokensToMainMenu()
    {
        FinalTokensAmount = InGamePlasmaTokens;
        print("Final amount of tokens to add " + FinalTokensAmount);
    }
}
