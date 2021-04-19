using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CoinUIController : MonoBehaviour
{
    [SerializeField]
    private Animator coinPickupAnimator;

    [SerializeField]
    private CoinPickup coinPickupScript;

    public void AnimatePickup()
    {
        coinPickupAnimator.Play("CoinPickup");
    }

    public void ResetCoin()
    {
        coinPickupAnimator.Play("CoinIdle");
        coinPickupScript.StartIdleEffect();
    }
}
