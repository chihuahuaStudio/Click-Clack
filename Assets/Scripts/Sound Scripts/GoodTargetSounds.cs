using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodTargetSounds : MonoBehaviour
{
    public PauseManager pauseScript;
    public AK.Wwise.Event goodTargetSound;

    private void Awake()
    {
        pauseScript = GameObject.Find("PauseManager").GetComponent<PauseManager>();
    }
    private void OnMouseDown()
    {
        if(!pauseScript.isGamePaused)
        {
            goodTargetSound.Post(gameObject);
        }
       
    }
}
