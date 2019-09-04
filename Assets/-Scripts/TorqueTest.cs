using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorqueTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //changing the cente of mass of an object
        GetComponent<Rigidbody>().centerOfMass = Vector3.forward * 2f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Rigidbody>().AddTorque(Vector3.right, ForceMode.Impulse);
        }

        float degree = 360f;
        float radiant = Mathf.Deg2Rad * degree;
        degree = Mathf.Rad2Deg * radiant;
    }
}
