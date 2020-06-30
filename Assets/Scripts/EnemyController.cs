using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 30.0f;
   // public bool enemyCalled;
    Rigidbody rb;
    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       // if (enemyCalled)
        //{
            enemyMove();
        //}
    }

    void enemyMove()
    {
        // make enemy move towards player at twice the speed of player
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * 2 * Time.fixedDeltaTime);
        rb.MovePosition(pos);
        transform.LookAt(target);
    }
}
