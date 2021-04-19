using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitForClickAnim : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
            anim.Play("Ruins Explosion");
    }
}
