using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI scoreText;
    public GameObject bullet;
    public GameObject gecko;
    public GameObject snake;
    public float score;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: yes" + score.ToString();
    }

    public void setScore(float gain)
    {
        score += gain;
    }
}
