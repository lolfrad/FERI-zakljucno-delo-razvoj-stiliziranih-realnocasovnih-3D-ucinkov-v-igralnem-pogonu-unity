using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField]
    private GameObject explosionCenter;

    [SerializeField]
    private List<GameObject> lights = new List<GameObject>();

    [SerializeField]
    private float radius, power, upModifier;

    public void Explode()
    {
        foreach (GameObject light in lights)
        {
            light.SetActive(false);
        }

        Collider[] colliders = Physics.OverlapSphere(explosionCenter.transform.position, radius);

        foreach (Collider fragment in colliders)
        {
            Rigidbody rigid = fragment.GetComponent<Rigidbody>();

            if (rigid != null)
            {
                rigid.isKinematic = false;
                rigid.AddExplosionForce(power, explosionCenter.transform.position, radius, upModifier, ForceMode.Impulse);
            }
        }
    }
}
