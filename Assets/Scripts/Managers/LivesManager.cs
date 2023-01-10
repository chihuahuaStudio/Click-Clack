using UnityEngine;
using TMPro;

public class LivesManager : MonoBehaviour
{
    public delegate void lives();
    public static event lives lostLives;
    
    public TextMeshProUGUI livesText;
    public TextMeshProUGUI gameOverText;
    public static int LivesLeft = 3;
    public int targetLeftQuantity;

    private void Awake()
    {
        gameOverText.gameObject.SetActive(false);

    }

    private void OnEnable()
    {
        lostLives += UpdateLives;
    }

    private void OnDisable()
    {
        lostLives -= UpdateLives;
    }

    private void Update()
    {
        if(GameManager.Singleton.isGameActive)
        {
            livesText.gameObject.SetActive(true);
        }

        if(LivesLeft == 0)
        {
            gameOverText.gameObject.SetActive(true);
            LivesLeft = 3;
        }
        
        livesText.text = LivesLeft.ToString();

    }

    private void UpdateLives()
    {
        targetLeftQuantity++;
        if(targetLeftQuantity == 1)
        {
            LivesLeft--;
        }
        
    }

    public static void UpdateLivesLeft()
    {
        if(lostLives != null)
        {
            lostLives();
        }
    }


}
