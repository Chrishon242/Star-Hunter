using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleTap : MonoBehaviour
{
    PlayerController playerFireRate;
    float lastFireRate;
    float FastRate = 0.1f;
    public float DestroyDelay;

    private void Start()
    {
        playerFireRate = FindObjectOfType<PlayerController>();
        lastFireRate = playerFireRate.fireRate;

        StartCoroutine(doubleTap());
    }

    IEnumerator doubleTap()
    {
        playerFireRate.fireRate = FastRate;
        yield return new WaitForSecondsRealtime(DestroyDelay);
        if (PickUpPower.SecondBarrellA == false)
        {
            playerFireRate.fireRate = lastFireRate;
            PickUpPower.SecondTrigger = false; 
            Destroy(gameObject);
        }
        if (PickUpPower.SecondBarrellA == true && PickUpPower.SecondBarrellB == true)
        {
            playerFireRate.fireRate = FastRate;
            yield return new WaitForSecondsRealtime(DestroyDelay);

            playerFireRate.fireRate = lastFireRate;
            PickUpPower.SecondTrigger = false;
            PickUpPower.SecondShieldA = false;
            PickUpPower.SecondShieldB = false;
            DoubleTap[] doubles;
            doubles = FindObjectsOfType<DoubleTap>();

            foreach (DoubleTap tap in doubles)
            {
                doubles[0].DestroyObj();
                doubles[1].DestroyObj();

            }
        }
    }

    void DestroyObj()
    {
        Destroy(gameObject);
 
    }

}
