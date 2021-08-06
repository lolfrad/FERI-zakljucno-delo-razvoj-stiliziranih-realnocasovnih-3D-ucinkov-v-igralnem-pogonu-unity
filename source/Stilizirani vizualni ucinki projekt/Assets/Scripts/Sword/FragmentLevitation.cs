using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class FragmentLevitation : MonoBehaviour
{
    [SerializeField]
    private Vector3 positionMin, positionMax;   //local position - position from current position

    [SerializeField]
    private Vector3 rotationMin, rotationMax;   //local rotation - difference from current rotation

    [SerializeField]
    [Range(0.0f, 5.0f)]
    float animTime;

    [SerializeField]
    [Range(0.0f, 1.0f)]
    float animTimeRandomizeKoeficient;

    [SerializeField]
    [Range(-2.5f, 2.5f)]
    float randomLimitMin, randomLimitMax;

    [SerializeField]
    [Range(0.0f, 1.0f)]
    float animationStartRandom;

    [SerializeField]
    private bool randomStartDirection = false;

    [SerializeField]
    private bool startDirection = true;

    private Vector3 nextPos;
    private Vector3 originalPosition;

    private bool animUp = false;
    private float animationTime;


    private void Start()
    {
        //randomize time of animation
        float rand = Random.Range(randomLimitMin, randomLimitMax);
        animTime += animTimeRandomizeKoeficient * rand;


        originalPosition = transform.position;
        //randomize next position (either max or min)
        if (randomStartDirection)
        {
            if (Mathf.Round(Random.value) == 0)
                animUp = true;
            else
                animUp = false;
        }
        else
            animUp = startDirection;

        //set next position
        if (animUp)
            nextPos = positionMin + originalPosition;
        else
            nextPos = positionMax + originalPosition;

        //set starting position to random position between min and max
        Vector3 v = positionMax - positionMin;
        transform.position = originalPosition + (Random.value * animationStartRandom * v);

        //set first animTime to be consistent with start position
        if (animUp)
            animationTime = animTime * ProgressToPoint(positionMax);
        else
            animationTime = animTime * ProgressToPoint(positionMin);



        StartCoroutine(startAnim());
    }

    private float ProgressToPoint(Vector3 point)
    {
        float distance = Vector3.Distance(positionMin, positionMax);
        float progress = Vector3.Distance(transform.position - originalPosition, point);

        float percent = progress / distance;

        Debug.Log("distance:"+distance+", progress:"+progress+", percent:" + percent);
        return percent;
    }

    private IEnumerator startAnim()
    {
        transform.DOMove(nextPos, animationTime, false).SetEase(Ease.InOutSine);

        yield return new WaitForSeconds(animationTime);

        animationTime = animTime;   //set animation time back to default after first move

        animUp = !animUp;
        if (animUp)
            nextPos = positionMin + originalPosition;
        else
            nextPos = positionMax + originalPosition;

        StartCoroutine(startAnim());
    }
}
