using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CoinPickup : MonoBehaviour
{
    [SerializeField]
    private VisualEffect coinExplosionEffect, coinGlowEffect, coinIdleEffect;


    public void StartExplodeEffect()
    {
        coinExplosionEffect.Play();
        coinGlowEffect.Play();
    }
    public void StopIdleEffect()
    {
        coinIdleEffect.Stop();
    }

    public void StartIdleEffect()
    {
        coinIdleEffect.Play();
    }
}
