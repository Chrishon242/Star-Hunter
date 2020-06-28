using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpPower : MonoBehaviour
{
    //public GameObject PowerUP;   //  THE OFFCIAL POWER

    Vector3 ObjectPosition;
    Transform ChildPosition;
    public GameObject PowerUp;
    GameObject PlayerShip;
    Material PlayerMat;
    ColorControl _ColorManager;


    public float Position;
    public static bool SecondTrigger = false;
    public static bool SecondShieldA = false;
    public static bool SecondShieldB = false;

    public static bool SecondBarrellA = false;
    public static bool SecondBarrellB = false;


    private void Start()
    {
        ObjectPosition = new Vector3(0f, 0f, Position);
        PlayerShip = GameObject.FindGameObjectWithTag("Player");
        _ColorManager = FindObjectOfType<ColorControl>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.tag == "BlackHolePill")
            {
                BlackHole();
            }


            if (gameObject.tag == "SuperNovaPill")
            {

                SuperNova();
            }


            if (gameObject.tag == "HeartShieldPill")
            {
                if (SecondTrigger == true)
                {
                    SecondShieldA = true;
                    SecondShieldB = true;
                    print("last phase");
                }

                SecondTrigger = true;
                HeartShield();
            }

            if (gameObject.tag == "DoubleBarrelPill")
            {
                if (SecondTrigger == true)
                {
                    SecondBarrellA = true;
                    SecondBarrellB = true;
                    print("last phase");
                }

                SecondTrigger = true;
                DoubleBarrel();
            }
        }
    }
    void SuperNova()
    {    //, Quaternion.Euler(-90f, 0f, 0f)   JUST IN CASE WE NEED A ROTATION USE  THIS
        ChildPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Instantiate(PowerUp, ChildPosition);
        Destroy(gameObject);
    }

    void HeartShield()
    {

        ChildPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Instantiate(PowerUp, ChildPosition);
        print("Phase 1");
        Destroy(gameObject);

    }

    void BlackHole()
    {

        Instantiate(PowerUp, ObjectPosition, Quaternion.Euler(0f, 0f, 0f));
        Destroy(gameObject);
    }
    void DoubleBarrel()
    {

        ChildPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        Instantiate(PowerUp, ChildPosition);
        Destroy(gameObject);

    }
}