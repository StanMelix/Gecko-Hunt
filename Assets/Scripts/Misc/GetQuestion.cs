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
    public AudioSource BGMusic;
    public static int questionsCorrect;
    public static int questionsMissed;
    public static float totalTime;
    private int objToSpawn;
    public float QStartingTime;
    public float newQTime;
    int rightANum = 0;

    string[,] QandA =
    { {"On 26 March 2024, the container ship MV Dali struck which bridge in Baltimore, Maryland, causing it to collapse?",
      "Francis Scott Key Bridge", "Robert E. Lee Bridge", "Akashi Kaikyo Bridge", "Golden Gate Bridge"},
    {"How many states does the United States have?", "50", "13", "195", "500"},
    {"What is the largest city in Europe?", "Istanbul", "Moscow", "London", "Paris"},
    {"What product does NOT come from trees?", "Cloth", "Apple", "Sap", "Paper"},
    {"What is the current national bank of the United States?", "Federal Reserve", "Bank of the United States", "Bank of America", "Capital One"},
    {"Which of these Texas cities is NOT a college town?", "Loving", "College Station", "Austin", "Lubbock"},
    {"Who was the dictator of Germany during World War II?", "Adolf Hitler", "Joseph Stalin", "Otto van Bismarck", "Hermann Goering"},
    {"What is the capital city of Myanmar?", "Naypyidaw", "Phnom Penh", "Bangkok", "Vientiane"},
    {"What is the capital city of Nicaragua?", "Managua", "San Salvador", "Recife", "Tegucigalpa"},
    {"Which of the following is NOT a music term?", "Spaghetto", "Ritardando", "Decrescendo", "Fortissimo"},
    {"What is 4*4?", "16", "1", "8", "69"},
    {"Which of these languages is the most closely related to English?", "Persian", "Hebrew", "Arabic", "Turkish"},
    {"Which of these countries was part of the Allies during World War II?", "Soviet Union", "Romania", "Hungary", "Italy"},
    {"The McDonalds Filet-O-Fish was invented in 1962 to appeal to which religious demographic?", "Catholics", "Puritans", "Jews", "Baptists"}};
    int numQuestions;

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
        answer1.text = "1) " + QandA[qNumber, rand1];
        answer2.text = "2) " + QandA[qNumber, rand2];
        answer3.text = "3) " + QandA[qNumber, rand3];
        answer4.text = "4) " + QandA[qNumber, rand4];
    }

    public void Ans1Picked()
    {
        if(rightANum == 1)
        {
            AwardPoints();
            questionsCorrect += 1;
        }
        else
        {
            Spawn();
            if (totalTime > 180f) { Spawn(); }
            questionsMissed += 1;
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans2Picked()
    {
        if (rightANum == 2)
        {
            AwardPoints();
            questionsCorrect += 1;
        }
        else
        {
            Spawn();
            if (totalTime > 180f) { Spawn(); }
            questionsMissed += 1;
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans3Picked()
    {
        if (rightANum == 3)
        {
            AwardPoints();
            questionsCorrect += 1;
        }
        else
        {
            Spawn();
            if (totalTime > 180f) { Spawn(); }
            questionsMissed += 1;
        }
        setQandAText();
        newQTime = QStartingTime;
    }

    public void Ans4Picked()
    {
        if (rightANum == 4)
        {
            AwardPoints();
            questionsCorrect += 1;
        }
        else
        {
            Spawn();
            if (totalTime > 180f) { Spawn(); }
            questionsMissed += 1;
        }
        setQandAText();
        newQTime = QStartingTime;
    }

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
            if (totalTime > 180) { Spawn(); }
            questionsMissed += 1;
        }
        if(totalTime > 30) { QStartingTime = 14; }
        if (totalTime > 60) { QStartingTime = 13; }
        if (totalTime > 90) { QStartingTime = 12; }
        if (totalTime > 120) { QStartingTime = 11; }
        if (totalTime > 150) { QStartingTime = 10; }
        if (totalTime > 180) { QStartingTime = 9; }
        if (totalTime > 210) { QStartingTime = 8; }
        if (totalTime > 240) { QStartingTime = 7; }
        if (totalTime > 270) { QStartingTime = 6; }
        if (totalTime > 300) { QStartingTime = 5; }
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
        if (newQTime > QStartingTime * 0.8) { ScoreManager.addScore(5); }
        else if (newQTime > QStartingTime * 0.6) { ScoreManager.addScore(4); }
        else if (newQTime > QStartingTime * 0.4) { ScoreManager.addScore(3); }
        else if (newQTime > QStartingTime * 0.2) { ScoreManager.addScore(2); }
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
