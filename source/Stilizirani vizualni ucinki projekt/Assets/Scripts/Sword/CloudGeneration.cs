using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGeneration : MonoBehaviour
{
    [SerializeField]
    private GameObject clouds1, clouds2;

    [SerializeField]
    private float minZ, maxZ;

    [SerializeField]
    private float speed;

    private void Update()
    {
        //get cloud positions
        Vector3 pos1 = clouds1.transform.position;
        Vector3 pos2 = clouds2.transform.position;
 
        if (clouds1.transform.position.z >= maxZ)   //if cloud is out of limits
            clouds1.transform.position = new Vector3(pos1.x, pos1.y, minZ); //move it back to start
        else
            clouds1.transform.position = new Vector3(pos1.x, pos1.y, pos1.z + speed * Time.deltaTime);   //otherwise move it by speed

        //same with other cloud group

        if (clouds2.transform.position.z >= maxZ)
            clouds2.transform.position = new Vector3(pos2.x, pos2.y, minZ);
        else
            clouds2.transform.position = new Vector3(pos2.x, pos2.y, pos2.z + speed * Time.deltaTime);
    }
}