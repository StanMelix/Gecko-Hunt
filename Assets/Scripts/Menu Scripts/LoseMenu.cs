using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class LoseMenu : MonoBehaviour
{
    public TextMeshProUGUI displayMessage;
    public TextMeshProUGUI displayScore;
    public TextMeshProUGUI displayTime;
    public TextMeshProUGUI displayCorrect;
    public TextMeshProUGUI displayMissed;

    public void Update()
    {
        setText();
    }
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void setText()
    {
        displayMessage.text = "You lose!";
        displayScore.text = "Total score: " + ScoreManager.totalScore;
        displayTime.text = "Total time: " + Mathf.Floor(GetQuestion.totalTime);
        displayCorrect.text = "Questions Correct: " + GetQuestion.questionsCorrect;
        displayMissed.text = "Questions Missed: " + GetQuestion.questionsMissed;
    }
}
