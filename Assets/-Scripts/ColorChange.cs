using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{

    [SerializeField] private Color Color1;
    [SerializeField] private Color Color2;

    private bool hasForce;
    private Rigidbody rb;
    private MeshRenderer blockMesh;
    

    private void Start()
    {
        blockMesh = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        blockMesh.material.color = Color1;
        
    }

    private void Update()
    {

        
        if ( rb.velocity.magnitude > 5)
        {
            blockMesh.material.color = Color.Lerp(Color2, Color1, rb.velocity.magnitude / 20);
        }
        if (rb.velocity.magnitude < 5)
        {
            blockMesh.material.color = Color.Lerp(Color1, Color2, rb.velocity.magnitude / 20);
        }


    }

}
