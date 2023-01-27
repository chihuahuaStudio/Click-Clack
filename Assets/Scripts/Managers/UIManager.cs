using UnityEngine;
using TMPro;


/// <summary>
/// This class Haandles the UI screens and diplays
/// </summary>
public class UIManager : MonoBehaviour
{
    
    /// <summary>
    /// Singleton declaration
    /// </summary>
    public static UIManager Singleton { get; private set; }

    #region class fields
    
    /// <summary>
    /// UI Manager field declarations
    /// </summary>
    [Header("UI Manager Screen References")]
    [SerializeField] private GameObject startScreenInteractables;
    [SerializeField] private GameObject startScreenText;
    [SerializeField] private GameObject helpScreenInteractables;
    [SerializeField] private GameObject helpScreenText;
    [SerializeField] private GameObject audioScreenInteractables;
    [SerializeField] private GameObject audioScreenText;
    [SerializeField] private GameObject pauseScreenInteractables;
    [SerializeField] private GameObject pauseScreenText;
    [SerializeField] private GameObject scoreTextInteractbles;
    [SerializeField] private GameObject gameOverScreenInteractables;
    [SerializeField] private GameObject gameOverScreenText;
    [SerializeField] private GameObject countdownScreen;
    [SerializeField] private GameObject timeLeftCountdownScreen;

    [Header("UI Manager Text References")] 
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private TextMeshProUGUI timeLeftText;


    

    #endregion

    #region Mono

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

    #endregion

    #region Custom methods

    
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

    public void ShowCountdownScreen()
    {
        countdownScreen.SetActive(true);
    }

    public void HideCountdownScreen()
    {
        countdownScreen.SetActive(false);
    }
    
    public void UpdateCountdownText(int starValue)
    {
        countdownText.text = starValue.ToString();
    }

    public void ShowTimeLefttScreen()
    {
        timeLeftCountdownScreen.SetActive(true);
    }

    public void HideTimeLeftScreen()
    {
        timeLeftCountdownScreen.SetActive(false);
    }

    public void UpdateTimeLeftText(int timeLeft)
    {
        timeLeftText.text = $"{timeLeft.ToString()} secs";
    }
    

    #endregion
    
}
