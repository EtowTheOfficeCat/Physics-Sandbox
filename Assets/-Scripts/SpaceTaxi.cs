using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTaxi : MonoBehaviour
{
    Rigidbody rb;
    public float thrust;
    public float angle;

    private Transform cylinder;

    void Start()
    {
        cylinder = transform.GetChild(0);
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.T))
        {
            rb.AddForce(cylinder.up * thrust);
        }

        float rot = Input.GetAxis("Horizontal") * angle;
        cylinder.Rotate(Vector3.right * rot);
    }
}
