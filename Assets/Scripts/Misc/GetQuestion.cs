using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GetQuestion : MonoBehaviour
{
    public TextMeshProUGUI question;
    public TextMeshProUGUI answer1;
    public TextMeshProUGUI answer2;
    public TextMeshProUGUI answer3;
    public TextMeshProUGUI answer4;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI totalTimeText;
    public GameObject Snake;
    public GameObject Gecko;
    public GameObject Tree;
    public GameObject ThornBush;
    public AudioSource SnakeCry;
    public AudioSource GeckoCry;
    private int objToSpawn;
    public float QStartingTime;
    public float newQTime;
    private float totalTime;
    int rightANum = 0;

    string[,] QandA =
    { {"On 26 March 2024, the container ship MV Dali struck which bridge in Baltimore, Maryland, causing it to collapse?",
      "Francis Scott Key Bridge", "Robert E. Lee Bridge", "Akashi Kaikyo Bridge", "Golden Gate Bridge"},
    {"How many states does the United States have?", "50", "13", "195", "500"},
    {"What is the largest city in Europe?", "Istanbul", "Moscow", "London", "Paris"},
    {"What product does NOT come from trees?", "Cloth", "Apple", "Sap", "Paper"},
    {"What is the current national bank of the United States?", "Federal Reserve", "Bank of the United States", "Bank of America", "Capital One"},
    {"Which of these Texas cities is NOT a college town?", "Loving", "College Station", "Austin", "Lubbock"}};
    int numQuestions;

    // Start is called before the first frame update
    void Start()
    {
        numQuestions = QandA.GetLength(0);
        setQandAText();
    }

    void setQandAText()
    {
        //Generates a random question from the 2D array, and randomizes the answer order.
        int qNumber = Random.Range(0, numQuestions);
        int rand1 = Random.Range(1, 5);
        int rand2 = rand1;
        while(rand2 == rand1)
        {
            rand2 = Random.Range(1, 5);
        }
        int rand3 = rand2;
        while(rand3 == rand1 || rand3 == rand2)
        {
            rand3 = Random.Range(1, 5);
        }
        int rand4 = rand3;
        while (rand4 == rand1 || rand4 == rand2 || rand4 == rand3)
        {
            rand4 = Random.Range(1, 5);
        }

        //Determines rand number of correct answer.
        if(rand1 == 1) { rightANum = 1; }
        else if(rand2 == 1) { rightANum = 2; }
        else if (rand3 == 1) { rightANum = 3; }
        else if (rand4 == 1) { rightANum = 4; }

        //Sets question + answer text.
        question.text = QandA[qNumber, 0];
        answer1.text = QandA[qNumber, rand1];
        answer2.text = QandA[qNumber, rand2];
        answer3.text = QandA[qNumber, rand3];
        answer4.text = QandA[qNumber, rand4];
    }

    public void Ans1Picked()
    {
        if(rightANum == 1)
        {
            Debug.Log("This is the correct answer!");
            AwardPoints();
        }
        else
        {
            Debug.Log("This is the wrong answer!");
            Spawn();
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans2Picked()
    {
        if (rightANum == 2)
        {
            Debug.Log("This is the correct answer!");
            AwardPoints();
        }
        else
        {
            Debug.Log("This is the wrong answer!");
            Spawn();
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans3Picked()
    {
        if (rightANum == 3)
        {
            Debug.Log("This is the correct answer!");
            AwardPoints();
        }
        else
        {
            Debug.Log("This is the wrong answer!");
            Spawn();
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans4Picked()
    {
        if (rightANum == 4)
        {
            Debug.Log("This is the correct answer!");
            AwardPoints();
        }
        else
        {
            Debug.Log("This is the wrong answer!");
            Spawn();
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Ans1Picked();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Ans2Picked();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Ans3Picked();
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Ans4Picked();
        }
        if (newQTime > 0)
        {
            newQTime -= Time.deltaTime;
            totalTime += Time.deltaTime;
        }
        else
        {
            setQandAText();
            newQTime = QStartingTime;
            Spawn();
            Spawn();
        }
        if(totalTime > 30) { QStartingTime = 14; }
        if (totalTime > 60) { QStartingTime = 13; }
        if (totalTime > 90) { QStartingTime = 12; }
        if (totalTime > 120) { QStartingTime = 11; }
        if (totalTime > 150) { QStartingTime = 10; }
        if (totalTime > 180) { QStartingTime = 9; }
        UpdateTimer(newQTime);
        UpdateTotalTime(totalTime);
    }

    void UpdateTimer(float currentTime)
    {
        currentTime += 1;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        timerText.text = seconds.ToString();
    }

    void UpdateTotalTime(float currentTime)
    {
        currentTime += 1;
        float seconds = Mathf.FloorToInt(currentTime % 60);
        float minutes = Mathf.FloorToInt(currentTime / 60);
        totalTimeText.text = "Total time: " + ((minutes * 60) + (seconds-1)).ToString();
    }

    void AwardPoints()
    {
        if (newQTime > 12) { ScoreManager.addScore(5); }
        else if (newQTime > 9) { ScoreManager.addScore(4); }
        else if (newQTime > 6) { ScoreManager.addScore(3); }
        else if (newQTime > 3) { ScoreManager.addScore(2); }
        else { ScoreManager.addScore(1); }
    }

    void Spawn()
    {
        objToSpawn = Random.Range(1, 5);
        if(objToSpawn == 1)
        {
            Instantiate(Snake, new Vector3(21, Random.Range(-4.5f, 4.5f), 0), new Quaternion(0, 0, 0, 0));
            SnakeCry.Play();
        }
        else if(objToSpawn == 2)
        {
            Instantiate(Gecko, new Vector3(21, Random.Range(-4.5f, 4.5f), 0), new Quaternion(0, 0, 0, 0));
            GeckoCry.Play();
        }
        else if(objToSpawn == 3)
        {
            Instantiate(Tree, new Vector3(21, Random.Range(-3.4f, 3.4f), 0), new Quaternion(0, 0, 0, 0));
        }
        else
        {
            Instantiate(ThornBush, new Vector3(21, Random.Range(-4.4f, 4.4f), 0), new Quaternion(0, 0, 0, 0));
        }
    }

}
