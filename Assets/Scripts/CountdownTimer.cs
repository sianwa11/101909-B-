using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    float startingTime = 20f;
    float currentTime = 0f;
    public Text countdownText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            // start game again
            FindObjectOfType<GameManager>().endGame();
        }
    }
}
