using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text scoreText;
    public GameObject bullet;
    public GameObject gecko;
    public GameObject snake;
    public static int scoreCount;
    public static int totalScore;

    void Start()
    {
        scoreCount = 0;
        totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + Mathf.Round(scoreCount);
    }

    public static void addScore(int points)
    {
        scoreCount += points;
        totalScore += points;
    }
    public static int getScore()
    {
        return scoreCount;
    }
}
