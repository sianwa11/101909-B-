using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public Vector3 jump;
    public bool grounded;
    public float movementSpeed;
    public float jumpVelocity = 9.0f;
    public float dirX, dirZ;
    //public EnemyController enemy;

    void Start()
    {
        movementSpeed = 30.0f;
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0, 2, 0);
        // enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<EnemyController>();
    }

    void OnCollisionStay()
    {
        grounded = true;
    }

    void Update()
    {
        dirX = Input.GetAxis("Horizontal") * movementSpeed;
        dirZ = Input.GetAxis("Vertical") * movementSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(dirX, rb.velocity.y, dirZ);

        // jump when the player clicks on space
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(jump * jumpVelocity, ForceMode.Impulse);
            grounded = false;
        }

        // if player falls down start game again
        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().endGame();
        }

        // make enemy approach when player moves front
        /*if (Input.GetAxisRaw("Vertical") == 1)
        {
            enemy.enemyCalled = true;
        } else
        {
            enemy.enemyCalled = false;
        }*/
    }
}
