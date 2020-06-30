using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Collider : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float deathtime = 0f;
    public Text lifeText;
    // private int score = 0;
    public int life = 1;
    public AudioSource deathSound;

    private void Start()
    {
        deathSound = GetComponent<AudioSource>();
    }

    private void Update()
    {
        deathtime += Time.deltaTime;
        // game over if life is 0
        if (life == 0 && deathtime > 2f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("Enemy !!");
            // play death sound
            deathSound.Play();
            life -= 1;
            lifeText.text = "Life:" + life;
            // destroy
            Destroy(collision.gameObject);
            // respawn
            spawnEnemy();
        }

        if (collision.gameObject.tag == "Booster")
        {
            Debug.Log("Booster !!");
            // play powerup sound

            // add life
            life += 1;
            lifeText.text = "Life:" + life;
            //destroy
            Destroy(collision.gameObject);
        }
    }

    void spawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        enemy.transform.position = new Vector3(6.9f + 5.0f, 1.1f, 2.5f);
    }
}
