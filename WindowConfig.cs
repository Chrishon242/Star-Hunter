using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowConfig : MonoBehaviour
{
    Vector3 CamPos;
    Camera Cam;
    float posX = 12f;
    float posY = 6f;

    private void Start()
    {
        Cam = Camera.main;
        Cam.useOcclusionCulling = true;
        CamPos = Cam.ViewportToWorldPoint(CamPos);
        transform.localScale = new Vector3(-CamPos.x + posX, CamPos.y + posY, 1f);
    }

}


