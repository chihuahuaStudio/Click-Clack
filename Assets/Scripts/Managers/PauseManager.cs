using UnityEngine;
using UnityEngine.Serialization;

public class PauseManager : MonoBehaviour
{
    public static PauseManager Singleton { get; private set;}
    
    [Header("Pause Settings")]
    [SerializeField] KeyCode pauseKey;
    [FormerlySerializedAs("IsGamePaused")] public bool isGamePaused;
    
    private const float PAUSE_VALUE = 0f;
    private const float UNPAUSE_VALUE = 1f;

    public void Awake()
    {
        if(Singleton != null)
        {
            Destroy(gameObject);
        }
        Singleton = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Singleton.isGameActive && !isGamePaused)
        {
            PauseGame();
        }
        else if(GameManager.Singleton.isGameActive && isGamePaused)
        {
            UnPauseGame();
        }
    }

    private void PauseGame()
    {
        if(Input.GetKeyDown(pauseKey))
        {
            isGamePaused = true;
            AudioCalls.Singleton.PostWwisePauseEvent();
            Time.timeScale = PAUSE_VALUE;
            UIManager.Singleton.ShowPauseScreen();
        }
       
    }

    private void UnPauseGame()
    {
        if(Input.GetKeyDown(pauseKey))
        {
            isGamePaused = false;
            AudioCalls.Singleton.PostWwiseUnPauseEvent();
            Time.timeScale = UNPAUSE_VALUE;
            UIManager.Singleton.HidePauseScreen();
        }
        
    }

}
