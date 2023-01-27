using UnityEngine;
using UnityEngine.SceneManagement;


/// <summary>
/// This class deals with the Application controls and Game states
/// </summary>
public class GameManager : MonoBehaviour
{
    #region Class field
    
    /// <summary>
    /// Singleton instance of this class
    /// </summary>
    public static GameManager Singleton { get; private set;}
    
    [Header("Game Manager Settings")]
    public GameObject startMusic;
    public bool isGameActive;
    public bool isPayMode;
    public bool isArcadeMode;
    
    
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
        isArcadeMode = false;
        Cursor.visible = true;
        UIManager.Singleton.HideTimeLeftScreen();
        UIManager.Singleton.ShowGameOverScreen();
        AkSoundEngine.PostEvent("GameOver", startMusic);
    }

    public void RestartGame()
    {
        UIManager.Singleton.HideGameOverScreen();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGamePlayMode()
    {
        isGameActive = true;
        UIManager.Singleton.ShowScore();
        SpawnManager.Singleton.StartSpawning();
    }

    public void StartGameArcadeMode()
    {
        isGameActive = true;
        UIManager.Singleton.ShowScore();
        UIManager.Singleton.ShowTimeLefttScreen();
        SpawnManager.Singleton.StartSpawning();
        
    }

    public void SetArcadeMode()
    {
        isArcadeMode = true;
    }

    public void SetPlayMode()
    {
        isPayMode = true;
    }
    

    #endregion

   

    
}
