using System;
using UnityEngine;

public class DeadBox : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        
        if (!other.gameObject.CompareTag("Bad") && GameManager.Singleton.isPayMode)
        {
            GameManager.Singleton.GameOver();
            // LivesManager.UpdateLivesLeft();
        }
    }

}
