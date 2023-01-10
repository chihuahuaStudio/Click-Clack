using System;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Singleton { get; private set;}
    [Header("Score Settings")] 
    [SerializeField] private TextMeshProUGUI scoreText;

    private int _score;

    private const int DEFAULT_SCORE = 0;

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
        ScoreUpdate(DEFAULT_SCORE);
    }
    
    public void ScoreUpdate(int scoretoAdd)
    {
        _score += scoretoAdd;
        scoreText.text = "Score: " + _score;
    }
    
}
