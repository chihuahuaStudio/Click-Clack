using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadBox : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        gameObject.SetActive(false);
    
        if (!gameObject.CompareTag("Bad"))
        {
            GameManager.Singleton.GameOver();
            LivesManager.UpdateLivesLeft();
        }
    }

}
