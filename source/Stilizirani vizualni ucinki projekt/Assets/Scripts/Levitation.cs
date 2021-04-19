using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Levitation : MonoBehaviour
{
	private Animator anim;

	private void Start()
	{
		anim = gameObject.GetComponent<Animator>();

		anim.Play(0, -1, Random.value);
	}
}
