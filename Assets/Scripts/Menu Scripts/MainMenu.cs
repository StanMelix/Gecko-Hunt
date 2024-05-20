using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    public AudioSource music;
    public GameObject logo;
    public GameObject playButton;
    public GameObject howToPlayButton;
    public GameObject creditsButton;
    public GameObject quitButton;
    public GameObject backButton;

    public TextMeshProUGUI header;
    public GameObject instructionsText1;
    public GameObject instructionsText2;
    public GameObject creditsText;

    public void Start()
    {
        logo.SetActive(true);
        playButton.SetActive(true);
        howToPlayButton.SetActive(true);
        creditsButton.SetActive(true);
        quitButton.SetActive(true);
        backButton.SetActive(false);
        instructionsText1.SetActive(false);
        instructionsText2.SetActive(false);
        creditsText.SetActive(false);
        header.text = "";
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ShowInstructions()
    {
        logo.SetActive(false);
        playButton.SetActive(false);
        howToPlayButton.SetActive(false);
        creditsButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.SetActive(true);
        instructionsText1.SetActive(true);
        instructionsText2.SetActive(true);
        header.text = "HOW TO PLAY";
    }

    public void ShowCredits()
    {
        logo.SetActive(false);
        playButton.SetActive(false);
        howToPlayButton.SetActive(false);
        creditsButton.SetActive(false);
        quitButton.SetActive(false);
        backButton.SetActive(true);
        creditsText.SetActive(true);
        header.text = "CREDITS";
    }

    public void GoBack()
    {
        logo.SetActive(true);
        playButton.SetActive(true);
        howToPlayButton.SetActive(true);
        creditsButton.SetActive(true);
        quitButton.SetActive(true);
        backButton.SetActive(false);
        instructionsText1.SetActive(false);
        instructionsText2.SetActive(false);
        creditsText.SetActive(false);
        header.text = "";
    }

    public void QuitGame()
    {
        Debug.Log("NOOOOOO-");
        Application.Quit();
    }
}
