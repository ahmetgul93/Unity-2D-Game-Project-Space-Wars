using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public static int score = 0;        // The player's score. // diger scripte baglanacagı icin static

    Text text;                      // Reference to the Text component.

    void Awake()
    {
        // Set up the reference.
        text = GetComponent<Text>();

        // Reset the score.
        score = 0;
    }
    void Update()
    {
        // Set the displayed text to be the word "Score" followed by the score value.
        text.text = "Score: " + score;
    }
}
