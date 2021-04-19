using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Campfire : MonoBehaviour
{
    [SerializeField]
    private GameObject firePrefab;

    [SerializeField]
    private int firesAmount;

    [SerializeField]
    private float fireSpawnRate;

    private List<Animator> fires = new List<Animator>();

    private int lastFireIndex = 0;


    private void Start()
    {
        //populate list with fire objects
        for (int i = 0; i < firesAmount; i++)
        {
            GameObject fireObj = Instantiate(firePrefab, new Vector3(0,500,0), Quaternion.identity) as GameObject;  //spawn it out of view
            fireObj.transform.parent = transform;

            Animator fireAnim = fireObj.GetComponent<Animator>();

            fires.Add(fireAnim);
        }

        StartCoroutine(SpawnFire());
    }

    private IEnumerator SpawnFire()
    {
        //uses object pooling for fire gameobjects looping through the list
        //spawn a fire object at base, wait for the specified time and spawn next one
        fires[lastFireIndex].Play("FirePoofAnim");
        updateFireIndex();

        yield return new WaitForSeconds(fireSpawnRate);

        StartCoroutine(SpawnFire());
    }

    private void updateFireIndex()
    {
        //loops objects
        lastFireIndex++;
        if (lastFireIndex >= fires.Count)
            lastFireIndex = 0;
    }
}
