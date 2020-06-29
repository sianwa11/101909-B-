using UnityEngine;

public class Collider : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy !!");
            // play death sound
            // destroy
            Destroy(collision.gameObject);

            // respawn
            spawnEnemy();
        }

        if (collision.gameObject.tag == "Booster")
        {
            Debug.Log("Booster !!");
            // play powerup sound
            //destroy
            Destroy(collision.gameObject);
        }
    }

    void spawnEnemy()
    {

    }
}
