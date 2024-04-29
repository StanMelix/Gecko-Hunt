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
    int rightANum = 0;

    string[,] QandA =
    { {"Question 1", "A", "B", "C", "D"},
    {"Question 2", "W", "X", "Y", "Z"} };
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
        }
        else
        {
            Debug.Log("This is the wrong answer!");
        }
    }

    public void Ans2Picked()
    {
        if (rightANum == 2)
        {
            Debug.Log("This is the correct answer!");
        }
        else
        {
            Debug.Log("This is the wrong answer!");
        }
    }

    public void Ans3Picked()
    {
        if (rightANum == 3)
        {
            Debug.Log("This is the correct answer!");
        }
        else
        {
            Debug.Log("This is the wrong answer!");
        }
    }

    public void Ans4Picked()
    {
        if (rightANum == 4)
        {
            Debug.Log("This is the correct answer!");
        }
        else
        {
            Debug.Log("This is the wrong answer!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
