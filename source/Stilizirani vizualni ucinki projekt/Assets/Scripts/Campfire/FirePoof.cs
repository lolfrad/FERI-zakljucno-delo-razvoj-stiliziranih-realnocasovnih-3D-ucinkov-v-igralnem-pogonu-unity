using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePoof : MonoBehaviour
{
    private Vector3 rotationAdd = new Vector3(0, -90, -90);

    private void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.eulerAngles = new Vector3(transform.rotation.eulerAngles.x + rotationAdd.x, transform.rotation.eulerAngles.y + rotationAdd.y, transform.rotation.eulerAngles.z + rotationAdd.z);
    }
}
