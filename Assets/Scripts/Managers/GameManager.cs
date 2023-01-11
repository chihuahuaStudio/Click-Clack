using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

/// <summary>
/// This class deals with the Application controls and Game states
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Class fields

    

    
    /// <summary>
    /// Singleton instance of this class
    /// </summary>
    public static GameManager Singleton { get; private set;}
    
    [Header("Game Manager Settings")]
    public TextMeshProUGUI gameoverText;
    // public Button restartButton;
    // public GameObject titleScreen;
    public GameObject startMusic;
    public bool isGameActive;
    
    private float spawnRate = 1f;
    
    #endregion

    #region Monobehaviours

    private void Awake()
    {

        if (Singleton != null)
        {
            Destroy(gameObject);
        }
        Singleton = this;
    }

    #endregion


    #region Custom methods

    public void GameOver()
    {
        isGameActive = false;
        UIManager.Singleton.ShowGameOverText();
        UIManager.Singleton.ShowRestartButton();
        AkSoundEngine.PostEvent("GameOver", startMusic);
    }

    public void RestartGame()
    {
        UIManager.Singleton.HideGameOverText();
        UIManager.Singleton.HideRestartButton();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        isGameActive = true;
        UIManager.Singleton.ShowScore();
    }
    

    #endregion

   

    
}
