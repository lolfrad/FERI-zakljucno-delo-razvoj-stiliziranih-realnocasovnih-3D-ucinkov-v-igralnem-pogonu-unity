using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * speed, 0f));
    }
}
