using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Singleton { get; private set; }
    
    [Header("UI Manager Settings")]
    [SerializeField] private GameObject startScreen;
    [SerializeField] private GameObject helpScreen;
    [SerializeField] private GameObject audioScreen;
    [SerializeField] private GameObject pauseScreen;
    [SerializeField] private GameObject restartButton;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject gameOverText;

    private void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
        }

        Singleton = this;
    }

    private void Start()
    {
        ShowStartScreen();
    }

    public void HideStartScreen()
    {
        startScreen.SetActive(false);
    }

    public void ShowStartScreen()
    {
        startScreen.SetActive(true);
    }

    public void ShowHelpScreen()
    {
        helpScreen.SetActive(true);
    }

    public void HideHelpScreen()
    {
        helpScreen.SetActive(false);
    }

    public void ShowAudioScreen()
    {
        audioScreen.SetActive(true);
    }

    public void HideAudioScreen()
    {
        audioScreen.SetActive(false);
    }

    public void ShowPauseScreen()
    {
        pauseScreen.SetActive(true);
    }

    public void HidePauseScreen()
    {
        pauseScreen.SetActive(false);
    }

    public void ShowRestartButton()
    {
        restartButton.SetActive(true);
    }

    public void HideRestartButton()
    {
        restartButton.SetActive(false);
    }

    public void ShowScore()
    {
        scoreText.SetActive(true);
    }

    public void HideScore()
    {
        scoreText.SetActive(false);
    }

    public void ShowGameOverText()
    {
        gameOverText.SetActive(true);
    }

    public void HideGameOverText()
    {
        gameOverText.SetActive(false);
    }
    
    


}
