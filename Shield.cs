using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    ColorControl shieldMaterial;
    Material changeMaterial;
    Material PlayerDefaultMaterial;
    Material ShieldDefMat;
    GameObject player;
    public float DelayDestroy = 4f;


    private void Start()
    {
        shieldMaterial = FindObjectOfType<ColorControl>(); // create rference for the color manager to apply material
        player = GameObject.FindGameObjectWithTag("Player");   // we use this to find the player ship 

        PlayerDefaultMaterial = player.GetComponent<Renderer>().material;   // we use the refernce 'player' and store its default material 

        StartCoroutine(MaterialSwap());
    }



    IEnumerator MaterialSwap()
    {

        // StartCoroutine(ExtendPower());


        player.GetComponent<Renderer>().material = shieldMaterial.ControlColor[9]; ;
        player.GetComponent<Collider>().isTrigger = false;
        print("Phase 2");

        yield return new WaitForSeconds(5f);

        if (PickUpPower.SecondShieldA == false)
        {

            player.GetComponent<Renderer>().material = shieldMaterial.ControlColor[10];
            player.GetComponent<Collider>().isTrigger = true;
             PickUpPower.SecondTrigger = false;
            DestroyObj();
        }
        if (PickUpPower.SecondShieldB == true && PickUpPower.SecondShieldA == true)
        {
            player.GetComponent<Renderer>().material = shieldMaterial.ControlColor[9];
            player.GetComponent<Collider>().isTrigger = false;
            yield return new WaitForSeconds(5f);

            player.GetComponent<Renderer>().material = shieldMaterial.ControlColor[10];
            player.GetComponent<Collider>().isTrigger = true;
             PickUpPower.SecondTrigger = false;
            PickUpPower.SecondShieldA = false;
            PickUpPower.SecondShieldB = false;
            Shield[] shield;

            shield = FindObjectsOfType<Shield>();
            // shield[].DestroyObj();
            //   FindObjectOfType<Shield>().DestroyObj();

            foreach (Shield nshield in shield)
            {
                shield[0].DestroyObj();
                shield[1].DestroyObj();
            }

        }
    }


    void DestroyObj()
    {
        GameObject defaultShipRotation = FindObjectOfType<PlayerController>().gameObject;

      defaultShipRotation.transform.rotation =  Quaternion.Euler(0.0f, 0.0f, 0.0f);

        Destroy(gameObject);
     }



}
