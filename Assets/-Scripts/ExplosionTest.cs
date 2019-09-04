using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTest : MonoBehaviour
{

    [SerializeField] private float explosionStrengh;
    [SerializeField] private Transform explosionPos;
    [SerializeField] private float explosionRadius;

    private Rigidbody[] rigidbodies;

    void Start()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (Transform chunk in transform)
        {
            var rb = chunk.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionStrengh, explosionPos.position, explosionRadius,0f, ForceMode.Force);
            }
        }

        //for (int i = 0; i < rigidbodies.Length; i++)
        //{
        //    rigidbodies[i].AddExplosionForce(explosionStrengh, explosionPos.position, explosionRadius, 1f);
        //}
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
           for (int i = 0; i < rigidbodies.Length; i++)
            {
                rigidbodies[i].AddExplosionForce(explosionStrengh, explosionPos.position, explosionRadius, 1f);
            }
        }
    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(explosionPos.position, explosionRadius);
    }


}
