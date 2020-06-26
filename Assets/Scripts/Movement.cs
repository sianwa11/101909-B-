using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float movementSpeed;
    public float dirX, dirZ;

    void Start()
    {
        movementSpeed = 30.0f;
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movementSpeed;
        dirZ = Input.GetAxis("Vertical") * movementSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);
    }
}
