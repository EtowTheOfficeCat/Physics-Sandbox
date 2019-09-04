using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartExplosion : MonoBehaviour
{
   
    void Start()
    {
        foreach (Transform chunk in transform)
        {
            var rb = chunk.GetComponent<Rigidbody>();
            
                rb.AddExplosionForce(1000, transform.position, 10);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //foreach(Transform chunk in transform)
        //{
        //    var rb = chunk.GetComponent<Rigidbody>();

        //    rb.AddExplosionForce(10, transform.position, 10);

        //}
    }


}
