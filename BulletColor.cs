using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletColor : MonoBehaviour
{
    public Color ColorSet;
    float colorR = 16f;
    float colorG = 24f;
    float colorB = 71f;
    public float StartLife;
    public ParticleSystem PS;
    bool numTrig;

    private void Awake()
    {
        PS = GetComponent<ParticleSystem>();

    }

}