using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForceTest : MonoBehaviour
{

    [SerializeField] private float strengh;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //rb.AddForce(Vector3.up * strengh, ForceMode.Impulse);
            rb.AddForceAtPosition(Vector3.right * strengh, transform.position + Vector3.up * 0.7f);
        }
    }
    void FixedUpdate()
    {
        //rb.AddForce(Vector3.up * strengh, ForceMode.Acceleration);
    }
}
