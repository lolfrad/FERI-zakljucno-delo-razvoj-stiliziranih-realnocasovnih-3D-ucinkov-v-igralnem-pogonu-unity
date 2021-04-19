using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class Forge : MonoBehaviour
{
    [SerializeField]
    private VisualEffect sparksVFX, sparksVFX2;


    public void StartSparks()
    {
        sparksVFX.Play();
    }
    public void StartSparks2()
    {
        sparksVFX2.Play();
    }
}
