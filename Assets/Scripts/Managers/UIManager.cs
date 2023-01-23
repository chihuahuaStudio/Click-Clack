using System;
using UnityEngine;
using UnityEngine.Serialization;

public class UIManager : MonoBehaviour
{
    public static UIManager Singleton { get; private set; }
    
    [FormerlySerializedAs("startScreen")]
    [Header("UI Manager Settings")]
    [SerializeField] private GameObject startScreenInteractables;
    [SerializeField] private GameObject startScreenText;
    [FormerlySerializedAs("helpScreen")] [SerializeField] private GameObject helpScreenInteractables;
    [SerializeField] private GameObject helpScreenText;
    [FormerlySerializedAs("audioScreen")] [SerializeField] private GameObject audioScreenInteractables;
    [SerializeField] private GameObject audioScreenText;
    [FormerlySerializedAs("pauseScreen")] [SerializeField] private GameObject pauseScreenInteractables;
    [SerializeField] private GameObject pauseScreenText;
    [FormerlySerializedAs("scoreText")] [SerializeField] private GameObject scoreTextInteractbles;
    [FormerlySerializedAs("gameOverText")] [SerializeField] private GameObject gameOverScreenInteractables;
    [SerializeField] private GameObject gameOverScreenText;

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
        startScreenInteractables.SetActive(false);
        startScreenText.SetActive(false);
    }

    public void ShowStartScreen()
    {
        startScreenInteractables.SetActive(true);
        startScreenText.SetActive(true);
    }

    public void ShowHelpScreen()
    {
        helpScreenInteractables.SetActive(true);
        helpScreenText.SetActive(true);
    }

    public void HideHelpScreen()
    {
        helpScreenInteractables.SetActive(false);
        helpScreenText.SetActive(false);
    }
    

    public void ShowAudioScreen()
    {
        audioScreenInteractables.SetActive(true);
        audioScreenText.SetActive(true);
    }

    public void HideAudioScreen()
    {
        audioScreenInteractables.SetActive(false);
        audioScreenText.SetActive(false);
    }

    public void ShowPauseScreen()
    {
        pauseScreenInteractables.SetActive(true);
        pauseScreenText.SetActive(true);
    }

    public void HidePauseScreen()
    {
        pauseScreenInteractables.SetActive(false);
        pauseScreenText.SetActive(false);
    }
    
    public void ShowScore()
    {
        scoreTextInteractbles.SetActive(true);
    }

    public void HideScore()
    {
        scoreTextInteractbles.SetActive(false);
    }

    public void ShowGameOverScreen()
    {
        gameOverScreenInteractables.SetActive(true);
        gameOverScreenText.SetActive(true);
    }

    public void HideGameOverScreen()
    {
        gameOverScreenInteractables.SetActive(false);
        gameOverScreenText.SetActive(false);
    }
    
    


}
