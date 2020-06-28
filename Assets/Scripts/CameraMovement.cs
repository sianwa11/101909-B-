using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera aerial;
    public Camera observer;
    public float secondCount;

    public GameObject player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        aerial.enabled = true;
        observer.enabled = false;
        // distance between player and camera
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        UpdateTimerUI();
    }

    void LateUpdate()
    {
        // implement camera follow
        transform.position = player.transform.position + offset;
    }

    void UpdateTimerUI()
    {
        secondCount += Time.deltaTime;
        // switch to observer camera after 10 seconds
        if(secondCount > 10)
        {
            aerial.enabled = false;
            observer.enabled = true;
        }
    }
}
