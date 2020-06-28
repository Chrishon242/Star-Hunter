 using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Hazard_Health : MonoBehaviour
{
    public float Health;
    Vector3 deathPos;
    PlayerController DamageControl;
    int randomGen;
     public GameObject Explosion;
    public GameObject plasmaToken;
    public int TokenRewarded;

    Color StoreColor;
    Color ChangeColor;

    private void Start()
    {
        randomGen = Random.Range(-1, 2);



        DamageControl = FindObjectOfType<PlayerController>();
        deathPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        StoreColor = gameObject.GetComponent<Renderer>().material.color;


        ChangeColor = new Color(255f, 255f, 255f, 0.5f);
 
        if (gameObject.tag == "MilkyAsteroids")
        {
            TokenRewarded = 100;
        }
        else if (gameObject.tag == "TropicalAsteroids")
        {
            TokenRewarded = 200;
        }
        else if (gameObject.tag == "LemonAsteroids")
        {
            TokenRewarded = 300;
        }
        else if (gameObject.tag == "VermillionAsteroids")
        {
            TokenRewarded = 500;
        }
    }


    private void FixedUpdate()
    {
        if (Health <= 0f)
        {
            if (randomGen == 1)
            {
                plasma();
            }
            else
            {
                explosion();
            }
        }
    }

    public void plasma()
    {
        Instantiate(plasmaToken, transform.position, Quaternion.identity);
        Destroy(gameObject);
        TokenCollect.InGamePlasmaTokens += TokenRewarded;
    }
    public void explosion()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShotFire")
        {
            Health -= DamageControl.Damage;

            var block = new MaterialPropertyBlock();
            block.SetColor("_BaseColor", new Color(1f, 1f, 1f, 0.5f));

            GetComponent<Renderer>().SetPropertyBlock(block);

            Invoke("whiteFlash", 0.1f);
        }

        if (other.gameObject.tag == "SuperNova")
        {
            Health -= blastRadious.NovaDamage;
        }
    }

    private void whiteFlash()
    {
        //gameObject.GetComponent<Renderer>().SetPropertyBlock(  );
        var colorFlash = new MaterialPropertyBlock();
        colorFlash.SetColor("_BaseColor", StoreColor);
        GetComponent<Renderer>().SetPropertyBlock(colorFlash);

    }
}
