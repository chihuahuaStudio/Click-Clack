using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.Serialization;
using Time = Codice.Client.Common.Time;

public class Countdowns : MonoBehaviour
{
    [Header("Countdown Settings")]
    [SerializeField] private int countdownStartValue;
    [SerializeField] private int timeLeftStartValue;
    
    public void StartCountdownCoroutine()
    {
        StartCoroutine(CountdownCoroutine());

    }

    public void StartTimeLeftCoroutine()
    {
        StartCoroutine(TimeLeftCoroutine());
    }
    
    private IEnumerator CountdownCoroutine()
    {
        UIManager.Singleton.ShowCountdownScreen();
        while (countdownStartValue > 0)
        {
            UIManager.Singleton.UpdateCountdownText(countdownStartValue);
            countdownStartValue--;
            yield return new WaitForSecondsRealtime(1.0f);
        }
   
        if (countdownStartValue == 0 && !GameManager.Singleton.isArcadeMode)
        {
            UIManager.Singleton.HideCountdownScreen();
            GameManager.Singleton.StartGamePlayMode();
        }

        if (GameManager.Singleton.isArcadeMode)
        {
            UIManager.Singleton.HideCountdownScreen();
            GameManager.Singleton.StartGameArcadeMode();
            StartTimeLeftCoroutine();
        }
      
    }
    
    private IEnumerator TimeLeftCoroutine()
    {
        UIManager.Singleton.ShowTimeLefttScreen();
        while (timeLeftStartValue > 0)
        {
            UIManager.Singleton.UpdateTimeLeftText(timeLeftStartValue);
            timeLeftStartValue--;
            yield return new WaitForSecondsRealtime(1.0f);
        }
   
        if (countdownStartValue == 0)
        {
            UIManager.Singleton.HideTimeLeftScreen();
            GameManager.Singleton.GameOver();
        }
      
    }
}
