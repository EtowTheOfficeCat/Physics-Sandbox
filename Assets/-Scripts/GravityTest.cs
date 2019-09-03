using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityTest : MonoBehaviour
{

    [SerializeField] float gravStrengh = 9.81f;
    [SerializeField] private Transform gravStart;
    [SerializeField] private Transform gravEnd;
    [SerializeField] private Vector3 gravDir = new Vector3(0f, -9.81f, 0f);

    void Update()
    {
        gravDir = gravEnd.position - gravStart.position;
        gravDir = gravDir.normalized;
        Debug.DrawRay(gravStart.position, gravDir, Color.green);
        Debug.DrawRay(gravStart.position, gravDir * gravStrengh, Color.green);

        if (Input.GetButton("Jump"))
        {
            Physics.gravity = gravDir;
        }
    }


}
