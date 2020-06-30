using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Camera aerialCamera;
    public Camera observerCamera;
    public float counter;

    public GameObject player;
    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        aerialCamera.enabled = true;
        observerCamera.enabled = false;
        // distance between player and camera
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        countdown();
    }

    void LateUpdate()
    {
        // implement camera follow
        transform.position = player.transform.position + offset;
    }

    void countdown()
    {
        counter += Time.deltaTime;
        // switch to observer camera after 10 seconds
        if(counter > 10)
        {
            aerialCamera.enabled = false;
            observerCamera.enabled = true;
        }
    }
}
